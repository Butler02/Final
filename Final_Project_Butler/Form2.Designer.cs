namespace Final_Project_Butler
{
    partial class fmCreateFighter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmCreateFighter));
            this.tbFighterName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboxElement = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSelectFighterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileShowHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.rbYoda = new System.Windows.Forms.RadioButton();
            this.rbDoomsday = new System.Windows.Forms.RadioButton();
            this.rbAbe = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFighterName
            // 
            this.tbFighterName.Location = new System.Drawing.Point(159, 492);
            this.tbFighterName.Name = "tbFighterName";
            this.tbFighterName.Size = new System.Drawing.Size(100, 22);
            this.tbFighterName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name your fighter:";
            // 
            // comboxElement
            // 
            this.comboxElement.FormattingEnabled = true;
            this.comboxElement.Items.AddRange(new object[] {
            "Solar",
            "Void",
            "Arc"});
            this.comboxElement.Location = new System.Drawing.Point(423, 489);
            this.comboxElement.Name = "comboxElement";
            this.comboxElement.Size = new System.Drawing.Size(121, 24);
            this.comboxElement.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileSelectFighterToolStripMenuItem,
            this.fileShowHistoryToolStripMenuItem,
            this.fileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // fileSelectFighterToolStripMenuItem
            // 
            this.fileSelectFighterToolStripMenuItem.Name = "fileSelectFighterToolStripMenuItem";
            this.fileSelectFighterToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.fileSelectFighterToolStripMenuItem.Text = "Select Fighter";
            this.fileSelectFighterToolStripMenuItem.Click += new System.EventHandler(this.selectFighterToolStripMenuItem_Click);
            // 
            // fileShowHistoryToolStripMenuItem
            // 
            this.fileShowHistoryToolStripMenuItem.Name = "fileShowHistoryToolStripMenuItem";
            this.fileShowHistoryToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.fileShowHistoryToolStripMenuItem.Text = "show history";
            this.fileShowHistoryToolStripMenuItem.Click += new System.EventHandler(this.fileShowHistoryToolStripMenuItem_Click);
            // 
            // fileExit
            // 
            this.fileExit.Name = "fileExit";
            this.fileExit.Size = new System.Drawing.Size(174, 26);
            this.fileExit.Text = "Exit";
            this.fileExit.Click += new System.EventHandler(this.fileExit_Click);
            // 
            // rbYoda
            // 
            this.rbYoda.AutoSize = true;
            this.rbYoda.Location = new System.Drawing.Point(76, 329);
            this.rbYoda.Name = "rbYoda";
            this.rbYoda.Size = new System.Drawing.Size(126, 21);
            this.rbYoda.TabIndex = 4;
            this.rbYoda.TabStop = true;
            this.rbYoda.Text = "Old Green Man";
            this.rbYoda.UseVisualStyleBackColor = true;
            // 
            // rbDoomsday
            // 
            this.rbDoomsday.AutoSize = true;
            this.rbDoomsday.Location = new System.Drawing.Point(351, 329);
            this.rbDoomsday.Name = "rbDoomsday";
            this.rbDoomsday.Size = new System.Drawing.Size(112, 21);
            this.rbDoomsday.TabIndex = 5;
            this.rbDoomsday.TabStop = true;
            this.rbDoomsday.Text = "Ugly Monster";
            this.rbDoomsday.UseVisualStyleBackColor = true;
            // 
            // rbAbe
            // 
            this.rbAbe.AutoSize = true;
            this.rbAbe.Location = new System.Drawing.Point(621, 329);
            this.rbAbe.Name = "rbAbe";
            this.rbAbe.Size = new System.Drawing.Size(125, 21);
            this.rbAbe.TabIndex = 6;
            this.rbAbe.TabStop = true;
            this.rbAbe.Text = "Vampire Slayer";
            this.rbAbe.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Choose element: ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(281, 69);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(245, 254);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(554, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(251, 230);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(631, 482);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 37);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Fight!";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(817, 24);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 19);
            // 
            // fmCreateFighter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 563);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rbAbe);
            this.Controls.Add(this.rbDoomsday);
            this.Controls.Add(this.rbYoda);
            this.Controls.Add(this.comboxElement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFighterName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmCreateFighter";
            this.Text = "Create Fighter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFighterName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboxElement;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileSelectFighterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileShowHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileExit;
        private System.Windows.Forms.RadioButton rbYoda;
        private System.Windows.Forms.RadioButton rbDoomsday;
        private System.Windows.Forms.RadioButton rbAbe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}