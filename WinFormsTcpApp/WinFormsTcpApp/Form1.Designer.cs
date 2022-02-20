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
            this.numericServerPort = new System.Windows.Forms.NumericUpDown();
            this.buttonListen = new System.Windows.Forms.Button();
            this.buttonCheckIp = new System.Windows.Forms.Button();
            this.labelMyIp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericServerPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 49);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(956, 82);
            this.textBox1.TabIndex = 10;
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
            this.numericServerPort.ValueChanged += new System.EventHandler(this.numericServerPort_ValueChanged);
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
            this.buttonCheckIp.Location = new System.Drawing.Point(544, 9);
            this.buttonCheckIp.Name = "buttonCheckIp";
            this.buttonCheckIp.Size = new System.Drawing.Size(120, 31);
            this.buttonCheckIp.TabIndex = 3;
            this.buttonCheckIp.Text = "Check My IP";
            this.buttonCheckIp.UseVisualStyleBackColor = true;
            this.buttonCheckIp.Click += new System.EventHandler(this.buttonCheckIp_Click);
            // 
            // labelMyIp
            // 
            this.labelMyIp.Location = new System.Drawing.Point(670, 9);
            this.labelMyIp.Name = "labelMyIp";
            this.labelMyIp.Size = new System.Drawing.Size(150, 31);
            this.labelMyIp.TabIndex = 4;
            this.labelMyIp.Text = "0.0.0.0";
            this.labelMyIp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(956, 595);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelMyIp);
            this.Controls.Add(this.buttonCheckIp);
            this.Controls.Add(this.buttonListen);
            this.Controls.Add(this.numericServerPort);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericServerPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private NumericUpDown numericServerPort;
        private Button buttonListen;
        private Button buttonCheckIp;
        private Label labelMyIp;
        private PictureBox pictureBox1;
    }
}