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
            this.cboCOMList1.Items.AddRange(SerialPort.GetPortNames());
            this.cboSpeed1.Items.AddRange(new string[] { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200", "460800", "921600"});
            this.cboCOMList2.Items.AddRange(SerialPort.GetPortNames());
            this.cboSpeed2.Items.AddRange(new string[] { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200", "460800", "921600" });
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            String strDatetime = datetime.ToShortTimeString();

            string strCOMport = this.cboCOMList1.SelectedItem.ToString();
            string strSpeed = this.cboSpeed1.SelectedItem.ToString();
            COMSerialPort1 = new SerialPort(strCOMport, Int32.Parse(strSpeed));
            if (!COMSerialPort1.IsOpen)
            {
                COMSerialPort1.Open();
                txtReceive1.AppendText("[" + datetime + "] : " + "Connected\n");
                COMSerialPort1.DataReceived += new SerialDataReceivedEventHandler(COMserialPort1_DataReceived);
            }       
        }      
        private void btnClose_Click(object sender, EventArgs e)
        {
            COMSerialPort1.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            
            //Byte[] message = Encoding.Unicode.GetBytes(txtSendCommand1.Text + "\r\n");
            COMSerialPort1.Write(txtSendCommand1.Text + "\r\n");
            txtSendCommand1.Clear();
        }

        public void Displaytxt1(string str1)
        {
            this.txtReceive1.AppendText(str1);
        }

        public delegate void UpdataDisplaytxt1(string str);
        private void COMserialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = COMSerialPort1.ReadExisting().ToString();
            this.Invoke(new UpdataDisplaytxt2(Displaytxt1), new object[] { data });
        }
        ///***********************************************************************************************************************///
        private void btnSerialConnect2_Click(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            String strDatetime = datetime.ToShortTimeString();

            string strCOMport = this.cboCOMList2.SelectedItem.ToString();
            string strSpeed = this.cboSpeed2.SelectedItem.ToString();
            COMSerialPort2 = new SerialPort(strCOMport, Int32.Parse(strSpeed));
            if (!COMSerialPort2.IsOpen)
            {
                txtReceive2.AppendText("[" + datetime + "] : " + "Connected\n");
                COMSerialPort2.DataReceived += new SerialDataReceivedEventHandler(COMserialPort2_DataReceived);
                COMSerialPort2.Open();
            }
        }

        public void Displaytxt2(string str1)
        {
            this.txtReceive2.AppendText(str1);
        }

        public delegate void UpdataDisplaytxt2(string str);
        private void COMserialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = COMSerialPort2.ReadExisting().ToString();
            this.Invoke(new UpdataDisplaytxt2(Displaytxt2), new object[] { data });   
        }

        private void btnSerialClose_Click(object sender, EventArgs e)
        {
            COMSerialPort2.Close();
        }

        private void btnSend2_Click(object sender, EventArgs e)
        {
            //Byte[] message = Encoding.Unicode.GetBytes(txtSendCommand2.Text + "\r\n");
            COMSerialPort2.Write(txtSendCommand2.Text + "\r\n");
            txtSendCommand2.Clear();
        }
    }
}
