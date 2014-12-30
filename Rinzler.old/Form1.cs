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
                unhideDrive = "/c " + unhideDrive + ": & attrib *. -h -s /s /d";

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
                unhideDrive = "/c " + unhideDrive + ": & DEL /F /S /Q /A *.lnk";

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
                unhideDrive = "/c " + unhideDrive + ": & DEL /F /S /Q /A autorun.inf & explorer .";

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
                unhideDrive = "/c " + unhideDrive + ": & DEL /F /S /Q /A *.*";

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
            MessageBox.Show("Developed By Sayem Chaklader, CS, IUB.\ngearspec at gmail.com\nLast Updated: 21st Aug 2014. V1.2.1\nOpen Source Software, Bangladesh.\nRinzler: A Little tool to delete autorun.inf and unhide files/folders");
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
                unhideDrive = "/c " + unhideDrive + ": & DEL /F /S /Q /A *.vba & DEL /F /S /Q /A *.vbs & DEL /F /S /Q /A *.vbe";

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
                unhideDrive = "/c " + unhideDrive + ": & DEL /F /S /Q /A *.ini";

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
            button2_Click_1(sender, e);     //calling delete all ini
            bttn_rem_vba_Click(sender, e);  //calling delete all vba
            bttn_auto_Click(sender, e);     //calling delete all autorun
            button1_Click(sender, e);       //calling delete all shortcut
            button6_Click(sender, e);       //calling delete all thumbs.db 
            bttnUnhide_Click(sender, e);    //finally unhide folder
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
            //creating the registry file
            FileStream fs1 = new FileStream("rinzler_disable_autorun.reg", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs1);
            writer.Write("Windows Registry Editor Version 5.00\r\n;Created by Sayem Chaklader\r\n[HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer]\r\n\"NoDriveTypeAutoRun\"=dword:000000ff");
            writer.Close();

            //executing it
            string unhideDrive = "rinzler_disable_autorun.reg";

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

        private void helpAndSupportFacebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/rinzlerfree");
        }

        private void button6_Click(object sender, EventArgs e)
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
                unhideDrive = "/c " + unhideDrive + ": & DEL /F /S /Q /A thumbs.db & DEL /F /S /Q /A RECYCLER.exe";

                textBox1.Text = unhideDrive;
                Process cmdLine = new Process();
                cmdLine.StartInfo.FileName = "cmd.exe";
                cmdLine.StartInfo.Arguments = unhideDrive;
                cmdLine.Start();
            }
        }

        private void bttn_restore_tsk_Click(object sender, EventArgs e)
        {
            //creating the registry file
            FileStream fs1 = new FileStream("rinzler_restore_taskmanager.reg", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs1);
            writer.Write("Windows Registry Editor Version 5.00\r\n;Created by Sayem Chaklader\r\n[HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System] “DisableTaskMgr” =dword:00000000");
            writer.Close();

            //executing it
            string unhideDrive = "rinzler_restore_taskmanager.reg";

            textBox1.Text = unhideDrive;
            Process cmdLine = new Process();
            cmdLine.StartInfo.FileName = "regedit";
            cmdLine.StartInfo.Arguments = unhideDrive;
            cmdLine.Start();
        }

        private void bttn_restore_registry_Click(object sender, EventArgs e)
        {
            
            //creating the bat file
            FileStream fs1 = new FileStream("restore_registry.bat", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs1);
            writer.Write("echo Windows Registry Editor Version 5.00>Enable.reg\r\necho >>Enable.reg\r\necho [HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System]>>Enable.reg\r\necho \"DisableRegistryTools\"=dword:00000000>>Enable.reg\r\nregedit.exe /s Enable.reg\r\ndel /f Enable.reg\r\nexit");
            writer.Close();

            //executing it
            string restore_registry = "/c restore_registry.bat";

            textBox1.Text = restore_registry;
            Process cmdLine = new Process();
            cmdLine.StartInfo.FileName = "cmd.exe";
            cmdLine.StartInfo.Arguments = restore_registry;
            cmdLine.Start();
            
        }

        private void bttn_folder_option_Click(object sender, EventArgs e)
        {

            //creating the bat file
            FileStream fs1 = new FileStream("enable_folder_option.bat", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs1);
            writer.Write("echo Windows Registry Editor Version 5.00>Enable.reg\r\necho >>Enable.reg\r\necho [HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer]>>Enable.reg\r\necho \"NoFolderOptions\"=dword:000000000>>Enable.reg\r\nregedit.exe /s Enable.reg\r\ndel /f Enable.reg\r\nexit");
            writer.Close();

            //executing it
            string folder_option = "/c enable_folder_option.bat";

            textBox1.Text = folder_option;
            Process cmdLine = new Process();
            cmdLine.StartInfo.FileName = "cmd.exe";
            cmdLine.StartInfo.Arguments = folder_option;
            cmdLine.Start();
        }

        private void bttn_delete_all_exe_Click(object sender, EventArgs e)
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
                unhideDrive = "/c " + unhideDrive + ": & DEL /F /S /Q /A *.exe";

                textBox1.Text = unhideDrive;
                Process cmdLine = new Process();
                cmdLine.StartInfo.FileName = "cmd.exe";
                cmdLine.StartInfo.Arguments = unhideDrive;
                cmdLine.Start();
            }
        }
    }
}
