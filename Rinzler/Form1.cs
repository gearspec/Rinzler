using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Rinzler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveListCombo.Items.Clear();
            DriveListCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (DriveInfo f in DriveInfo.GetDrives())
            {
                DriveListCombo.Items.Add(f);
            }
        }

        private void bttnUnhide_Click(object sender, EventArgs e)
        {
            string driveletter = DriveListCombo.Text;
            if (driveletter == null || driveletter == "")
            {
                MessageBox.Show("Please Select a Drive Letter First");
            }
            else
            {
                string unhideDrive = DriveListCombo.Text;
                unhideDrive = unhideDrive[0].ToString();
                unhideDrive = "/c " + unhideDrive + ": & echo Rinzler V1.1 | Unhiding folders please wait... & attrib *.* -r -a -s -h /S /D";

                textBox1.Text = unhideDrive;
                Process cmdLine = new Process();
                cmdLine.StartInfo.FileName = "cmd.exe";
                //cmdLine.StartInfo.Arguments = "/k ipconfig";
                cmdLine.StartInfo.Arguments = unhideDrive;
                cmdLine.Start();
            }
        }

        private void DriveListCombo_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string driveletter = DriveListCombo.Text;
            if (driveletter == null || driveletter == "")
            {
                MessageBox.Show("Please Select a Drive Letter First");
            }
            else
            {
                string unhideDrive = DriveListCombo.Text;
                unhideDrive = unhideDrive[0].ToString();
                unhideDrive = "/c " + unhideDrive + ": & del *.lnk";

                textBox1.Text = unhideDrive;
                Process cmdLine = new Process();
                cmdLine.StartInfo.FileName = "cmd.exe";
                cmdLine.StartInfo.Arguments = unhideDrive;
                cmdLine.Start();
            }
        }

        private void bttn_auto_Click(object sender, EventArgs e)
        {
            string driveletter = DriveListCombo.Text;
            if (driveletter == null || driveletter == "")
            {
                MessageBox.Show("Please Select a Drive Letter First");
            }
            else
            {
                string unhideDrive = DriveListCombo.Text;
                unhideDrive = unhideDrive[0].ToString();
                unhideDrive = "/c " + unhideDrive + ": & del autorun.inf & explorer .";

                textBox1.Text = unhideDrive;
                Process cmdLine = new Process();
                cmdLine.StartInfo.FileName = "cmd.exe";
                cmdLine.StartInfo.Arguments = unhideDrive;
                cmdLine.Start();
            }
        }

        private void bttn_explorer_Click(object sender, EventArgs e)
        {
            string driveletter = DriveListCombo.Text;
            if (driveletter == null || driveletter == "")
            {
                MessageBox.Show("Please Select a Drive Letter First");
            }
            else
            {
                string unhideDrive = DriveListCombo.Text;
                unhideDrive = unhideDrive[0].ToString();
                unhideDrive = "/c " + unhideDrive + ": & explorer .";

                textBox1.Text = unhideDrive;
                Process cmdLine = new Process();
                cmdLine.StartInfo.FileName = "cmd.exe";
                cmdLine.StartInfo.Arguments = unhideDrive;
                cmdLine.Start();
            }
        }

        private void bttnDelAll_Click(object sender, EventArgs e)
        {
            string driveletter = DriveListCombo.Text;
            if (driveletter == null || driveletter == "" || driveletter =="C:\\")
            {
                MessageBox.Show("Please Select a Drive Letter First and Drive C cannot Be invoked");
            }
            else
            {
                string unhideDrive = DriveListCombo.Text;
                unhideDrive = unhideDrive[0].ToString();
                unhideDrive = "/c " + unhideDrive + ": & del *.* explorer .";

                textBox1.Text = unhideDrive;
                Process cmdLine = new Process();
                cmdLine.StartInfo.FileName = "cmd.exe";
                cmdLine.StartInfo.Arguments = unhideDrive;
                cmdLine.Start();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void howToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://sourceforge.net/projects/rinzler/");
        }

        private void donateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=446TEJYU6URKS");
            
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed By Sayem Chaklader.\ngearspec at gmail.com\nLast Updated: 13th May 2014.\nOpen Source Software, Bangladesh.\nRinzler: A Little tool to delete autorun.inf and unhide files/folders");
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.opensource.org/");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sourceforge.net/projects/rinzler");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.microsoft.com/net/downloads");
        }

        private void bttn_rem_vba_Click(object sender, EventArgs e)
        {
            string driveletter = DriveListCombo.Text;
            if (driveletter == null || driveletter == "" || driveletter == "C:\\")
            {
                MessageBox.Show("Please Select a Drive Letter First and Drive C cannot Be invoked");
            }
            else
            {
                string unhideDrive = DriveListCombo.Text;
                unhideDrive = unhideDrive[0].ToString();
                unhideDrive = "/c " + unhideDrive + ": & del *.vba";

                textBox1.Text = unhideDrive;
                Process cmdLine = new Process();
                cmdLine.StartInfo.FileName = "cmd.exe";
                cmdLine.StartInfo.Arguments = unhideDrive;
                cmdLine.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string driveletter = DriveListCombo.Text;
            if (driveletter == null || driveletter == "" || driveletter == "C:\\")
            {
                MessageBox.Show("Please Select a Drive Letter First and Drive C cannot Be invoked");
            }
            else
            {
                string unhideDrive = DriveListCombo.Text;
                unhideDrive = unhideDrive[0].ToString();
                unhideDrive = "/c " + unhideDrive + ": & del *.ini";

                textBox1.Text = unhideDrive;
                Process cmdLine = new Process();
                cmdLine.StartInfo.FileName = "cmd.exe";
                cmdLine.StartInfo.Arguments = unhideDrive;
                cmdLine.Start();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bttn_perform_all_Click(object sender, EventArgs e)
        {
            button2_Click_1   (sender, e);  //calling delete all ini
            bttn_rem_vba_Click(sender, e);  //calling delete all vba
            bttn_auto_Click   (sender, e);  //calling delete all autorun
            button1_Click     (sender, e);  //calling delete all shortcut
            bttnUnhide_Click  (sender, e);  //finally unhide folder

        }

        private void DriveListCombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DriveListCombo.Items.Clear();
            DriveListCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (DriveInfo f in DriveInfo.GetDrives())
            {
                DriveListCombo.Items.Add(f);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string unhideDrive ="da.reg";

            textBox1.Text = unhideDrive;
            Process cmdLine = new Process();
            cmdLine.StartInfo.FileName = "regedit";
            cmdLine.StartInfo.Arguments = unhideDrive;
            cmdLine.Start();
        }

        private void projectWebPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://rinzler.sourceforge.net");
        }
    }
}
