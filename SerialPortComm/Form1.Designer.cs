namespace SerialPortComm
{
    partial class FormSerialComm
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxDisplayPorts = new System.Windows.Forms.ComboBox();
            this.comboBoxDisplayBaudRate = new System.Windows.Forms.ComboBox();
            this.grpBoxSend = new System.Windows.Forms.GroupBox();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.txtBoxSendMsg = new System.Windows.Forms.TextBox();
            this.grpBoxReceivedMsg = new System.Windows.Forms.GroupBox();
            this.btnReadMsg = new System.Windows.Forms.Button();
            this.txtBoxReceivedMsg = new System.Windows.Forms.TextBox();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.btnClosePort = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.grpBoxSend.SuspendLayout();
            this.grpBoxReceivedMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxDisplayPorts
            // 
            this.comboBoxDisplayPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDisplayPorts.FormattingEnabled = true;
            this.comboBoxDisplayPorts.Items.AddRange(new object[] {
            "com1_Test",
            "com2_Test"});
            this.comboBoxDisplayPorts.Location = new System.Drawing.Point(23, 115);
            this.comboBoxDisplayPorts.Name = "comboBoxDisplayPorts";
            this.comboBoxDisplayPorts.Size = new System.Drawing.Size(266, 28);
            this.comboBoxDisplayPorts.TabIndex = 0;
            // 
            // comboBoxDisplayBaudRate
            // 
            this.comboBoxDisplayBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDisplayBaudRate.FormattingEnabled = true;
            this.comboBoxDisplayBaudRate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBoxDisplayBaudRate.Location = new System.Drawing.Point(440, 115);
            this.comboBoxDisplayBaudRate.Name = "comboBoxDisplayBaudRate";
            this.comboBoxDisplayBaudRate.Size = new System.Drawing.Size(235, 28);
            this.comboBoxDisplayBaudRate.TabIndex = 1;
            // 
            // grpBoxSend
            // 
            this.grpBoxSend.Controls.Add(this.btnSendMsg);
            this.grpBoxSend.Controls.Add(this.txtBoxSendMsg);
            this.grpBoxSend.Location = new System.Drawing.Point(23, 190);
            this.grpBoxSend.Name = "grpBoxSend";
            this.grpBoxSend.Size = new System.Drawing.Size(332, 385);
            this.grpBoxSend.TabIndex = 2;
            this.grpBoxSend.TabStop = false;
            this.grpBoxSend.Text = "Send Message";
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Enabled = false;
            this.btnSendMsg.Location = new System.Drawing.Point(202, 314);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(109, 53);
            this.btnSendMsg.TabIndex = 1;
            this.btnSendMsg.Text = "Send";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // txtBoxSendMsg
            // 
            this.txtBoxSendMsg.Enabled = false;
            this.txtBoxSendMsg.Location = new System.Drawing.Point(18, 34);
            this.txtBoxSendMsg.Multiline = true;
            this.txtBoxSendMsg.Name = "txtBoxSendMsg";
            this.txtBoxSendMsg.Size = new System.Drawing.Size(293, 255);
            this.txtBoxSendMsg.TabIndex = 0;
            // 
            // grpBoxReceivedMsg
            // 
            this.grpBoxReceivedMsg.Controls.Add(this.btnReadMsg);
            this.grpBoxReceivedMsg.Controls.Add(this.txtBoxReceivedMsg);
            this.grpBoxReceivedMsg.Location = new System.Drawing.Point(440, 190);
            this.grpBoxReceivedMsg.Name = "grpBoxReceivedMsg";
            this.grpBoxReceivedMsg.Size = new System.Drawing.Size(332, 385);
            this.grpBoxReceivedMsg.TabIndex = 3;
            this.grpBoxReceivedMsg.TabStop = false;
            this.grpBoxReceivedMsg.Text = "Received Message";
            // 
            // btnReadMsg
            // 
            this.btnReadMsg.Enabled = false;
            this.btnReadMsg.Location = new System.Drawing.Point(202, 314);
            this.btnReadMsg.Name = "btnReadMsg";
            this.btnReadMsg.Size = new System.Drawing.Size(109, 53);
            this.btnReadMsg.TabIndex = 1;
            this.btnReadMsg.Text = "Read";
            this.btnReadMsg.UseVisualStyleBackColor = true;
            this.btnReadMsg.Click += new System.EventHandler(this.btnReadMsg_Click);
            // 
            // txtBoxReceivedMsg
            // 
            this.txtBoxReceivedMsg.Enabled = false;
            this.txtBoxReceivedMsg.Location = new System.Drawing.Point(18, 34);
            this.txtBoxReceivedMsg.Multiline = true;
            this.txtBoxReceivedMsg.Name = "txtBoxReceivedMsg";
            this.txtBoxReceivedMsg.ReadOnly = true;
            this.txtBoxReceivedMsg.Size = new System.Drawing.Size(293, 255);
            this.txtBoxReceivedMsg.TabIndex = 0;
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(809, 224);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(140, 80);
            this.btnOpenPort.TabIndex = 4;
            this.btnOpenPort.Text = "Open Port";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // btnClosePort
            // 
            this.btnClosePort.Enabled = false;
            this.btnClosePort.Location = new System.Drawing.Point(809, 399);
            this.btnClosePort.Name = "btnClosePort";
            this.btnClosePort.Size = new System.Drawing.Size(140, 80);
            this.btnClosePort.TabIndex = 5;
            this.btnClosePort.Text = "Close Port";
            this.btnClosePort.UseVisualStyleBackColor = true;
            this.btnClosePort.Click += new System.EventHandler(this.btnClosePort_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(809, 114);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(165, 29);
            this.progressBar1.TabIndex = 6;
            // 
            // FormSerialComm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 730);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnClosePort);
            this.Controls.Add(this.btnOpenPort);
            this.Controls.Add(this.grpBoxReceivedMsg);
            this.Controls.Add(this.grpBoxSend);
            this.Controls.Add(this.comboBoxDisplayBaudRate);
            this.Controls.Add(this.comboBoxDisplayPorts);
            this.Name = "FormSerialComm";
            this.Text = "Serial Communication";
            this.grpBoxSend.ResumeLayout(false);
            this.grpBoxSend.PerformLayout();
            this.grpBoxReceivedMsg.ResumeLayout(false);
            this.grpBoxReceivedMsg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDisplayPorts;
        private System.Windows.Forms.ComboBox comboBoxDisplayBaudRate;
        private System.Windows.Forms.GroupBox grpBoxSend;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.TextBox txtBoxSendMsg;
        private System.Windows.Forms.GroupBox grpBoxReceivedMsg;
        private System.Windows.Forms.Button btnReadMsg;
        private System.Windows.Forms.TextBox txtBoxReceivedMsg;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.Button btnClosePort;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

