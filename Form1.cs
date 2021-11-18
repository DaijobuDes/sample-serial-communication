using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serial
{
    public partial class Form1 : Form
    {
        public String _message;
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenPort(object sender, EventArgs e)
        {
            serialPort1.Open();
        }

        private void ClosePort(object sender, EventArgs e)
        {
            serialPort1.Close();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            _message += serialPort1.ReadExisting();
        }

        private void SendMessage(object sender, EventArgs e)
        {
            serialPort1.Write("" + textBox2.Text);
        }

        private void ReadMessage(object sender, EventArgs e)
        {
            textBox1.Text = _message;
        }

        private void LedOneOn(object sender, EventArgs e)
        {
            serialPort1.Write("a");
        }

        private void LedOneOff(object sender, EventArgs e)
        {
            serialPort1.Write("d");
        }

        private void LedTwoOn(object sender, EventArgs e)
        {
            serialPort1.Write("b");
        }

        private void LedTwoOff(object sender, EventArgs e)
        {
            serialPort1.Write("e");
        }

        private void LedThreeOn(object sender, EventArgs e)
        {
            serialPort1.Write("c");
        }

        private void LedThreeOff(object sender, EventArgs e)
        {
            serialPort1.Write("f");
        }
    }
}
