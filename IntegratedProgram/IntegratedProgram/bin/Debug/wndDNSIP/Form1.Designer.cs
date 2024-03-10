namespace wndDNSIP
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
            this.lbMyName = new System.Windows.Forms.Label();
            this.lbMyIP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbObcaNazwa = new System.Windows.Forms.TextBox();
            this.tbObceIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbZnalezioneIP = new System.Windows.Forms.Label();
            this.lbFoundName = new System.Windows.Forms.Label();
            this.btSearchName = new System.Windows.Forms.Button();
            this.btSearchhIP = new System.Windows.Forms.Button();
            this.bt_Zamknij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMyName
            // 
            this.lbMyName.AutoSize = true;
            this.lbMyName.Location = new System.Drawing.Point(70, 23);
            this.lbMyName.Name = "lbMyName";
            this.lbMyName.Size = new System.Drawing.Size(53, 13);
            this.lbMyName.TabIndex = 0;
            this.lbMyName.Text = "My name:";
            // 
            // lbMyIP
            // 
            this.lbMyIP.AutoSize = true;
            this.lbMyIP.Location = new System.Drawing.Point(70, 58);
            this.lbMyIP.Name = "lbMyIP";
            this.lbMyIP.Size = new System.Drawing.Size(37, 13);
            this.lbMyIP.TabIndex = 1;
            this.lbMyIP.Text = "My IP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Foreign name :";
            // 
            // tbObcaNazwa
            // 
            this.tbObcaNazwa.Location = new System.Drawing.Point(169, 130);
            this.tbObcaNazwa.Name = "tbObcaNazwa";
            this.tbObcaNazwa.Size = new System.Drawing.Size(100, 20);
            this.tbObcaNazwa.TabIndex = 3;
            // 
            // tbObceIP
            // 
            this.tbObceIP.Location = new System.Drawing.Point(169, 223);
            this.tbObceIP.Name = "tbObceIP";
            this.tbObceIP.Size = new System.Drawing.Size(100, 20);
            this.tbObceIP.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Foreign IP:";
            // 
            // lbZnalezioneIP
            // 
            this.lbZnalezioneIP.AutoSize = true;
            this.lbZnalezioneIP.Location = new System.Drawing.Point(169, 166);
            this.lbZnalezioneIP.Name = "lbZnalezioneIP";
            this.lbZnalezioneIP.Size = new System.Drawing.Size(59, 13);
            this.lbZnalezioneIP.TabIndex = 6;
            this.lbZnalezioneIP.Text = "- IP found -";
            // 
            // lbFoundName
            // 
            this.lbFoundName.AutoSize = true;
            this.lbFoundName.Location = new System.Drawing.Point(169, 263);
            this.lbFoundName.Name = "lbFoundName";
            this.lbFoundName.Size = new System.Drawing.Size(75, 13);
            this.lbFoundName.TabIndex = 7;
            this.lbFoundName.Text = "- name found -";
            // 
            // btSearchName
            // 
            this.btSearchName.BackColor = System.Drawing.Color.Lime;
            this.btSearchName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btSearchName.Location = new System.Drawing.Point(45, 252);
            this.btSearchName.Name = "btSearchName";
            this.btSearchName.Size = new System.Drawing.Size(98, 24);
            this.btSearchName.TabIndex = 8;
            this.btSearchName.Text = "Search";
            this.btSearchName.UseVisualStyleBackColor = false;
            this.btSearchName.Click += new System.EventHandler(this.btSearchName_Click);
            // 
            // btSearchhIP
            // 
            this.btSearchhIP.BackColor = System.Drawing.Color.Lime;
            this.btSearchhIP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btSearchhIP.Location = new System.Drawing.Point(45, 160);
            this.btSearchhIP.Name = "btSearchhIP";
            this.btSearchhIP.Size = new System.Drawing.Size(98, 24);
            this.btSearchhIP.TabIndex = 9;
            this.btSearchhIP.Text = "Search";
            this.btSearchhIP.UseVisualStyleBackColor = false;
            this.btSearchhIP.Click += new System.EventHandler(this.btSearchIP_Click);
            // 
            // bt_Zamknij
            // 
            this.bt_Zamknij.BackColor = System.Drawing.Color.Red;
            this.bt_Zamknij.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_Zamknij.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_Zamknij.Location = new System.Drawing.Point(249, 366);
            this.bt_Zamknij.Name = "bt_Zamknij";
            this.bt_Zamknij.Size = new System.Drawing.Size(144, 52);
            this.bt_Zamknij.TabIndex = 10;
            this.bt_Zamknij.Text = "Exit";
            this.bt_Zamknij.UseVisualStyleBackColor = false;
            this.bt_Zamknij.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Zamknij);
            this.Controls.Add(this.btSearchhIP);
            this.Controls.Add(this.btSearchName);
            this.Controls.Add(this.lbFoundName);
            this.Controls.Add(this.lbZnalezioneIP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbObceIP);
            this.Controls.Add(this.tbObcaNazwa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMyIP);
            this.Controls.Add(this.lbMyName);
            this.Name = "Form1";
            this.Text = "DNS & IP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMyName;
        private System.Windows.Forms.Label lbMyIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbObcaNazwa;
        private System.Windows.Forms.TextBox tbObceIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbZnalezioneIP;
        private System.Windows.Forms.Label lbFoundName;
        private System.Windows.Forms.Button btSearchName;
        private System.Windows.Forms.Button btSearchhIP;
        private System.Windows.Forms.Button bt_Zamknij;
    }
}

