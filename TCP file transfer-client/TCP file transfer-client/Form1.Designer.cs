namespace TCPIPDemo
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.textHost = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.Label();
            this.textPort = new System.Windows.Forms.TextBox();
            this.btnstop = new System.Windows.Forms.Button();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host:";
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(348, 126);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(75, 23);
            this.btnstart.TabIndex = 1;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.Btnstart_Click);
            // 
            // textHost
            // 
            this.textHost.Location = new System.Drawing.Point(177, 126);
            this.textHost.Name = "textHost";
            this.textHost.Size = new System.Drawing.Size(73, 20);
            this.textHost.TabIndex = 2;
            this.textHost.Text = "127.0.0.1";
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Location = new System.Drawing.Point(256, 129);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(29, 13);
            this.Port.TabIndex = 3;
            this.Port.Text = "Port:";
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(291, 126);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(39, 20);
            this.textPort.TabIndex = 4;
            this.textPort.Text = "8910";
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(429, 126);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(75, 23);
            this.btnstop.TabIndex = 5;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.Btnstop_Click);
            // 
            // textStatus
            // 
            this.textStatus.Location = new System.Drawing.Point(142, 177);
            this.textStatus.Multiline = true;
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(362, 189);
            this.textStatus.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textStatus);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.textHost);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.TextBox textHost;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.TextBox textStatus;
    }
}

