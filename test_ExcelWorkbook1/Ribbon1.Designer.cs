namespace test_ExcelWorkbook1
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.grpCOM = this.Factory.CreateRibbonGroup();
            this.btnCOM1 = this.Factory.CreateRibbonButton();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnConnectCOM = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.grpCOM.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.grpCOM);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // grpCOM
            // 
            this.grpCOM.Items.Add(this.btnCOM1);
            this.grpCOM.Items.Add(this.btnConnectCOM);
            this.grpCOM.Label = "COM";
            this.grpCOM.Name = "grpCOM";
            // 
            // btnCOM1
            // 
            this.btnCOM1.Label = "COM1";
            this.btnCOM1.Name = "btnCOM1";
            this.btnCOM1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnConnectSerial_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM17";
            // 
            // btnConnectCOM
            // 
            this.btnConnectCOM.Label = "Serial";
            this.btnConnectCOM.Name = "btnConnectCOM";
            this.btnConnectCOM.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnConnectCOM_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.grpCOM.ResumeLayout(false);
            this.grpCOM.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpCOM;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnCOM1;
        private System.IO.Ports.SerialPort serialPort1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnConnectCOM;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }

}
