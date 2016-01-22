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

namespace test_ExcelWorkbook1
{
    public partial class frmCOM : Form
    {
        public frmCOM()
        {
            InitializeComponent();
            this.cboCOMlist.Items.AddRange(SerialPort.GetPortNames());
            Excel.Worksheet wks = (Excel.Worksheet)Globals.ThisWorkbook.ActiveSheet;
            COMserialPort = new SerialPort("COM17", 115200);
            COMserialPort.Open();
            wks.Range["D1"].Value = COMserialPort.IsOpen.ToString();
            COMserialPort.Close();
        }
    }
}
