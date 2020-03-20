using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace H1
{
    public partial class Form1 : Form
    {
        public string data = "";
        public Form1()
        {
            InitializeComponent();
            close.Enabled = false;
            getAvailablePorts();
            

        }

     

        void getAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            portName.Items.AddRange(ports);
        }

      
    

        private void open_Click(object sender, EventArgs e)
        {
            try
            {
                if (portName.Text == "" || baudRate.Text == "")
                {
                    label4.Text = "Please select port settings";
                }
                else
                {
                    label4.Text = "";

                    serialPort1.PortName = portName.Text;
                    serialPort1.BaudRate = Convert.ToInt32(baudRate.Text);
                    serialPort1.Open();
                    progressBar1.Value = 100;
                    groupBox1.Enabled = true;
                    close.Enabled = true;
                    open.Enabled = false;
                    timer1.Enabled = true;

                }
            }
            catch (UnauthorizedAccessException)
            {
                label4.Text = "Unauthorized access";
            }
        }

       

        private void close_Click_1(object sender, EventArgs e)
        {
            serialPort1.Close();
            progressBar1.Value = 0;
            groupBox1.Enabled = false;
            close.Enabled = false;
            open.Enabled = true;
            
        }

        

         private void timer1_Tick_1(object sender, EventArgs e)
            {
                try
                {
                if(serialPort1.IsOpen)
                {
                    listBox1.Items.Add(serialPort1.ReadLine().ToString());
                    int visibleItems = listBox1.ClientSize.Height / listBox1.ItemHeight;
                    listBox1.TopIndex = Math.Max(listBox1.Items.Count - visibleItems + 1, 0);
                }
            }
                catch (TimeoutException)
                {
                    label4.Text = "Timeout exception";
                }



            }
        

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }
    }
}
