namespace EncyptAndUploadFiles
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
            this.btnStartService = new System.Windows.Forms.Button();
            this.btnStopService = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxPort = new System.Windows.Forms.TextBox();
            this.txtBoxIP = new System.Windows.Forms.TextBox();
            this.txtboxDirectoryPath = new System.Windows.Forms.TextBox();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnStartEncrypting = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Format = new System.Windows.Forms.RadioButton();
            this.Format2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartService
            // 
            this.btnStartService.Location = new System.Drawing.Point(196, 147);
            this.btnStartService.Name = "btnStartService";
            this.btnStartService.Size = new System.Drawing.Size(136, 23);
            this.btnStartService.TabIndex = 0;
            this.btnStartService.Text = "Start Service";
            this.btnStartService.UseVisualStyleBackColor = true;
            this.btnStartService.Click += new System.EventHandler(this.btnStartService_Click);
            // 
            // btnStopService
            // 
            this.btnStopService.Location = new System.Drawing.Point(341, 147);
            this.btnStopService.Name = "btnStopService";
            this.btnStopService.Size = new System.Drawing.Size(149, 23);
            this.btnStopService.TabIndex = 1;
            this.btnStopService.Text = "Stop Service";
            this.btnStopService.UseVisualStyleBackColor = true;
            this.btnStopService.Click += new System.EventHandler(this.btnStopService_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Server IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Server Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Directory";
            // 
            // txtBoxPort
            // 
            this.txtBoxPort.Location = new System.Drawing.Point(399, 24);
            this.txtBoxPort.Name = "txtBoxPort";
            this.txtBoxPort.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPort.TabIndex = 7;
            // 
            // txtBoxIP
            // 
            this.txtBoxIP.Location = new System.Drawing.Point(129, 23);
            this.txtBoxIP.Name = "txtBoxIP";
            this.txtBoxIP.Size = new System.Drawing.Size(140, 20);
            this.txtBoxIP.TabIndex = 8;
            // 
            // txtboxDirectoryPath
            // 
            this.txtboxDirectoryPath.Location = new System.Drawing.Point(129, 59);
            this.txtboxDirectoryPath.Name = "txtboxDirectoryPath";
            this.txtboxDirectoryPath.Size = new System.Drawing.Size(140, 20);
            this.txtboxDirectoryPath.TabIndex = 6;
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(275, 58);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(89, 23);
            this.btnbrowse.TabIndex = 9;
            this.btnbrowse.Text = "browse";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // btnStartEncrypting
            // 
            this.btnStartEncrypting.Location = new System.Drawing.Point(63, 147);
            this.btnStartEncrypting.Name = "btnStartEncrypting";
            this.btnStartEncrypting.Size = new System.Drawing.Size(124, 23);
            this.btnStartEncrypting.TabIndex = 10;
            this.btnStartEncrypting.Text = "Start Encrypting";
            this.btnStartEncrypting.UseVisualStyleBackColor = true;
            this.btnStartEncrypting.Click += new System.EventHandler(this.btnStartEncrypting_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(470, 197);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(40, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 198);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            // 
            // Format
            // 
            this.Format.AutoSize = true;
            this.Format.Location = new System.Drawing.Point(399, 62);
            this.Format.Name = "Format";
            this.Format.Size = new System.Drawing.Size(14, 13);
            this.Format.TabIndex = 12;
            this.Format.TabStop = true;
            this.Format.UseVisualStyleBackColor = true;
            // 
            // Format2
            // 
            this.Format2.AutoSize = true;
            this.Format2.Location = new System.Drawing.Point(453, 62);
            this.Format2.Name = "Format2";
            this.Format2.Size = new System.Drawing.Size(14, 13);
            this.Format2.TabIndex = 13;
            this.Format2.TabStop = true;
            this.Format2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 397);
            this.Controls.Add(this.Format2);
            this.Controls.Add(this.Format);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStartEncrypting);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.txtBoxIP);
            this.Controls.Add(this.txtBoxPort);
            this.Controls.Add(this.txtboxDirectoryPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStopService);
            this.Controls.Add(this.btnStartService);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartService;
        private System.Windows.Forms.Button btnStopService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxPort;
        private System.Windows.Forms.TextBox txtBoxIP;
        private System.Windows.Forms.TextBox txtboxDirectoryPath;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnStartEncrypting;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Format;
        private System.Windows.Forms.RadioButton Format2;
    }
}

