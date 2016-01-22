using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO.Ports;
using System.Windows.Forms;

namespace test_ExcelWorkbook1
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            
        }
        //SerialPort comport;
        private void btnConnectSerial_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Worksheet wks = (Excel.Worksheet)Globals.ThisWorkbook.ActiveSheet;

            
            serialPort1 = new SerialPort("COM17", 115200);
         //   Byte[] buffer = new Byte[1];
          //  buffer[0] = 1;
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
            }
        //    comport.Write(buffer, 0, buffer.Length);
            wks.Range["D1"].Value = serialPort1.IsOpen.ToString();
            serialPort1.Close();
        }

        private void btnCOM2_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, RibbonControlEventArgs e)
        {

        }

        private void btnConnectCOM_Click(object sender, RibbonControlEventArgs e)
        {
            Form comForm = new frmCOM();
            comForm.Show();
        }
    }
}
