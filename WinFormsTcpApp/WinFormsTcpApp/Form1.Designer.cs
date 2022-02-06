namespace WinFormsTcpApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.numericClientPort = new System.Windows.Forms.NumericUpDown();
            this.numericServerPort = new System.Windows.Forms.NumericUpDown();
            this.buttonListen = new System.Windows.Forms.Button();
            this.buttonCheckIp = new System.Windows.Forms.Button();
            this.labelMyIp = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericClientPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericServerPort)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 87);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(780, 351);
            this.textBox1.TabIndex = 10;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(670, 50);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(120, 31);
            this.buttonSend.TabIndex = 9;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxHost
            // 
            this.textBoxHost.Location = new System.Drawing.Point(10, 50);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.Size = new System.Drawing.Size(150, 31);
            this.textBoxHost.TabIndex = 6;
            this.textBoxHost.Text = "localhost";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(280, 50);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(380, 31);
            this.textBoxMessage.TabIndex = 8;
            // 
            // numericClientPort
            // 
            this.numericClientPort.Location = new System.Drawing.Point(170, 50);
            this.numericClientPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericClientPort.Name = "numericClientPort";
            this.numericClientPort.Size = new System.Drawing.Size(100, 31);
            this.numericClientPort.TabIndex = 7;
            this.numericClientPort.Value = new decimal(new int[] {
            55555,
            0,
            0,
            0});
            // 
            // numericServerPort
            // 
            this.numericServerPort.Location = new System.Drawing.Point(10, 10);
            this.numericServerPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericServerPort.Name = "numericServerPort";
            this.numericServerPort.Size = new System.Drawing.Size(100, 31);
            this.numericServerPort.TabIndex = 1;
            this.numericServerPort.Value = new decimal(new int[] {
            55555,
            0,
            0,
            0});
            // 
            // buttonListen
            // 
            this.buttonListen.Location = new System.Drawing.Point(120, 10);
            this.buttonListen.Name = "buttonListen";
            this.buttonListen.Size = new System.Drawing.Size(120, 31);
            this.buttonListen.TabIndex = 2;
            this.buttonListen.Text = "Listen";
            this.buttonListen.UseVisualStyleBackColor = true;
            this.buttonListen.Click += new System.EventHandler(this.buttonListen_Click);
            // 
            // buttonCheckIp
            // 
            this.buttonCheckIp.Location = new System.Drawing.Point(280, 10);
            this.buttonCheckIp.Name = "buttonCheckIp";
            this.buttonCheckIp.Size = new System.Drawing.Size(120, 31);
            this.buttonCheckIp.TabIndex = 3;
            this.buttonCheckIp.Text = "Check My IP";
            this.buttonCheckIp.UseVisualStyleBackColor = true;
            this.buttonCheckIp.Click += new System.EventHandler(this.buttonCheckIp_Click);
            // 
            // labelMyIp
            // 
            this.labelMyIp.Location = new System.Drawing.Point(406, 10);
            this.labelMyIp.Name = "labelMyIp";
            this.labelMyIp.Size = new System.Drawing.Size(150, 31);
            this.labelMyIp.TabIndex = 4;
            this.labelMyIp.Text = "0.0.0.0";
            this.labelMyIp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(600, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 33);
            this.comboBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelMyIp);
            this.Controls.Add(this.buttonCheckIp);
            this.Controls.Add(this.buttonListen);
            this.Controls.Add(this.numericServerPort);
            this.Controls.Add(this.numericClientPort);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.textBoxHost);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericClientPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericServerPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button buttonSend;
        private TextBox textBoxHost;
        private TextBox textBoxMessage;
        private NumericUpDown numericClientPort;
        private NumericUpDown numericServerPort;
        private Button buttonListen;
        private Button buttonCheckIp;
        private Label labelMyIp;
        private ComboBox comboBox1;
    }
}