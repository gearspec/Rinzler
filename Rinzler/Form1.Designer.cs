﻿namespace Rinzler
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bttnUnhide = new System.Windows.Forms.Button();
            this.DriveListCombo = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bttn_auto = new System.Windows.Forms.Button();
            this.bttnDelAll = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttn_explorer = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnUnhide
            // 
            this.bttnUnhide.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bttnUnhide.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bttnUnhide.FlatAppearance.BorderSize = 0;
            this.bttnUnhide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bttnUnhide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.bttnUnhide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnUnhide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.176471F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnUnhide.ForeColor = System.Drawing.Color.White;
            this.bttnUnhide.Location = new System.Drawing.Point(69, 105);
            this.bttnUnhide.Name = "bttnUnhide";
            this.bttnUnhide.Size = new System.Drawing.Size(235, 38);
            this.bttnUnhide.TabIndex = 1;
            this.bttnUnhide.Text = "&Unhide All Files and Folder";
            this.toolTip1.SetToolTip(this.bttnUnhide, "Unhides all folders and files in the selected drive.");
            this.bttnUnhide.UseVisualStyleBackColor = false;
            this.bttnUnhide.Click += new System.EventHandler(this.bttnUnhide_Click);
            // 
            // DriveListCombo
            // 
            this.DriveListCombo.BackColor = System.Drawing.Color.LightGray;
            this.DriveListCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.882353F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriveListCombo.FormattingEnabled = true;
            this.DriveListCombo.Location = new System.Drawing.Point(69, 62);
            this.DriveListCombo.Name = "DriveListCombo";
            this.DriveListCombo.Size = new System.Drawing.Size(235, 25);
            this.DriveListCombo.TabIndex = 0;
            this.DriveListCombo.Click += new System.EventHandler(this.DriveListCombo_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(327, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.176471F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(69, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete All &Shortcut";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttn_auto
            // 
            this.bttn_auto.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bttn_auto.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bttn_auto.FlatAppearance.BorderSize = 0;
            this.bttn_auto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bttn_auto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.bttn_auto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_auto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.176471F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_auto.ForeColor = System.Drawing.Color.White;
            this.bttn_auto.Location = new System.Drawing.Point(69, 188);
            this.bttn_auto.Name = "bttn_auto";
            this.bttn_auto.Size = new System.Drawing.Size(235, 38);
            this.bttn_auto.TabIndex = 3;
            this.bttn_auto.Text = "Delete &Autorun.inf";
            this.bttn_auto.UseVisualStyleBackColor = false;
            this.bttn_auto.Click += new System.EventHandler(this.bttn_auto_Click);
            // 
            // bttnDelAll
            // 
            this.bttnDelAll.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bttnDelAll.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bttnDelAll.FlatAppearance.BorderSize = 0;
            this.bttnDelAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bttnDelAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.bttnDelAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnDelAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.176471F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDelAll.ForeColor = System.Drawing.Color.White;
            this.bttnDelAll.Location = new System.Drawing.Point(333, 167);
            this.bttnDelAll.Name = "bttnDelAll";
            this.bttnDelAll.Size = new System.Drawing.Size(244, 59);
            this.bttnDelAll.TabIndex = 5;
            this.bttnDelAll.Text = "&Delete All Files in Drive";
            this.bttnDelAll.UseVisualStyleBackColor = false;
            this.bttnDelAll.Click += new System.EventHandler(this.bttnDelAll_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(598, 27);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(41, 23);
            this.menuFile.Text = "File";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.restartToolStripMenuItem.Text = "Restart Rinzler";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.donateToolStripMenuItem,
            this.howToToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 23);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(250, 24);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
            this.donateToolStripMenuItem.Text = "Donate / Buy me a Beer";
            this.donateToolStripMenuItem.Click += new System.EventHandler(this.donateToolStripMenuItem_Click);
            // 
            // howToToolStripMenuItem
            // 
            this.howToToolStripMenuItem.Name = "howToToolStripMenuItem";
            this.howToToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
            this.howToToolStripMenuItem.Text = "Go to Software Project Page";
            this.howToToolStripMenuItem.Click += new System.EventHandler(this.howToToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(11, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 56);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // bttn_explorer
            // 
            this.bttn_explorer.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bttn_explorer.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bttn_explorer.FlatAppearance.BorderSize = 0;
            this.bttn_explorer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bttn_explorer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.bttn_explorer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_explorer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.176471F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_explorer.ForeColor = System.Drawing.Color.White;
            this.bttn_explorer.Location = new System.Drawing.Point(333, 105);
            this.bttn_explorer.Name = "bttn_explorer";
            this.bttn_explorer.Size = new System.Drawing.Size(244, 58);
            this.bttn_explorer.TabIndex = 4;
            this.bttn_explorer.Text = "&Open Drive in Explorer";
            this.bttn_explorer.UseVisualStyleBackColor = false;
            this.bttn_explorer.Click += new System.EventHandler(this.bttn_explorer_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(504, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(436, 56);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(62, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(333, 56);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(97, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Select a Drive";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(598, 250);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bttn_explorer);
            this.Controls.Add(this.bttnDelAll);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bttn_auto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DriveListCombo);
            this.Controls.Add(this.bttnUnhide);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Rinzler v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnUnhide;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttn_auto;
        private System.Windows.Forms.Button bttnDelAll;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttn_explorer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox DriveListCombo;
        private System.Windows.Forms.Label label1;
    }
}
