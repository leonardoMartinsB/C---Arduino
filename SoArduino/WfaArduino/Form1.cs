using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace WfaArduino
{
    public partial class Form1 : Form
    {
        SerialPort serialPort;
        public Form1()
        {
            InitializeComponent();
            // Configuração da porta serial
            serialPort = new SerialPort("COM3", 9600);
            serialPort.DataReceived += new SerialDataReceivedEventHandler(DadosRecebidos);
            serialPort.Open();
        }

        private void btnLigarLed_Click(object sender, EventArgs e)
        {
            serialPort.Write("1");
        }

        private void btnDesligarLed_Click(object sender, EventArgs e)
        {
            serialPort.Write("0");
        }

        private void DadosRecebidos(object sender, SerialDataReceivedEventArgs e)
        {
            // Lê a linha enviada pelo Arduino
            string message = serialPort.ReadLine();
            // Atualiza a interface na thread correta
            this.Invoke(new Action(() =>
            {
                txtStatus.AppendText(message + Environment.NewLine); // Exibe a mensagem no TextBox
            }));
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort.IsOpen)
                serialPort.Close();
        }
    }
}
