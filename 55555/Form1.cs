﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _55555
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startsInfo = new ProcessStartInfo();
            startsInfo.CreateNoWindow = true;
            startsInfo.UseShellExecute = false;
            startsInfo.FileName = "C:\\Program Files\\Java\\jdk-19\\bin\\java.exe";
            startsInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startsInfo.RedirectStandardOutput = true;
            startsInfo.WorkingDirectory = "D:\\New folder (2)";
            startsInfo.Arguments = $" duycop {textBox1.Text} {textBox2.Text}";
            try
            {
                using (Process exe = Process.Start(startsInfo))
                {
                    exe.WaitForExit();
                    while (!exe.StandardOutput.EndOfStream)
                    {
                        string line = exe.StandardOutput.ReadLine();
                        textBox3.AppendText(line + "\n");

                    }
                }
            }
            catch (Exception ex)
            {
                textBox3.AppendText(ex.Message);
            }
        }
    }
}
