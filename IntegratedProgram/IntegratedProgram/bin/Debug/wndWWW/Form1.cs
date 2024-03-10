using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace wndWWW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            string address = tbAdres.Text;
            if (!address.StartsWith("http://")&!address.StartsWith("https://")){
                MessageBox.Show("HTTP or https protocol required");
                return;
            }
            webBrowser.Navigate(address);
        }
    }
}
