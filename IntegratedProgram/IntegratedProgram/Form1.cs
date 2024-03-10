using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegratedProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartProgram("wndDownload\\bin\\Debug\\HttpDownload.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartProgram("wndWWW\\bin\\Debug\\WebBrowser.exe");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StartProgram("wndDNSIP\\bin\\Debug\\DNSIP.exe");
        }
        private void StartProgram(string programPath)
        {
            try
            {
                Process.Start(programPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during launching the application: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
    }
}
