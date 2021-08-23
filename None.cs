using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QGameComplete
{
    public class None : Block
    {
        public PictureBox pictureBox = new PictureBox();
        public None()
        {
            //pictureBox.Image = null;
            Image = Properties.Resources.None;
            ItemType = ItemType.None;
        }
    }
}
