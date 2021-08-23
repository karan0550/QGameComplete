namespace QGameComplete
{
    partial class DesignForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelToolBox = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGreenBox = new System.Windows.Forms.Button();
            this.btnRedBox = new System.Windows.Forms.Button();
            this.btnGreenDoor = new System.Windows.Forms.Button();
            this.btnRedDoor = new System.Windows.Forms.Button();
            this.btnWall = new System.Windows.Forms.Button();
            this.btnNone = new System.Windows.Forms.Button();
            this.gridPanel = new System.Windows.Forms.Panel();
            this.generatePanel = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtColumns = new System.Windows.Forms.TextBox();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.panelToolBox.SuspendLayout();
            this.generatePanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelToolBox
            // 
            this.panelToolBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelToolBox.Controls.Add(this.label1);
            this.panelToolBox.Controls.Add(this.btnGreenBox);
            this.panelToolBox.Controls.Add(this.btnRedBox);
            this.panelToolBox.Controls.Add(this.btnGreenDoor);
            this.panelToolBox.Controls.Add(this.btnRedDoor);
            this.panelToolBox.Controls.Add(this.btnWall);
            this.panelToolBox.Controls.Add(this.btnNone);
            this.panelToolBox.Location = new System.Drawing.Point(10, 169);
            this.panelToolBox.Name = "panelToolBox";
            this.panelToolBox.Size = new System.Drawing.Size(237, 593);
            this.panelToolBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tool Box";
            // 
            // btnGreenBox
            // 
            this.btnGreenBox.Image = global::QGameComplete.Properties.Resources.GreenBox;
            this.btnGreenBox.Location = new System.Drawing.Point(19, 419);
            this.btnGreenBox.Name = "btnGreenBox";
            this.btnGreenBox.Size = new System.Drawing.Size(199, 68);
            this.btnGreenBox.TabIndex = 5;
            this.btnGreenBox.Text = "Green Box";
            this.btnGreenBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGreenBox.UseVisualStyleBackColor = true;
            this.btnGreenBox.Click += new System.EventHandler(this.Tool_Click);
            // 
            // btnRedBox
            // 
            this.btnRedBox.Image = global::QGameComplete.Properties.Resources.RedBox;
            this.btnRedBox.Location = new System.Drawing.Point(19, 345);
            this.btnRedBox.Name = "btnRedBox";
            this.btnRedBox.Size = new System.Drawing.Size(199, 68);
            this.btnRedBox.TabIndex = 4;
            this.btnRedBox.Text = "Red Box";
            this.btnRedBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRedBox.UseVisualStyleBackColor = true;
            this.btnRedBox.Click += new System.EventHandler(this.Tool_Click);
            // 
            // btnGreenDoor
            // 
            this.btnGreenDoor.Image = global::QGameComplete.Properties.Resources.GreenDoor;
            this.btnGreenDoor.Location = new System.Drawing.Point(19, 271);
            this.btnGreenDoor.Name = "btnGreenDoor";
            this.btnGreenDoor.Size = new System.Drawing.Size(199, 68);
            this.btnGreenDoor.TabIndex = 3;
            this.btnGreenDoor.Text = "Green Door";
            this.btnGreenDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenDoor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGreenDoor.UseVisualStyleBackColor = true;
            this.btnGreenDoor.Click += new System.EventHandler(this.Tool_Click);
            // 
            // btnRedDoor
            // 
            this.btnRedDoor.Image = global::QGameComplete.Properties.Resources.RedDoor;
            this.btnRedDoor.Location = new System.Drawing.Point(19, 197);
            this.btnRedDoor.Name = "btnRedDoor";
            this.btnRedDoor.Size = new System.Drawing.Size(199, 68);
            this.btnRedDoor.TabIndex = 2;
            this.btnRedDoor.Text = "Red Door";
            this.btnRedDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedDoor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRedDoor.UseVisualStyleBackColor = true;
            this.btnRedDoor.Click += new System.EventHandler(this.Tool_Click);
            // 
            // btnWall
            // 
            this.btnWall.Image = global::QGameComplete.Properties.Resources.Wall;
            this.btnWall.Location = new System.Drawing.Point(19, 123);
            this.btnWall.Name = "btnWall";
            this.btnWall.Size = new System.Drawing.Size(199, 68);
            this.btnWall.TabIndex = 1;
            this.btnWall.Text = "Wall";
            this.btnWall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWall.UseVisualStyleBackColor = true;
            this.btnWall.Click += new System.EventHandler(this.Tool_Click);
            // 
            // btnNone
            // 
            this.btnNone.Image = global::QGameComplete.Properties.Resources.None;
            this.btnNone.Location = new System.Drawing.Point(19, 49);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(199, 68);
            this.btnNone.TabIndex = 0;
            this.btnNone.Text = "None";
            this.btnNone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.Tool_Click);
            // 
            // gridPanel
            // 
            this.gridPanel.Location = new System.Drawing.Point(257, 169);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(903, 592);
            this.gridPanel.TabIndex = 1;
            // 
            // generatePanel
            // 
            this.generatePanel.Controls.Add(this.btnGenerate);
            this.generatePanel.Controls.Add(this.txtColumns);
            this.generatePanel.Controls.Add(this.txtRows);
            this.generatePanel.Controls.Add(this.label3);
            this.generatePanel.Controls.Add(this.label2);
            this.generatePanel.Location = new System.Drawing.Point(9, 48);
            this.generatePanel.Name = "generatePanel";
            this.generatePanel.Size = new System.Drawing.Size(1150, 111);
            this.generatePanel.TabIndex = 2;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(636, 33);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(104, 23);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtColumns
            // 
            this.txtColumns.Location = new System.Drawing.Point(438, 35);
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.Size = new System.Drawing.Size(100, 22);
            this.txtColumns.TabIndex = 3;
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(112, 35);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(100, 22);
            this.txtRows.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(344, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Columns:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rows:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1170, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveMenu,
            this.closeMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(46, 24);
            this.fileMenu.Text = "File";
            // 
            // saveMenu
            // 
            this.saveMenu.Name = "saveMenu";
            this.saveMenu.Size = new System.Drawing.Size(224, 26);
            this.saveMenu.Text = "Save";
            this.saveMenu.Click += new System.EventHandler(this.saveMenu_Click);
            // 
            // closeMenu
            // 
            this.closeMenu.Name = "closeMenu";
            this.closeMenu.Size = new System.Drawing.Size(224, 26);
            this.closeMenu.Text = "Close";
            this.closeMenu.Click += new System.EventHandler(this.closeMenu_Click);
            // 
            // DesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 762);
            this.Controls.Add(this.generatePanel);
            this.Controls.Add(this.gridPanel);
            this.Controls.Add(this.panelToolBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DesignForm";
            this.Text = "DesignForm";
            this.panelToolBox.ResumeLayout(false);
            this.panelToolBox.PerformLayout();
            this.generatePanel.ResumeLayout(false);
            this.generatePanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelToolBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGreenBox;
        private System.Windows.Forms.Button btnRedBox;
        private System.Windows.Forms.Button btnGreenDoor;
        private System.Windows.Forms.Button btnRedDoor;
        private System.Windows.Forms.Button btnWall;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.Panel generatePanel;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtColumns;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem saveMenu;
        private System.Windows.Forms.ToolStripMenuItem closeMenu;
    }
}