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
using System.Net;
namespace wndDNSIP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string MyName= Dns.GetHostName();
            lbMyName.Text += MyName;
            foreach (IPAddress ip in Dns.GetHostByName(MyName).AddressList)
                lbMyIP.Text += ip.ToString() + "; ";


        }
        private void btSearchIP_Click(object sender, EventArgs e)
        {
            btSearchhIP.Visible = false;
            btSearchhIP.Invalidate();
            string obcaNazwa = tbObcaNazwa.Text.Trim();
            if (obcaNazwa.Length == 0)
            {
                btSearchhIP.Visible = true;
                return;
            }
            try
            {
                lbZnalezioneIP.Text = Dns.GetHostEntry(obcaNazwa).AddressList[0].ToString();
                btSearchhIP.Visible = true;
                btSearchhIP.Invalidate();
            }
            catch (Exception ex) { MessageBox.Show("Invalid DNS name: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); btSearchhIP.Visible = true; }

        }

        private void btSearchName_Click(object sender, EventArgs e)
        {
            btSearchName.Visible = false;
            btSearchName.Invalidate();
            string ForeignIP = tbObceIP.Text.Trim();
            if (ForeignIP.Length == 0)
            {
                btSearchName.Visible = true;
                return;
            }
            try
            {
                lbFoundName.Text = Dns.GetHostEntry(ForeignIP).HostName;
                btSearchName.Visible = true;
                btSearchName.Invalidate();
            }
            catch (Exception ex) { MessageBox.Show("Invalid IP address: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ; btSearchName.Visible = true; }

        }
    }
}
