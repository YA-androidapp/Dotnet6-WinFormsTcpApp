// Copyright (c) 2022 YA-androidapp(https://github.com/YA-androidapp) All rights reserved.


namespace WinFormsTcpApp
{
    public partial class Form1 : Form
    {
        private Server server;

        public Form1()
        {
            InitializeComponent();
        }

        delegate void SetTextCallback(string text);
        delegate void SetImageCallback(Bitmap image);

        public  void textBox1SetText(string text)
        {
            if (textBox1.IsDisposed) return;

            if (textBox1.InvokeRequired)
            {
                SetTextCallback delegateMethod = new SetTextCallback(textBox1SetText);

                textBox1.Invoke(delegateMethod, new object[] { text });
            }
            else
            {
                textBox1.Text += text.Replace("\0", "") + Environment.NewLine;
            }
        }

        public void pictureBox1SetText(Image image)
        {
            if (pictureBox1.IsDisposed) return;

            if (pictureBox1.InvokeRequired)
            {
                SetImageCallback delegateMethod = new SetImageCallback(pictureBox1SetText);

                pictureBox1.Invoke(delegateMethod, new object[] { image });
            }
            else
            {
                pictureBox1.Image = image;
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            server = new Server(this);

            labelMyIp.Text = NetworkUtil.GetMyIp();
        }

        private void buttonListen_Click(object sender, EventArgs e)
        {
            var port = decimal.ToInt32(numericServerPort.Value);
            server.Listen(port);

            buttonListen.Enabled = false;
        }

        private void buttonCheckIp_Click(object sender, EventArgs e)
        {
            labelMyIp.Text = NetworkUtil.GetMyIp();
        }

        private void numericServerPort_ValueChanged(object sender, EventArgs e)
        {
            buttonListen.Enabled = true;
        }
    }
}