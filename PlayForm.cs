using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QGameComplete
{
    public partial class PlayForm : Form
    {
        int ROWS = 0;
        int COLUMNS = 0;
        bool isBoxSelected = false;
        Tile[,] tiles;
        Tile selectedBox = null;
        int remainingBoxes = 0;
        int totalMoves = 0;
        public PlayForm()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Loads the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            totalMoves = 0;
            totalMovesTextBox.Text = totalMoves.ToString();
            remainingBoxes = 0;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt | All files(*.*) | *.*";
            openFileDialog.FilterIndex = 0;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string openFileName = openFileDialog.FileName;
                var lines = File.ReadAllLines(openFileName);
                int totalRows = Convert.ToInt32(lines[0]);
                int totalColumns = Convert.ToInt32(lines[1]);
                int imageIndex = 0;
                COLUMNS = totalColumns;
                ROWS = totalRows;
                tiles = new Tile[totalColumns, totalRows];
                Block blockItem = new Block();
                for (int i = 2; i < lines.Length; i += 3)
                {
                    int rowIndex = Convert.ToInt32(lines[i]);
                    int columnIndex = Convert.ToInt32(lines[i+1]);
                    int tileType = Convert.ToInt32(lines[i+2]);
                    switch (tileType)
                    {
                        case 0:
                            blockItem = new None();
                            break;
                        case 1:
                            blockItem = new Wall();
                            break;
                        case 2:
                            blockItem = new RedDoor();
                            break;
                        case 3:
                            blockItem = new GreenDoor();
                            break;
                        case 6:
                            blockItem = new RedBox();
                            break;
                        case 7:
                            blockItem = new GreenBox();
                            break;

                        default:
                            blockItem = new None();
                            break;
                    }
                    tiles[rowIndex, columnIndex] = new Tile();
                    tiles[rowIndex, columnIndex].Location = new Point(rowIndex * 40, columnIndex * 40);
                    tiles[rowIndex, columnIndex].Width = 40;
                    tiles[rowIndex, columnIndex].Height = 40;
                    tiles[rowIndex, columnIndex].Visible = true;
                    tiles[rowIndex, columnIndex].Name = imageIndex.ToString() + "," + rowIndex + "," + columnIndex;
                    tiles[rowIndex, columnIndex].Tag = blockItem.ItemType;
                    tiles[rowIndex, columnIndex].BorderStyle = BorderStyle.Fixed3D;
                    tiles[rowIndex, columnIndex].BackgroundImageLayout = ImageLayout.Stretch;
                    tiles[rowIndex, columnIndex].Image = blockItem.Image;
                    tiles[rowIndex, columnIndex].itemType = blockItem.ItemType;
                    tiles[rowIndex, columnIndex].ROW = rowIndex;
                    tiles[rowIndex, columnIndex].COLUMN = columnIndex;
                    if (tiles[rowIndex, columnIndex].itemType == ItemType.GreenBox || tiles[rowIndex, columnIndex].itemType == ItemType.RedBox)
                    {
                        tiles[rowIndex, columnIndex].Click += BoxClick;
                    }
                    playPanel.Controls.Add(tiles[rowIndex, columnIndex]);
                    imageIndex++;
                    if (blockItem.ItemType.ToString().Contains("Box"))
                    {
                        remainingBoxes++;
                    }
                }
                remainingTextBox.Text = remainingBoxes.ToString();
            }
        }
        /// <summary>
        /// Selects the box in the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BoxClick(object sender, EventArgs e)
        {
            Tile picBox = sender as Tile;
            selectedBox = picBox;
            string boxType = picBox.Tag.ToString();
            switch (boxType)
            {
                case "RedBox":
                    isBoxSelected = true;
                    break;
                case "GreenBox":
                    isBoxSelected = true;
                    break;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QGameControlPanel qGameControlPanel = new QGameControlPanel();
            this.Close();
            qGameControlPanel.Show();
        }

        /// <summary>
        /// This method checks whether the box is selected or not, and then moves the selected box regarding the buttons 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Move_Box(object sender, EventArgs e)
        {
            if (isBoxSelected == false)
            {
                MessageBox.Show("Click to select", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Button arrowBtn = sender as Button;
            int picIndex = Convert.ToInt32(selectedBox.Name.Split(',')[0]);
            Tile currentPictureBox = playPanel.Controls[picIndex] as Tile;
            //these if statements checks for each button whether the colored boxes are hitting their respective color door.
            if (arrowBtn.Name == "btnUp")
            {
                int nextPicIndex = picIndex - 1;
                Tile nextPicBox = playPanel.Controls[nextPicIndex] as Tile;
                if (nextPicBox.Tag.ToString() == "None")
                {
                    do
                    {
                        None blockNone = new None();
                        nextPicBox.Image = currentPictureBox.Image;
                        nextPicBox.Tag = currentPictureBox.Tag;
                        currentPictureBox.Image = blockNone.Image;
                        currentPictureBox.Tag = blockNone.ItemType;
                        currentPictureBox = playPanel.Controls[nextPicIndex] as Tile;
                        selectedBox = nextPicBox;
                        nextPicIndex = nextPicIndex - 1;
                        nextPicBox = playPanel.Controls[nextPicIndex] as Tile;
                    }
                    while (nextPicBox.Tag.ToString() == "None");
                    totalMoves += 1;
                    totalMovesTextBox.Text = totalMoves.ToString();
                }
                //This "else if" statement checks whether the red box is hitting the red door or not, if it is then it changes the red box to the none, increases number of moves and decreases boxes.
                else if (currentPictureBox.Tag.ToString().Contains("RedBox") && nextPicBox.Tag.ToString().Contains("RedDoor"))
                {
                    None blockNone = new None();
                    currentPictureBox.Image = blockNone.Image;
                    currentPictureBox.Tag = blockNone.ItemType;
                    selectedBox = new Tile();
                    isBoxSelected = false;
                    totalMoves += 1;
                    totalMovesTextBox.Text = totalMoves.ToString();
                    remainingBoxes -= 1;
                    remainingTextBox.Text = remainingBoxes.ToString();

                }
                //This "else if" statement checks whether the green box is hitting the green door or not, if it is then it changes the green box to the none, increases number of moves and decreases boxes.
                else if (currentPictureBox.Tag.ToString().Contains("GreenBox") && nextPicBox.Tag.ToString().Contains("GreenDoor"))
                {
                    None blockNone = new None();
                    currentPictureBox.Image = blockNone.Image;
                    currentPictureBox.Tag = blockNone.ItemType;
                    selectedBox = new Tile();
                    isBoxSelected = false;
                    totalMoves += 1;
                    totalMovesTextBox.Text = totalMoves.ToString();
                    remainingBoxes -= 1;
                    remainingTextBox.Text = remainingBoxes.ToString();
                }
                //if remaining boxes is zero, it shows an appropriate message and clears the play panel.
                if (remainingBoxes == 0)
                {
                    MessageBox.Show("Congratulations\nGame End.", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    playPanel.Controls.Clear();
                }

            }
            //these if statements checks for each button whether the colored boxes are hitting their respective color door.
            else if (arrowBtn.Name == "btnDown")
            {
                int nextPicIndex = picIndex + 1;
                Tile nextPicBox = playPanel.Controls[nextPicIndex] as Tile;
                if (nextPicBox.Tag.ToString() == "None")
                {
                    do
                    {
                        None none = new None();
                        nextPicBox.Image = currentPictureBox.Image;
                        nextPicBox.Tag = currentPictureBox.Tag;
                        currentPictureBox.Image = none.Image;
                        currentPictureBox.Tag = none.ItemType;
                        currentPictureBox = playPanel.Controls[nextPicIndex] as Tile;
                        selectedBox = nextPicBox;
                        nextPicIndex = nextPicIndex + 1;
                        nextPicBox = playPanel.Controls[nextPicIndex] as Tile;
                    }
                    while (nextPicBox.Tag.ToString() == "None");
                    totalMoves += 1;
                    totalMovesTextBox.Text = totalMoves.ToString();
                }
                //This "else if" statement checks whether the red box is hitting the red door or not, if it is then it changes the red box to the none, increases number of moves and decreases boxes.
                else if (currentPictureBox.Tag.ToString().Contains("RedBox") && nextPicBox.Tag.ToString().Contains("RedDoor"))
                {
                    None blockNone = new None();
                    currentPictureBox.Image = blockNone.Image;
                    currentPictureBox.Tag = blockNone.ItemType;
                    selectedBox = new Tile();
                    isBoxSelected = false;
                    totalMoves += 1;
                    totalMovesTextBox.Text = totalMoves.ToString();
                    remainingBoxes -= 1;
                    remainingTextBox.Text = remainingBoxes.ToString();

                }
                //This "else if" statement checks whether the green box is hitting the green door or not, if it is then it changes the green box to the none, increases number of moves and decreases boxes.
                else if (currentPictureBox.Tag.ToString().Contains("GreenBox") && nextPicBox.Tag.ToString().Contains("GreenDoor"))
                {
                    None blockNone = new None();
                    currentPictureBox.Image = blockNone.Image;
                    currentPictureBox.Tag = blockNone.ItemType;
                    selectedBox = new Tile();
                    isBoxSelected = false;
                    totalMoves += 1;
                    totalMovesTextBox.Text = totalMoves.ToString();
                    remainingBoxes -= 1;
                    remainingTextBox.Text = remainingBoxes.ToString();
                }
                //if remaining boxes is zero, it shows an appropriate message and clears the play panel.
                if (remainingBoxes == 0)
                {
                    MessageBox.Show("Congratulations\nGame End.", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    playPanel.Controls.Clear();
                }
            }
            //these if statements checks for each button whether the colored boxes are hitting their respective color door.
            else if (arrowBtn.Name == "btnLeft")
            {
                int nextPicIndex = picIndex - ROWS;
                Tile nextPicBox = playPanel.Controls[nextPicIndex] as Tile;
                if (nextPicBox.Tag.ToString() == "None")
                {
                    do
                    {
                        None none = new None();
                        nextPicBox.Image = currentPictureBox.Image;
                        nextPicBox.Tag = currentPictureBox.Tag;
                        currentPictureBox.Image = none.Image;
                        currentPictureBox.Tag = none.ItemType;
                        currentPictureBox = playPanel.Controls[nextPicIndex] as Tile;
                        selectedBox = nextPicBox;
                        nextPicIndex = nextPicIndex - ROWS;
                        nextPicBox = playPanel.Controls[nextPicIndex] as Tile;
                    }
                    while (nextPicBox.Tag.ToString() == "None");
                    totalMoves += 1;
                    totalMovesTextBox.Text = totalMoves.ToString();
                }
                //This "else if" statement checks whether the red box is hitting the red door or not, if it is then it changes the red box to the none, increases number of moves and decreases boxes.
                else if (currentPictureBox.Tag.ToString().Contains("RedBox") && nextPicBox.Tag.ToString().Contains("RedDoor"))
                {
                    None blockNone = new None();
                    currentPictureBox.Image = blockNone.Image;
                    currentPictureBox.Tag = blockNone.ItemType;
                    selectedBox = new Tile();
                    isBoxSelected = false;
                    totalMoves += 1;
                    totalMovesTextBox.Text = totalMoves.ToString();
                    remainingBoxes -= 1;
                    remainingTextBox.Text = remainingBoxes.ToString();

                }
                //This "else if" statement checks whether the green box is hitting the green door or not, if it is then it changes the green box to the none, increases number of moves and decreases boxes.
                else if (currentPictureBox.Tag.ToString().Contains("GreenBox") && nextPicBox.Tag.ToString().Contains("GreenDoor"))
                {
                    None blockNone = new None();
                    currentPictureBox.Image = blockNone.Image;
                    currentPictureBox.Tag = blockNone.ItemType;
                    selectedBox = new Tile();
                    isBoxSelected = false;
                    totalMoves += 1;
                    totalMovesTextBox.Text = totalMoves.ToString();
                    remainingBoxes -= 1;
                    remainingTextBox.Text = remainingBoxes.ToString();
                }
                //if remaining boxes is zero, it shows an appropriate message and clears the play panel.
                if (remainingBoxes == 0)
                {
                    MessageBox.Show("Congratulations\nGame End.", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    playPanel.Controls.Clear();
                }
            }
            //these if statements checks for each button whether the colored boxes are hitting their respective color door.
            else if (arrowBtn.Name == "btnRight")
            {
                int nextPicIndex = picIndex + ROWS;
                Tile nextPicBox = playPanel.Controls[nextPicIndex] as Tile;
                if (nextPicBox.Tag.ToString() == "None")
                {
                    do
                    {
                        None none = new None();
                        nextPicBox.Image = currentPictureBox.Image;
                        nextPicBox.Tag = currentPictureBox.Tag;
                        currentPictureBox.Image = none.Image;
                        currentPictureBox.Tag = none.ItemType;
                        currentPictureBox = playPanel.Controls[nextPicIndex] as Tile;
                        selectedBox = nextPicBox;
                        nextPicIndex = nextPicIndex + ROWS;
                        nextPicBox = playPanel.Controls[nextPicIndex] as Tile;
                    }
                    while (nextPicBox.Tag.ToString() == "None");
                    totalMoves += 1;
                    totalMovesTextBox.Text = totalMoves.ToString();
                }
                //This "else if" statement checks whether the red box is hitting the red door or not, if it is then it changes the red box to the none, increases number of moves and decreases boxes.
                else if (currentPictureBox.Tag.ToString().Contains("RedBox") && nextPicBox.Tag.ToString().Contains("RedDoor"))
                {
                    None blockNone = new None();
                    currentPictureBox.Image = blockNone.Image;
                    currentPictureBox.Tag = blockNone.ItemType;
                    selectedBox = new Tile();
                    isBoxSelected = false;
                    totalMoves += 1;
                    totalMovesTextBox.Text = totalMoves.ToString();
                    remainingBoxes -= 1;
                    remainingTextBox.Text = remainingBoxes.ToString();

                }
                //This "else if" statement checks whether the green box is hitting the green door or not, if it is then it changes the green box to the none, increases number of moves and decreases boxes.
                else if (currentPictureBox.Tag.ToString().Contains("GreenBox") && nextPicBox.Tag.ToString().Contains("GreenDoor"))
                {
                    None blockNone = new None();
                    currentPictureBox.Image = blockNone.Image;
                    currentPictureBox.Tag = blockNone.ItemType;
                    selectedBox = new Tile();
                    isBoxSelected = false;
                    totalMoves += 1;
                    totalMovesTextBox.Text = totalMoves.ToString();
                    remainingBoxes -= 1;
                    remainingTextBox.Text = remainingBoxes.ToString();
                }
                //if remaining boxes is zero, it shows an appropriate message and clears the play panel.
                if (remainingBoxes == 0)
                {
                    MessageBox.Show("Congratulations\nGame End.", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    playPanel.Controls.Clear();
                }
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
