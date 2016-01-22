namespace test_ExcelWorkbook1
{
    partial class frmCOM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cboCOMlist = new System.Windows.Forms.ComboBox();
            this.COMserialPort = new System.IO.Ports.SerialPort(this.components);
            this.lblSerialPort = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.cboSpeed = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboCOMlist
            // 
            this.cboCOMlist.FormattingEnabled = true;
            this.cboCOMlist.Location = new System.Drawing.Point(98, 29);
            this.cboCOMlist.Name = "cboCOMlist";
            this.cboCOMlist.Size = new System.Drawing.Size(121, 21);
            this.cboCOMlist.TabIndex = 0;
            // 
            // lblSerialPort
            // 
            this.lblSerialPort.AutoSize = true;
            this.lblSerialPort.Location = new System.Drawing.Point(27, 32);
            this.lblSerialPort.Name = "lblSerialPort";
            this.lblSerialPort.Size = new System.Drawing.Size(54, 13);
            this.lblSerialPort.TabIndex = 1;
            this.lblSerialPort.Text = "Serial port";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(27, 77);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(38, 13);
            this.lblSpeed.TabIndex = 2;
            this.lblSpeed.Text = "Speed";
            // 
            // cboSpeed
            // 
            this.cboSpeed.FormattingEnabled = true;
            this.cboSpeed.Location = new System.Drawing.Point(98, 74);
            this.cboSpeed.Name = "cboSpeed";
            this.cboSpeed.Size = new System.Drawing.Size(121, 21);
            this.cboSpeed.TabIndex = 3;
            // 
            // frmCOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cboSpeed);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblSerialPort);
            this.Controls.Add(this.cboCOMlist);
            this.Name = "frmCOM";
            this.Text = "COM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCOMlist;
        private System.IO.Ports.SerialPort COMserialPort;
        private System.Windows.Forms.Label lblSerialPort;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.ComboBox cboSpeed;
    }
}