using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialPortComm
{
    public partial class FormSerialComm : Form
    {
        public FormSerialComm()
        {
            InitializeComponent();
            getAvailablePorts();
        }

        // Get available ports and display in dropdown menu
        void getAvailablePorts()
        {
            string[] ports = SerialPort.GetPortNames();
            
        }

        // Open port connection
        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBoxDisplayPorts.Text == "" || comboBoxDisplayBaudRate.Text == "")
                {
                    txtBoxReceivedMsg.Text = "Please select port and baud rate settings.";
                }
                else
                {
                    serialPort1.PortName = comboBoxDisplayPorts.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBoxDisplayBaudRate);
                    serialPort1.Open();
                    progressBar1.Value = 100;
                    // Set enabled property to minimize user error
                    btnSendMsg.Enabled = true;
                    btnReadMsg.Enabled = true;
                    txtBoxSendMsg.Enabled = true;
                    btnOpenPort.Enabled = false;
                    btnClosePort.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                if(ex.Message == "UnauthorizedAccessException")
                {
                    txtBoxReceivedMsg.Text = "Unauthorized Access";
                }
                else
                {
                    txtBoxReceivedMsg.Text = ex.Message;
                }
            }
        }

        // Close port connection
        private void btnClosePort_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            progressBar1.Value = 0;
            // Set enabled property to minimize user error
            btnSendMsg.Enabled = false;
            btnReadMsg.Enabled = false;
            txtBoxSendMsg.Enabled = false;
            btnOpenPort.Enabled = true;
            btnClosePort.Enabled = false;
        }

        // Send message over serial port
        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(txtBoxSendMsg.Text);
            txtBoxSendMsg.Text = "";
        }

        // Read message from serial port
        private void btnReadMsg_Click(object sender, EventArgs e)
        {
            try
            {
                txtBoxReceivedMsg.Text = serialPort1.ReadLine();
            }
            catch(Exception ex)
            {
                if (ex.Message == "TimeoutException")
                {
                    txtBoxReceivedMsg.Text = "Timeout Exception";
                }
                else
                {
                    txtBoxReceivedMsg.Text = ex.Message;
                }
            }
        }
    }
}
