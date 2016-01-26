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
            this.cboCOMList1 = new System.Windows.Forms.ComboBox();
            this.COMSerialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lblSerialPort1 = new System.Windows.Forms.Label();
            this.lblSpeed1 = new System.Windows.Forms.Label();
            this.cboSpeed1 = new System.Windows.Forms.ComboBox();
            this.btnSerialConnect1 = new System.Windows.Forms.Button();
            this.btnSerialClose1 = new System.Windows.Forms.Button();
            this.txtSendCommand1 = new System.Windows.Forms.TextBox();
            this.btnSend1 = new System.Windows.Forms.Button();
            this.txtReceive1 = new System.Windows.Forms.TextBox();
            this.txtReceive2 = new System.Windows.Forms.TextBox();
            this.btnSend2 = new System.Windows.Forms.Button();
            this.txtSendCommand2 = new System.Windows.Forms.TextBox();
            this.btnSerialClose = new System.Windows.Forms.Button();
            this.btnSerialConnect2 = new System.Windows.Forms.Button();
            this.cboSpeed2 = new System.Windows.Forms.ComboBox();
            this.lblSpeed12 = new System.Windows.Forms.Label();
            this.lblSerialPort2 = new System.Windows.Forms.Label();
            this.cboCOMList2 = new System.Windows.Forms.ComboBox();
            this.COMSerialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // cboCOMList1
            // 
            this.cboCOMList1.FormattingEnabled = true;
            this.cboCOMList1.Location = new System.Drawing.Point(128, 21);
            this.cboCOMList1.Name = "cboCOMList1";
            this.cboCOMList1.Size = new System.Drawing.Size(121, 21);
            this.cboCOMList1.TabIndex = 0;
            // 
            // lblSerialPort1
            // 
            this.lblSerialPort1.AutoSize = true;
            this.lblSerialPort1.Location = new System.Drawing.Point(58, 24);
            this.lblSerialPort1.Name = "lblSerialPort1";
            this.lblSerialPort1.Size = new System.Drawing.Size(55, 13);
            this.lblSerialPort1.TabIndex = 1;
            this.lblSerialPort1.Text = "Serial Port";
            // 
            // lblSpeed1
            // 
            this.lblSpeed1.AutoSize = true;
            this.lblSpeed1.Location = new System.Drawing.Point(58, 56);
            this.lblSpeed1.Name = "lblSpeed1";
            this.lblSpeed1.Size = new System.Drawing.Size(38, 13);
            this.lblSpeed1.TabIndex = 2;
            this.lblSpeed1.Text = "Speed";
            // 
            // cboSpeed1
            // 
            this.cboSpeed1.FormattingEnabled = true;
            this.cboSpeed1.Location = new System.Drawing.Point(128, 53);
            this.cboSpeed1.Name = "cboSpeed1";
            this.cboSpeed1.Size = new System.Drawing.Size(121, 21);
            this.cboSpeed1.TabIndex = 3;
            // 
            // btnSerialConnect1
            // 
            this.btnSerialConnect1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerialConnect1.Location = new System.Drawing.Point(375, 19);
            this.btnSerialConnect1.Name = "btnSerialConnect1";
            this.btnSerialConnect1.Size = new System.Drawing.Size(75, 23);
            this.btnSerialConnect1.TabIndex = 4;
            this.btnSerialConnect1.Text = "Connect";
            this.btnSerialConnect1.UseVisualStyleBackColor = true;
            this.btnSerialConnect1.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSerialClose1
            // 
            this.btnSerialClose1.Location = new System.Drawing.Point(375, 51);
            this.btnSerialClose1.Name = "btnSerialClose1";
            this.btnSerialClose1.Size = new System.Drawing.Size(75, 23);
            this.btnSerialClose1.TabIndex = 5;
            this.btnSerialClose1.Text = "Close";
            this.btnSerialClose1.UseVisualStyleBackColor = true;
            this.btnSerialClose1.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtSendCommand1
            // 
            this.txtSendCommand1.Location = new System.Drawing.Point(30, 556);
            this.txtSendCommand1.Name = "txtSendCommand1";
            this.txtSendCommand1.Size = new System.Drawing.Size(389, 20);
            this.txtSendCommand1.TabIndex = 6;
            // 
            // btnSend1
            // 
            this.btnSend1.Location = new System.Drawing.Point(458, 555);
            this.btnSend1.Name = "btnSend1";
            this.btnSend1.Size = new System.Drawing.Size(67, 20);
            this.btnSend1.TabIndex = 7;
            this.btnSend1.Text = "Send";
            this.btnSend1.UseVisualStyleBackColor = true;
            this.btnSend1.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtReceive1
            // 
            this.txtReceive1.Location = new System.Drawing.Point(30, 84);
            this.txtReceive1.Multiline = true;
            this.txtReceive1.Name = "txtReceive1";
            this.txtReceive1.ReadOnly = true;
            this.txtReceive1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceive1.Size = new System.Drawing.Size(495, 448);
            this.txtReceive1.TabIndex = 8;
            // 
            // txtReceive2
            // 
            this.txtReceive2.Location = new System.Drawing.Point(583, 84);
            this.txtReceive2.Multiline = true;
            this.txtReceive2.Name = "txtReceive2";
            this.txtReceive2.ReadOnly = true;
            this.txtReceive2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceive2.Size = new System.Drawing.Size(495, 448);
            this.txtReceive2.TabIndex = 9;
            // 
            // btnSend2
            // 
            this.btnSend2.Location = new System.Drawing.Point(1011, 555);
            this.btnSend2.Name = "btnSend2";
            this.btnSend2.Size = new System.Drawing.Size(67, 20);
            this.btnSend2.TabIndex = 11;
            this.btnSend2.Text = "Send";
            this.btnSend2.UseVisualStyleBackColor = true;
            this.btnSend2.Click += new System.EventHandler(this.btnSend2_Click);
            // 
            // txtSendCommand2
            // 
            this.txtSendCommand2.Location = new System.Drawing.Point(583, 555);
            this.txtSendCommand2.Name = "txtSendCommand2";
            this.txtSendCommand2.Size = new System.Drawing.Size(389, 20);
            this.txtSendCommand2.TabIndex = 10;
            // 
            // btnSerialClose
            // 
            this.btnSerialClose.Location = new System.Drawing.Point(933, 51);
            this.btnSerialClose.Name = "btnSerialClose";
            this.btnSerialClose.Size = new System.Drawing.Size(75, 23);
            this.btnSerialClose.TabIndex = 17;
            this.btnSerialClose.Text = "Close";
            this.btnSerialClose.UseVisualStyleBackColor = true;
            this.btnSerialClose.Click += new System.EventHandler(this.btnSerialClose_Click);
            // 
            // btnSerialConnect2
            // 
            this.btnSerialConnect2.Location = new System.Drawing.Point(933, 19);
            this.btnSerialConnect2.Name = "btnSerialConnect2";
            this.btnSerialConnect2.Size = new System.Drawing.Size(75, 23);
            this.btnSerialConnect2.TabIndex = 16;
            this.btnSerialConnect2.Text = "Connect";
            this.btnSerialConnect2.UseVisualStyleBackColor = true;
            this.btnSerialConnect2.Click += new System.EventHandler(this.btnSerialConnect2_Click);
            // 
            // cboSpeed2
            // 
            this.cboSpeed2.FormattingEnabled = true;
            this.cboSpeed2.Location = new System.Drawing.Point(686, 53);
            this.cboSpeed2.Name = "cboSpeed2";
            this.cboSpeed2.Size = new System.Drawing.Size(121, 21);
            this.cboSpeed2.TabIndex = 15;
            // 
            // lblSpeed12
            // 
            this.lblSpeed12.AutoSize = true;
            this.lblSpeed12.Location = new System.Drawing.Point(616, 56);
            this.lblSpeed12.Name = "lblSpeed12";
            this.lblSpeed12.Size = new System.Drawing.Size(38, 13);
            this.lblSpeed12.TabIndex = 14;
            this.lblSpeed12.Text = "Speed";
            // 
            // lblSerialPort2
            // 
            this.lblSerialPort2.AutoSize = true;
            this.lblSerialPort2.Location = new System.Drawing.Point(616, 24);
            this.lblSerialPort2.Name = "lblSerialPort2";
            this.lblSerialPort2.Size = new System.Drawing.Size(55, 13);
            this.lblSerialPort2.TabIndex = 13;
            this.lblSerialPort2.Text = "Serial Port";
            // 
            // cboCOMList2
            // 
            this.cboCOMList2.FormattingEnabled = true;
            this.cboCOMList2.Location = new System.Drawing.Point(686, 21);
            this.cboCOMList2.Name = "cboCOMList2";
            this.cboCOMList2.Size = new System.Drawing.Size(121, 21);
            this.cboCOMList2.TabIndex = 12;
            // 
            // frmCOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 615);
            this.Controls.Add(this.btnSerialClose);
            this.Controls.Add(this.btnSerialConnect2);
            this.Controls.Add(this.cboSpeed2);
            this.Controls.Add(this.lblSpeed12);
            this.Controls.Add(this.lblSerialPort2);
            this.Controls.Add(this.cboCOMList2);
            this.Controls.Add(this.btnSend2);
            this.Controls.Add(this.txtSendCommand2);
            this.Controls.Add(this.txtReceive2);
            this.Controls.Add(this.txtReceive1);
            this.Controls.Add(this.btnSend1);
            this.Controls.Add(this.txtSendCommand1);
            this.Controls.Add(this.btnSerialClose1);
            this.Controls.Add(this.btnSerialConnect1);
            this.Controls.Add(this.cboSpeed1);
            this.Controls.Add(this.lblSpeed1);
            this.Controls.Add(this.lblSerialPort1);
            this.Controls.Add(this.cboCOMList1);
            this.Name = "frmCOM";
            this.Text = "COM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCOMList1;
        private System.IO.Ports.SerialPort COMSerialPort1;
        private System.Windows.Forms.Label lblSerialPort1;
        private System.Windows.Forms.Label lblSpeed1;
        private System.Windows.Forms.ComboBox cboSpeed1;
        private System.Windows.Forms.Button btnSerialConnect1;
        private System.Windows.Forms.Button btnSerialClose1;
        private System.Windows.Forms.TextBox txtSendCommand1;
        private System.Windows.Forms.Button btnSend1;
        private System.Windows.Forms.TextBox txtReceive1;
        private System.Windows.Forms.TextBox txtReceive2;
        private System.Windows.Forms.Button btnSend2;
        private System.Windows.Forms.TextBox txtSendCommand2;
        private System.Windows.Forms.Button btnSerialClose;
        private System.Windows.Forms.Button btnSerialConnect2;
        private System.Windows.Forms.ComboBox cboSpeed2;
        private System.Windows.Forms.Label lblSpeed12;
        private System.Windows.Forms.Label lblSerialPort2;
        private System.Windows.Forms.ComboBox cboCOMList2;
        private System.IO.Ports.SerialPort COMSerialPort2;
    }
}