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
        //Test variable
        bool DEBUG = true;

        public FormSerialComm()
        {
            InitializeComponent();
            getAvailablePorts();
        }

        // Get available ports and display in dropdown menu
        void getAvailablePorts()
        {
            string[] ports = SerialPort.GetPortNames();

            // TODO   Figure out how to get ports array into comboBoxDisplayPorts  -- for now I hard coded a couple ports for testing
            comboBoxDisplayPorts.Items.AddRange(ports);

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
                    serialPort1.BaudRate = Convert.ToInt32(comboBoxDisplayBaudRate.Text);
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
            catch(UnauthorizedAccessException)
            {
                txtBoxReceivedMsg.Text = "Unauthorized Access";
                if(DEBUG)
                {
                    txtBoxReceivedMsg.Text = "This is the Unauthorized Access exception block for the Open Port button.";
                }
            }
            catch (Exception ex)
            {
                txtBoxReceivedMsg.Text = ex.Message;
                if (DEBUG)
                {
                    txtBoxReceivedMsg.Text = "This is the general exception block for the Open Port button.";
                }
            }
        }

        // Close port connection
        private void btnClosePort_Click(object sender, EventArgs e)
        {
            try
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
            catch(Exception ex)
            {
                txtBoxReceivedMsg.Text = ex.Message;
                if (DEBUG)
                {
                    txtBoxReceivedMsg.Text = "This is the general exception block for the Close Port button.";
                }
            }
           
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
            catch(TimeoutException)
            {
                txtBoxReceivedMsg.Text = "Timeout Exception";
                if (DEBUG)
                {
                    txtBoxReceivedMsg.Text = "This is the Timeout exception block for the Read button.";
                }
            }
            catch (Exception ex)
            {
                txtBoxReceivedMsg.Text = ex.Message;
                if (DEBUG)
                {
                    txtBoxReceivedMsg.Text = "This is the general exception block for the Read button.";
                }
            }
        }
    }
}
