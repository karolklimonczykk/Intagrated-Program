namespace Download
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
            this.btDownload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbURI = new System.Windows.Forms.TextBox();
            this.tbLocalFileName = new System.Windows.Forms.TextBox();
            this.lbKomunikat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btDownload
            // 
            this.btDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btDownload.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btDownload.Location = new System.Drawing.Point(298, 318);
            this.btDownload.Name = "btDownload";
            this.btDownload.Size = new System.Drawing.Size(209, 58);
            this.btDownload.TabIndex = 0;
            this.btDownload.Text = "Download";
            this.btDownload.UseVisualStyleBackColor = false;
            this.btDownload.Click += new System.EventHandler(this.btDownload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(83, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Complete file address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(83, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Local file name:";
            // 
            // tbURI
            // 
            this.tbURI.Location = new System.Drawing.Point(87, 77);
            this.tbURI.Name = "tbURI";
            this.tbURI.Size = new System.Drawing.Size(351, 20);
            this.tbURI.TabIndex = 3;
            // 
            // tbLocalFileName
            // 
            this.tbLocalFileName.Location = new System.Drawing.Point(87, 175);
            this.tbLocalFileName.Name = "tbLocalFileName";
            this.tbLocalFileName.Size = new System.Drawing.Size(351, 20);
            this.tbLocalFileName.TabIndex = 4;
            // 
            // lbKomunikat
            // 
            this.lbKomunikat.AutoSize = true;
            this.lbKomunikat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbKomunikat.Location = new System.Drawing.Point(87, 264);
            this.lbKomunikat.Name = "lbKomunikat";
            this.lbKomunikat.Size = new System.Drawing.Size(65, 18);
            this.lbKomunikat.TabIndex = 5;
            this.lbKomunikat.Text = "waiting...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbKomunikat);
            this.Controls.Add(this.tbLocalFileName);
            this.Controls.Add(this.tbURI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDownload);
            this.Name = "Form1";
            this.Text = "httpDownload";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDownload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbURI;
        private System.Windows.Forms.TextBox tbLocalFileName;
        private System.Windows.Forms.Label lbKomunikat;
    }
}

