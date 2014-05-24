namespace Rinzler
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
            this.projectWebPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpAndSupportFacebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttn_explorer = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bttn_perform_all = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttn_rem_vba = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.bttn_restore_tsk = new System.Windows.Forms.Button();
            this.bttn_restore_registry = new System.Windows.Forms.Button();
            this.bttn_folder_option = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.bttnUnhide.Location = new System.Drawing.Point(30, 54);
            this.bttnUnhide.Name = "bttnUnhide";
            this.bttnUnhide.Size = new System.Drawing.Size(278, 49);
            this.bttnUnhide.TabIndex = 1;
            this.bttnUnhide.Text = "&Unhide All Files and Folder";
            this.bttnUnhide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.DriveListCombo.Size = new System.Drawing.Size(162, 25);
            this.DriveListCombo.TabIndex = 0;
            this.DriveListCombo.SelectedIndexChanged += new System.EventHandler(this.DriveListCombo_SelectedIndexChanged_1);
            this.DriveListCombo.Click += new System.EventHandler(this.DriveListCombo_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(367, 20);
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
            this.button1.Location = new System.Drawing.Point(30, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete All &Shortcut";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.bttn_auto.Location = new System.Drawing.Point(30, 147);
            this.bttn_auto.Name = "bttn_auto";
            this.bttn_auto.Size = new System.Drawing.Size(278, 38);
            this.bttn_auto.TabIndex = 3;
            this.bttn_auto.Text = "Delete all &Autorun.inf";
            this.bttn_auto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.bttnDelAll.Location = new System.Drawing.Point(358, 160);
            this.bttnDelAll.Name = "bttnDelAll";
            this.bttnDelAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bttnDelAll.Size = new System.Drawing.Size(247, 45);
            this.bttnDelAll.TabIndex = 5;
            this.bttnDelAll.Text = "&Delete All Files in Drive";
            this.bttnDelAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.menuStrip1.Size = new System.Drawing.Size(624, 27);
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
            this.projectWebPageToolStripMenuItem,
            this.howToToolStripMenuItem,
            this.helpAndSupportFacebookToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 23);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(256, 24);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.Size = new System.Drawing.Size(256, 24);
            this.donateToolStripMenuItem.Text = "Donate / Buy me a Beer";
            this.donateToolStripMenuItem.Click += new System.EventHandler(this.donateToolStripMenuItem_Click);
            // 
            // projectWebPageToolStripMenuItem
            // 
            this.projectWebPageToolStripMenuItem.Name = "projectWebPageToolStripMenuItem";
            this.projectWebPageToolStripMenuItem.Size = new System.Drawing.Size(256, 24);
            this.projectWebPageToolStripMenuItem.Text = "Project Web Page";
            this.projectWebPageToolStripMenuItem.Click += new System.EventHandler(this.projectWebPageToolStripMenuItem_Click);
            // 
            // howToToolStripMenuItem
            // 
            this.howToToolStripMenuItem.Name = "howToToolStripMenuItem";
            this.howToToolStripMenuItem.Size = new System.Drawing.Size(256, 24);
            this.howToToolStripMenuItem.Text = "Software Project Page";
            this.howToToolStripMenuItem.Click += new System.EventHandler(this.howToToolStripMenuItem_Click);
            // 
            // helpAndSupportFacebookToolStripMenuItem
            // 
            this.helpAndSupportFacebookToolStripMenuItem.Name = "helpAndSupportFacebookToolStripMenuItem";
            this.helpAndSupportFacebookToolStripMenuItem.Size = new System.Drawing.Size(256, 24);
            this.helpAndSupportFacebookToolStripMenuItem.Text = "Help and Support [Facebook]";
            this.helpAndSupportFacebookToolStripMenuItem.Click += new System.EventHandler(this.helpAndSupportFacebookToolStripMenuItem_Click);
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
            this.bttn_explorer.Location = new System.Drawing.Point(358, 114);
            this.bttn_explorer.Name = "bttn_explorer";
            this.bttn_explorer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bttn_explorer.Size = new System.Drawing.Size(247, 44);
            this.bttn_explorer.TabIndex = 4;
            this.bttn_explorer.Text = "&Open Drive in Explorer";
            this.bttn_explorer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_explorer.UseVisualStyleBackColor = false;
            this.bttn_explorer.Click += new System.EventHandler(this.bttn_explorer_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(530, 31);
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
            this.pictureBox3.Location = new System.Drawing.Point(462, 56);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(62, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // bttn_perform_all
            // 
            this.bttn_perform_all.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bttn_perform_all.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bttn_perform_all.FlatAppearance.BorderSize = 0;
            this.bttn_perform_all.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bttn_perform_all.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.bttn_perform_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_perform_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.882353F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_perform_all.ForeColor = System.Drawing.Color.White;
            this.bttn_perform_all.Location = new System.Drawing.Point(0, -1);
            this.bttn_perform_all.Name = "bttn_perform_all";
            this.bttn_perform_all.Size = new System.Drawing.Size(309, 49);
            this.bttn_perform_all.TabIndex = 17;
            this.bttn_perform_all.Text = "PERFORM A&LL ACTIONS";
            this.bttn_perform_all.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.bttn_perform_all, "Perform all the left actions at once");
            this.bttn_perform_all.UseVisualStyleBackColor = false;
            this.bttn_perform_all.Click += new System.EventHandler(this.bttn_perform_all_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(357, 56);
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
            // bttn_rem_vba
            // 
            this.bttn_rem_vba.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bttn_rem_vba.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bttn_rem_vba.FlatAppearance.BorderSize = 0;
            this.bttn_rem_vba.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bttn_rem_vba.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.bttn_rem_vba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_rem_vba.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.176471F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_rem_vba.ForeColor = System.Drawing.Color.White;
            this.bttn_rem_vba.Location = new System.Drawing.Point(30, 188);
            this.bttn_rem_vba.Name = "bttn_rem_vba";
            this.bttn_rem_vba.Size = new System.Drawing.Size(278, 38);
            this.bttn_rem_vba.TabIndex = 15;
            this.bttn_rem_vba.Text = "Delete  all &VBA,VBS Scripts";
            this.bttn_rem_vba.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_rem_vba.UseVisualStyleBackColor = false;
            this.bttn_rem_vba.Click += new System.EventHandler(this.bttn_rem_vba_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.176471F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(30, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(278, 38);
            this.button2.TabIndex = 16;
            this.button2.Text = "Delete  all &ini files";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.bttnUnhide);
            this.groupBox1.Controls.Add(this.bttn_perform_all);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.bttn_auto);
            this.groupBox1.Controls.Add(this.bttn_rem_vba);
            this.groupBox1.Location = new System.Drawing.Point(13, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 317);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "+";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.176471F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(30, 271);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(278, 38);
            this.button6.TabIndex = 18;
            this.button6.Text = "Delete  all &tumbs.db files";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.176471F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(358, 387);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(247, 46);
            this.button3.TabIndex = 19;
            this.button3.Text = "E&xit";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.176471F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(237, 63);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 25);
            this.button4.TabIndex = 20;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.176471F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(358, 207);
            this.button5.Name = "button5";
            this.button5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button5.Size = new System.Drawing.Size(247, 43);
            this.button5.TabIndex = 21;
            this.button5.Text = "Disable Auto&run Completely";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // bttn_restore_tsk
            // 
            this.bttn_restore_tsk.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bttn_restore_tsk.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bttn_restore_tsk.FlatAppearance.BorderSize = 0;
            this.bttn_restore_tsk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bttn_restore_tsk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.bttn_restore_tsk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_restore_tsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.176471F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_restore_tsk.ForeColor = System.Drawing.Color.White;
            this.bttn_restore_tsk.Location = new System.Drawing.Point(358, 252);
            this.bttn_restore_tsk.Name = "bttn_restore_tsk";
            this.bttn_restore_tsk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bttn_restore_tsk.Size = new System.Drawing.Size(247, 43);
            this.bttn_restore_tsk.TabIndex = 22;
            this.bttn_restore_tsk.Text = "Enable Task &Manager";
            this.bttn_restore_tsk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_restore_tsk.UseVisualStyleBackColor = false;
            this.bttn_restore_tsk.Click += new System.EventHandler(this.bttn_restore_tsk_Click);
            // 
            // bttn_restore_registry
            // 
            this.bttn_restore_registry.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bttn_restore_registry.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bttn_restore_registry.FlatAppearance.BorderSize = 0;
            this.bttn_restore_registry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bttn_restore_registry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.bttn_restore_registry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_restore_registry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.176471F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_restore_registry.ForeColor = System.Drawing.Color.White;
            this.bttn_restore_registry.Location = new System.Drawing.Point(358, 297);
            this.bttn_restore_registry.Name = "bttn_restore_registry";
            this.bttn_restore_registry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bttn_restore_registry.Size = new System.Drawing.Size(247, 43);
            this.bttn_restore_registry.TabIndex = 23;
            this.bttn_restore_registry.Text = "Enable &Registry Edtor (regedit)";
            this.bttn_restore_registry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_restore_registry.UseVisualStyleBackColor = false;
            this.bttn_restore_registry.Click += new System.EventHandler(this.bttn_restore_registry_Click);
            // 
            // bttn_folder_option
            // 
            this.bttn_folder_option.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bttn_folder_option.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bttn_folder_option.FlatAppearance.BorderSize = 0;
            this.bttn_folder_option.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bttn_folder_option.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.bttn_folder_option.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_folder_option.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.176471F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_folder_option.ForeColor = System.Drawing.Color.White;
            this.bttn_folder_option.Location = new System.Drawing.Point(358, 342);
            this.bttn_folder_option.Name = "bttn_folder_option";
            this.bttn_folder_option.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bttn_folder_option.Size = new System.Drawing.Size(247, 43);
            this.bttn_folder_option.TabIndex = 24;
            this.bttn_folder_option.Text = "Enable &Folder Option";
            this.bttn_folder_option.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_folder_option.UseVisualStyleBackColor = false;
            this.bttn_folder_option.Click += new System.EventHandler(this.bttn_folder_option_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.bttn_folder_option);
            this.Controls.Add(this.bttn_restore_registry);
            this.Controls.Add(this.bttn_restore_tsk);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bttn_explorer);
            this.Controls.Add(this.bttnDelAll);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DriveListCombo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Rinzler v1.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Button bttn_rem_vba;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bttn_perform_all;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStripMenuItem projectWebPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpAndSupportFacebookToolStripMenuItem;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button bttn_restore_tsk;
        private System.Windows.Forms.Button bttn_restore_registry;
        private System.Windows.Forms.Button bttn_folder_option;
    }
}

