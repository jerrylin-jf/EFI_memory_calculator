using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace test_ExcelWorkbook1
{
    public partial class Form1 : Form
    {
        public const int busWeight = 1048576;
        public const int deviceWeight = 32768;
        public const int functionWeight = 4096;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint registerDec = UInt32.Parse(Register_textBox1.Text+Register_textBox2.Text, System.Globalization.NumberStyles.HexNumber);
            uint busDec= UInt32.Parse(Bus_textBox.Text, System.Globalization.NumberStyles.HexNumber);
            uint deviceDec = UInt32.Parse(Devicd_textBox.Text, System.Globalization.NumberStyles.HexNumber);
            uint functionDec = UInt32.Parse(Function_textBox.Text, System.Globalization.NumberStyles.HexNumber);
            uint offsetDec = UInt32.Parse(Offset_textBox.Text, System.Globalization.NumberStyles.HexNumber);

            uint addressDec = (busDec * busWeight) + (deviceDec * deviceWeight) + (functionDec * functionWeight) + offsetDec + registerDec;
            string addressHex = Convert.ToString(addressDec, 16);

            label5.Text = addressHex;
     
            Excel.Worksheet wks = (Excel.Worksheet)Globals.ThisWorkbook.ActiveSheet;
            wks.Range["A1"].Value = registerDec;
            wks.Range["A2"].Value = busDec;
            wks.Range["A3"].Value = deviceDec;
            wks.Range["A4"].Value = functionDec;
            wks.Range["A5"].Value = offsetDec;
            wks.Range["A6"].Value = addressDec;
            wks.Range["A7"].Value = addressHex;
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            uint busDec = UInt32.Parse(Bus_textBox.Text, System.Globalization.NumberStyles.HexNumber);
            uint deviceDec = UInt32.Parse(Devicd_textBox.Text, System.Globalization.NumberStyles.HexNumber);
            uint functionDec = UInt32.Parse(Function_textBox.Text, System.Globalization.NumberStyles.HexNumber);
            uint offsetDec = UInt32.Parse(Offset_textBox.Text, System.Globalization.NumberStyles.HexNumber);
            uint addressDec = UInt32.Parse(address_textBox.Text, System.Globalization.NumberStyles.HexNumber);

            uint registerDec = addressDec - ((busDec * busWeight) + (deviceDec * deviceWeight) + (functionDec * functionWeight) + offsetDec);
            string registerHex = Convert.ToString(registerDec, 16);
            label5.Text = registerHex;

            Excel.Worksheet wks = (Excel.Worksheet)Globals.ThisWorkbook.ActiveSheet;
            wks.Range["A1"].Value = registerDec;
            wks.Range["A2"].Value = busDec;
            wks.Range["A3"].Value = deviceDec;
            wks.Range["A4"].Value = functionDec;
            wks.Range["A5"].Value = offsetDec;
            wks.Range["A6"].Value = addressDec;
            wks.Range["A7"].Value = registerHex;

        }
    }
}
