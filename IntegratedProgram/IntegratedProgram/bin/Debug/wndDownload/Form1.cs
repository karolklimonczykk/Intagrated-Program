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
using System.Threading.Tasks;
using System.Net;

namespace Download
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btDownload_Click(object sender, EventArgs e)
        {
            try
            {
                btDownload.Visible = false;
                string remoteURI = tbURI.Text;
                string localFileName = Path.GetFullPath(tbLocalFileName.Text);
                System.Threading.Thread.Sleep(3000);

                WebClient Client = new WebClient();
                Client.DownloadFile(remoteURI, localFileName);

                lbKomunikat.Text = "Download complete";
                lbKomunikat.Invalidate();
                System.Threading.Thread.Sleep(3000);
                btDownload.Visible = true;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); btDownload.Visible = true; }
        }
    }
}
