namespace WinFormsTcpClientApp
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
            this.comboBoxHost = new System.Windows.Forms.ComboBox();
            this.numericClientPort = new System.Windows.Forms.NumericUpDown();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelScreen = new System.Windows.Forms.Label();
            this.pictureBoxScreenShot = new System.Windows.Forms.PictureBox();
            this.buttonScreenShot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericClientPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreenShot)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxHost
            // 
            this.comboBoxHost.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxHost.FormattingEnabled = true;
            this.comboBoxHost.Location = new System.Drawing.Point(10, 10);
            this.comboBoxHost.Name = "comboBoxHost";
            this.comboBoxHost.Size = new System.Drawing.Size(190, 33);
            this.comboBoxHost.TabIndex = 17;
            // 
            // numericClientPort
            // 
            this.numericClientPort.Location = new System.Drawing.Point(210, 10);
            this.numericClientPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericClientPort.Name = "numericClientPort";
            this.numericClientPort.Size = new System.Drawing.Size(100, 31);
            this.numericClientPort.TabIndex = 14;
            this.numericClientPort.Value = new decimal(new int[] {
            55555,
            0,
            0,
            0});
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(320, 10);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(344, 31);
            this.textBoxMessage.TabIndex = 13;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(670, 10);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(120, 31);
            this.buttonSend.TabIndex = 11;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 51);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(780, 100);
            this.textBox1.TabIndex = 10;
            // 
            // labelScreen
            // 
            this.labelScreen.AutoSize = true;
            this.labelScreen.Location = new System.Drawing.Point(10, 160);
            this.labelScreen.Name = "labelScreen";
            this.labelScreen.Size = new System.Drawing.Size(59, 25);
            this.labelScreen.TabIndex = 18;
            this.labelScreen.Text = "label1";
            // 
            // pictureBoxScreenShot
            // 
            this.pictureBoxScreenShot.Location = new System.Drawing.Point(146, 188);
            this.pictureBoxScreenShot.Name = "pictureBoxScreenShot";
            this.pictureBoxScreenShot.Size = new System.Drawing.Size(457, 250);
            this.pictureBoxScreenShot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxScreenShot.TabIndex = 19;
            this.pictureBoxScreenShot.TabStop = false;
            // 
            // buttonScreenShot
            // 
            this.buttonScreenShot.Location = new System.Drawing.Point(12, 188);
            this.buttonScreenShot.Name = "buttonScreenShot";
            this.buttonScreenShot.Size = new System.Drawing.Size(128, 32);
            this.buttonScreenShot.TabIndex = 20;
            this.buttonScreenShot.Text = "ScreenShot";
            this.buttonScreenShot.UseVisualStyleBackColor = true;
            this.buttonScreenShot.Click += new System.EventHandler(this.buttonScreenShot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonScreenShot);
            this.Controls.Add(this.pictureBoxScreenShot);
            this.Controls.Add(this.labelScreen);
            this.Controls.Add(this.comboBoxHost);
            this.Controls.Add(this.numericClientPort);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericClientPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreenShot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxHost;
        private NumericUpDown numericClientPort;
        private TextBox textBoxMessage;
        private Button buttonSend;
        private TextBox textBox1;
        private Label labelScreen;
        private PictureBox pictureBoxScreenShot;
        private Button buttonScreenShot;
    }
}