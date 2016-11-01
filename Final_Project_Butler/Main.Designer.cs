namespace Final_Project_Butler
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.rbBluegloves = new System.Windows.Forms.RadioButton();
            this.rbGirl = new System.Windows.Forms.RadioButton();
            this.rbGuy = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createFighterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreateFighter = new System.Windows.Forms.Button();
            this.btnFight = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbBluegloves
            // 
            this.rbBluegloves.AutoSize = true;
            this.rbBluegloves.Location = new System.Drawing.Point(48, 416);
            this.rbBluegloves.Name = "rbBluegloves";
            this.rbBluegloves.Size = new System.Drawing.Size(68, 21);
            this.rbBluegloves.TabIndex = 4;
            this.rbBluegloves.TabStop = true;
            this.rbBluegloves.Text = "Srg. T";
            this.rbBluegloves.UseVisualStyleBackColor = true;
            // 
            // rbGirl
            // 
            this.rbGirl.AutoSize = true;
            this.rbGirl.Location = new System.Drawing.Point(352, 416);
            this.rbGirl.Name = "rbGirl";
            this.rbGirl.Size = new System.Drawing.Size(66, 21);
            this.rbGirl.TabIndex = 5;
            this.rbGirl.TabStop = true;
            this.rbGirl.Text = "Jamie";
            this.rbGirl.UseVisualStyleBackColor = true;
            // 
            // rbGuy
            // 
            this.rbGuy.AutoSize = true;
            this.rbGuy.Location = new System.Drawing.Point(642, 416);
            this.rbGuy.Name = "rbGuy";
            this.rbGuy.Size = new System.Drawing.Size(66, 21);
            this.rbGuy.TabIndex = 6;
            this.rbGuy.TabStop = true;
            this.rbGuy.Text = "Jimbo";
            this.rbGuy.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(857, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createFighterToolStripMenuItem,
            this.showHistoryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // createFighterToolStripMenuItem
            // 
            this.createFighterToolStripMenuItem.Name = "createFighterToolStripMenuItem";
            this.createFighterToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.createFighterToolStripMenuItem.Text = "Create Fighter";
            this.createFighterToolStripMenuItem.Click += new System.EventHandler(this.createFighterToolStripMenuItem_Click);
            // 
            // showHistoryToolStripMenuItem
            // 
            this.showHistoryToolStripMenuItem.Name = "showHistoryToolStripMenuItem";
            this.showHistoryToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.showHistoryToolStripMenuItem.Text = "Show History";
            this.showHistoryToolStripMenuItem.Click += new System.EventHandler(this.showHistoryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnCreateFighter
            // 
            this.btnCreateFighter.Location = new System.Drawing.Point(242, 477);
            this.btnCreateFighter.Name = "btnCreateFighter";
            this.btnCreateFighter.Size = new System.Drawing.Size(127, 23);
            this.btnCreateFighter.TabIndex = 9;
            this.btnCreateFighter.Text = "Create Fighter";
            this.btnCreateFighter.UseVisualStyleBackColor = true;
            this.btnCreateFighter.Click += new System.EventHandler(this.btnCreateFighter_Click);
            // 
            // btnFight
            // 
            this.btnFight.Location = new System.Drawing.Point(430, 477);
            this.btnFight.Name = "btnFight";
            this.btnFight.Size = new System.Drawing.Size(75, 23);
            this.btnFight.TabIndex = 10;
            this.btnFight.Text = "Fight";
            this.btnFight.UseVisualStyleBackColor = true;
            this.btnFight.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(569, 51);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(255, 359);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Final_Project_Butler.Properties.Resources.street_fighter_3_online_edition_characters_ibuki;
            this.pictureBox2.Location = new System.Drawing.Point(294, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(211, 359);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Project_Butler.Properties.Resources.street_fighter_3_online_edition_characters_dudley;
            this.pictureBox1.Location = new System.Drawing.Point(12, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 359);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 530);
            this.Controls.Add(this.btnFight);
            this.Controls.Add(this.btnCreateFighter);
            this.Controls.Add(this.rbGuy);
            this.Controls.Add(this.rbGirl);
            this.Controls.Add(this.rbBluegloves);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Select Fighter";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton rbBluegloves;
        private System.Windows.Forms.RadioButton rbGirl;
        private System.Windows.Forms.RadioButton rbGuy;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createFighterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnCreateFighter;
        private System.Windows.Forms.Button btnFight;
    }
}

