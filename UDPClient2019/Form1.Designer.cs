namespace UDPClient2019
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
            this.TextAddress = new System.Windows.Forms.TextBox();
            this.TextPort = new System.Windows.Forms.TextBox();
            this.LabelAddress = new System.Windows.Forms.Label();
            this.LabelPort = new System.Windows.Forms.Label();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.TextMessage = new System.Windows.Forms.TextBox();
            this.TextStatus = new System.Windows.Forms.TextBox();
            this.RadioButtonGotServerAddress = new System.Windows.Forms.RadioButton();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonEnd = new System.Windows.Forms.Button();
            this.ButtonReceive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextAddress
            // 
            this.TextAddress.Location = new System.Drawing.Point(77, 40);
            this.TextAddress.Name = "TextAddress";
            this.TextAddress.Size = new System.Drawing.Size(197, 20);
            this.TextAddress.TabIndex = 0;
            // 
            // TextPort
            // 
            this.TextPort.Location = new System.Drawing.Point(356, 40);
            this.TextPort.Name = "TextPort";
            this.TextPort.Size = new System.Drawing.Size(197, 20);
            this.TextPort.TabIndex = 1;
            // 
            // LabelAddress
            // 
            this.LabelAddress.AutoSize = true;
            this.LabelAddress.Location = new System.Drawing.Point(16, 40);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(45, 13);
            this.LabelAddress.TabIndex = 2;
            this.LabelAddress.Text = "Address";
            // 
            // LabelPort
            // 
            this.LabelPort.AutoSize = true;
            this.LabelPort.Location = new System.Drawing.Point(296, 43);
            this.LabelPort.Name = "LabelPort";
            this.LabelPort.Size = new System.Drawing.Size(26, 13);
            this.LabelPort.TabIndex = 3;
            this.LabelPort.Text = "Port";
            // 
            // ButtonSend
            // 
            this.ButtonSend.Location = new System.Drawing.Point(231, 383);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(222, 31);
            this.ButtonSend.TabIndex = 4;
            this.ButtonSend.Text = "Send";
            this.ButtonSend.UseVisualStyleBackColor = true;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // TextMessage
            // 
            this.TextMessage.Location = new System.Drawing.Point(50, 201);
            this.TextMessage.Multiline = true;
            this.TextMessage.Name = "TextMessage";
            this.TextMessage.Size = new System.Drawing.Size(499, 166);
            this.TextMessage.TabIndex = 5;
            // 
            // TextStatus
            // 
            this.TextStatus.Location = new System.Drawing.Point(50, 105);
            this.TextStatus.Multiline = true;
            this.TextStatus.Name = "TextStatus";
            this.TextStatus.Size = new System.Drawing.Size(499, 77);
            this.TextStatus.TabIndex = 6;
            // 
            // RadioButtonGotServerAddress
            // 
            this.RadioButtonGotServerAddress.AutoCheck = false;
            this.RadioButtonGotServerAddress.AutoSize = true;
            this.RadioButtonGotServerAddress.BackColor = System.Drawing.Color.Blue;
            this.RadioButtonGotServerAddress.ForeColor = System.Drawing.Color.Red;
            this.RadioButtonGotServerAddress.Location = new System.Drawing.Point(211, 66);
            this.RadioButtonGotServerAddress.Name = "RadioButtonGotServerAddress";
            this.RadioButtonGotServerAddress.Size = new System.Drawing.Size(111, 17);
            this.RadioButtonGotServerAddress.TabIndex = 7;
            this.RadioButtonGotServerAddress.TabStop = true;
            this.RadioButtonGotServerAddress.Text = "GotServerAddress";
            this.RadioButtonGotServerAddress.UseVisualStyleBackColor = false;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(474, 391);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(75, 23);
            this.ButtonStart.TabIndex = 8;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonEnd
            // 
            this.ButtonEnd.Location = new System.Drawing.Point(12, 391);
            this.ButtonEnd.Name = "ButtonEnd";
            this.ButtonEnd.Size = new System.Drawing.Size(75, 23);
            this.ButtonEnd.TabIndex = 9;
            this.ButtonEnd.Text = "Close";
            this.ButtonEnd.UseVisualStyleBackColor = true;
            this.ButtonEnd.Click += new System.EventHandler(this.ButtonEnd_Click);
            // 
            // ButtonReceive
            // 
            this.ButtonReceive.Location = new System.Drawing.Point(121, 387);
            this.ButtonReceive.Name = "ButtonReceive";
            this.ButtonReceive.Size = new System.Drawing.Size(75, 23);
            this.ButtonReceive.TabIndex = 10;
            this.ButtonReceive.Text = "Receive";
            this.ButtonReceive.UseVisualStyleBackColor = true;
            this.ButtonReceive.Click += new System.EventHandler(this.ButtonReceive_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(574, 426);
            this.Controls.Add(this.ButtonReceive);
            this.Controls.Add(this.ButtonEnd);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.RadioButtonGotServerAddress);
            this.Controls.Add(this.TextStatus);
            this.Controls.Add(this.TextMessage);
            this.Controls.Add(this.ButtonSend);
            this.Controls.Add(this.LabelPort);
            this.Controls.Add(this.LabelAddress);
            this.Controls.Add(this.TextPort);
            this.Controls.Add(this.TextAddress);
            this.Name = "Form1";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox TextAddress;
        private System.Windows.Forms.TextBox TextPort;
        private System.Windows.Forms.Label LabelAddress;
        private System.Windows.Forms.Label LabelPort;
        private System.Windows.Forms.Button ButtonSend;
        private System.Windows.Forms.TextBox TextMessage;
        private System.Windows.Forms.TextBox TextStatus;
        private System.Windows.Forms.RadioButton RadioButtonGotServerAddress;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonEnd;
        private System.Windows.Forms.Button ButtonReceive;
    }
}

