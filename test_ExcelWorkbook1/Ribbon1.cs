using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Excel = Microsoft.Office.Interop.Excel;

namespace test_ExcelWorkbook1
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnConnectSerial_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Worksheet wks = (Excel.Worksheet)Globals.ThisWorkbook.ActiveSheet;
            wks.Range["D1"].Value = "Hello world";
        }
    }
}
