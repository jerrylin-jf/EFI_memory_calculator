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
using Excel = Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;

namespace test_ExcelWorkbook1
{
    public partial class frmCOM : Form
    {
        public frmCOM()
        {
            InitializeComponent();        
            this.cboCOMlist.Items.AddRange(SerialPort.GetPortNames());
            this.cboSpeed.Items.AddRange(new string[] { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200", "460800", "921600"});
        }

        List<SerialPort> listSerial = new List<SerialPort>();
        private void btnConnect_Click(object sender, EventArgs e)
        {
            string strCOMport = this.cboCOMlist.SelectedItem.ToString();
            string strSpeed = this.cboSpeed.SelectedItem.ToString();
            COMserialPort = new SerialPort(strCOMport, Int32.Parse(strSpeed));
            if (!COMserialPort.IsOpen)
            {
                COMserialPort.Open();
            }
            
            listSerial.Add(COMserialPort);
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            foreach (SerialPort temp in listSerial)
            {
                lblSerialPort.Text = COMserialPort.IsOpen.ToString();
                temp.Close();
            }
            listSerial.Clear();

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Byte[] message = Encoding.Unicode.GetBytes(txtSendCommand.Text + "\n");
            COMserialPort.Write(message, 0, message.Length);
            txtSendCommand.Clear();
        }
    }
}
