namespace UDPServer2019
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
            this.TextMessage = new System.Windows.Forms.TextBox();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.TextServerAddress = new System.Windows.Forms.TextBox();
            this.TextServerPort = new System.Windows.Forms.TextBox();
            this.LabelServerAddress = new System.Windows.Forms.Label();
            this.LabelServerPort = new System.Windows.Forms.Label();
            this.RadioButtonGotClientAddress = new System.Windows.Forms.RadioButton();
            this.TextSend = new System.Windows.Forms.TextBox();
            this.ButtonReceive = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextMessage
            // 
            this.TextMessage.Location = new System.Drawing.Point(56, 153);
            this.TextMessage.Multiline = true;
            this.TextMessage.Name = "TextMessage";
            this.TextMessage.Size = new System.Drawing.Size(497, 146);
            this.TextMessage.TabIndex = 0;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(494, 400);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(75, 23);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonSend
            // 
            this.ButtonSend.Location = new System.Drawing.Point(311, 400);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(75, 23);
            this.ButtonSend.TabIndex = 2;
            this.ButtonSend.Text = "Send";
            this.ButtonSend.UseVisualStyleBackColor = true;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // TextServerAddress
            // 
            this.TextServerAddress.Location = new System.Drawing.Point(110, 65);
            this.TextServerAddress.Name = "TextServerAddress";
            this.TextServerAddress.Size = new System.Drawing.Size(145, 20);
            this.TextServerAddress.TabIndex = 3;
            // 
            // TextServerPort
            // 
            this.TextServerPort.Location = new System.Drawing.Point(341, 64);
            this.TextServerPort.Name = "TextServerPort";
            this.TextServerPort.Size = new System.Drawing.Size(145, 20);
            this.TextServerPort.TabIndex = 4;
            // 
            // LabelServerAddress
            // 
            this.LabelServerAddress.AutoSize = true;
            this.LabelServerAddress.Location = new System.Drawing.Point(12, 67);
            this.LabelServerAddress.Name = "LabelServerAddress";
            this.LabelServerAddress.Size = new System.Drawing.Size(76, 13);
            this.LabelServerAddress.TabIndex = 5;
            this.LabelServerAddress.Text = "ServerAddress";
            // 
            // LabelServerPort
            // 
            this.LabelServerPort.AutoSize = true;
            this.LabelServerPort.Location = new System.Drawing.Point(267, 67);
            this.LabelServerPort.Name = "LabelServerPort";
            this.LabelServerPort.Size = new System.Drawing.Size(57, 13);
            this.LabelServerPort.TabIndex = 6;
            this.LabelServerPort.Text = "ServerPort";
            // 
            // RadioButtonGotClientAddress
            // 
            this.RadioButtonGotClientAddress.AutoCheck = false;
            this.RadioButtonGotClientAddress.AutoSize = true;
            this.RadioButtonGotClientAddress.BackColor = System.Drawing.Color.Red;
            this.RadioButtonGotClientAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RadioButtonGotClientAddress.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.RadioButtonGotClientAddress.ForeColor = System.Drawing.Color.Black;
            this.RadioButtonGotClientAddress.Location = new System.Drawing.Point(228, 108);
            this.RadioButtonGotClientAddress.Name = "RadioButtonGotClientAddress";
            this.RadioButtonGotClientAddress.Size = new System.Drawing.Size(106, 17);
            this.RadioButtonGotClientAddress.TabIndex = 7;
            this.RadioButtonGotClientAddress.TabStop = true;
            this.RadioButtonGotClientAddress.Text = "GotClientAddress";
            this.RadioButtonGotClientAddress.UseVisualStyleBackColor = false;
            // 
            // TextSend
            // 
            this.TextSend.Location = new System.Drawing.Point(56, 319);
            this.TextSend.Multiline = true;
            this.TextSend.Name = "TextSend";
            this.TextSend.Size = new System.Drawing.Size(497, 65);
            this.TextSend.TabIndex = 8;
            // 
            // ButtonReceive
            // 
            this.ButtonReceive.Location = new System.Drawing.Point(185, 399);
            this.ButtonReceive.Name = "ButtonReceive";
            this.ButtonReceive.Size = new System.Drawing.Size(75, 23);
            this.ButtonReceive.TabIndex = 9;
            this.ButtonReceive.Text = "Receive";
            this.ButtonReceive.UseVisualStyleBackColor = true;
            this.ButtonReceive.Click += new System.EventHandler(this.ButtonReceive_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(56, 399);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 10;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 450);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonReceive);
            this.Controls.Add(this.TextSend);
            this.Controls.Add(this.RadioButtonGotClientAddress);
            this.Controls.Add(this.LabelServerPort);
            this.Controls.Add(this.LabelServerAddress);
            this.Controls.Add(this.TextServerPort);
            this.Controls.Add(this.TextServerAddress);
            this.Controls.Add(this.ButtonSend);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.TextMessage);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextMessage;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonSend;
        private System.Windows.Forms.TextBox TextServerAddress;
        private System.Windows.Forms.TextBox TextServerPort;
        private System.Windows.Forms.Label LabelServerAddress;
        private System.Windows.Forms.Label LabelServerPort;
        private System.Windows.Forms.RadioButton RadioButtonGotClientAddress;
        private System.Windows.Forms.TextBox TextSend;
        private System.Windows.Forms.Button ButtonReceive;
        private System.Windows.Forms.Button ButtonClose;
    }
}

