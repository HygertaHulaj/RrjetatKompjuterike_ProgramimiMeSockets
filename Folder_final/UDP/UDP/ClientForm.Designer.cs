namespace UDP
{
    partial class ClientForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.txtClientPort = new System.Windows.Forms.TextBox();
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCreateClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Client";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server Port :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client Port :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Host Name :";
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(109, 49);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(163, 20);
            this.txtServerPort.TabIndex = 4;
            this.txtServerPort.Text = "5678";
            // 
            // txtClientPort
            // 
            this.txtClientPort.Location = new System.Drawing.Point(109, 89);
            this.txtClientPort.Name = "txtClientPort";
            this.txtClientPort.Size = new System.Drawing.Size(163, 20);
            this.txtClientPort.TabIndex = 5;
            this.txtClientPort.Text = "1234";
            // 
            // txtHostName
            // 
            this.txtHostName.Location = new System.Drawing.Point(109, 139);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(163, 20);
            this.txtHostName.TabIndex = 6;
            this.txtHostName.Text = "localhost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Log :";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(5, 196);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(267, 112);
            this.txtLog.TabIndex = 8;
            this.txtLog.Text = "";
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(7, 341);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(265, 20);
            this.txtMsg.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Send Message to Server :";
            // 
            // btnSend
            // 
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Enabled = false;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(5, 368);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 30);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCreateClient
            // 
            this.btnCreateClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateClient.Location = new System.Drawing.Point(140, 368);
            this.btnCreateClient.Name = "btnCreateClient";
            this.btnCreateClient.Size = new System.Drawing.Size(132, 30);
            this.btnCreateClient.TabIndex = 12;
            this.btnCreateClient.Text = "Create Client";
            this.btnCreateClient.UseVisualStyleBackColor = true;
            this.btnCreateClient.Click += new System.EventHandler(this.btnCreateClient_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 402);
            this.Controls.Add(this.btnCreateClient);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHostName);
            this.Controls.Add(this.txtClientPort);
            this.Controls.Add(this.txtServerPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.TextBox txtClientPort;
        private System.Windows.Forms.TextBox txtHostName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCreateClient;
    }
}

