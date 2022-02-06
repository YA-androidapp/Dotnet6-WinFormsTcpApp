// Copyright (c) 2022 YA-androidapp(https://github.com/YA-androidapp) All rights reserved.


namespace WinFormsTcpClientApp
{
    public partial class Form1 : Form
    {
        private Client? client;
        private readonly SynchronizationContext? synchronizationContext;

        public Form1()
        {
            InitializeComponent();

            synchronizationContext = SynchronizationContext.Current;
        }

        delegate void SetTextCallback(string text);

        public void textBox1SetText(string text)
        {
            if (textBox1.IsDisposed) return;

            if (textBox1.InvokeRequired)
            {
                var delegateMethod = new SetTextCallback(textBox1SetText);

                textBox1.Invoke(delegateMethod, new object[] { text });
            }
            else
            {
                textBox1.Text += text.Replace("\0", "") + Environment.NewLine;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new Client(this);

            SetLabelScreen();
            SetHostsList();
        }

        private void buttonScreenShot_Click(object sender, EventArgs e)
        {
            TakeScreenShot();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            var host = comboBoxHost.Text;
            var message = textBoxMessage.Text;
            var port = decimal.ToInt32(numericClientPort.Value);
            if ((client != null) && (!string.IsNullOrEmpty(host)) && (!string.IsNullOrEmpty(message)))
            {
                client.Send(host, port, message);
            }
        }

        private async void SetHostsList()
        {
            await Task.Run(() =>
            {
                if (synchronizationContext == null) { return; }

                var ipArray = NetworkUtil.GetMyIp().Split(".");
                if (ipArray.Length < 4) { return; }

                for (int oct4 = 1; oct4 <= 255; oct4++)
                {
                    var address = string.Format("{0}.{1}.{2}.{3}", ipArray[0], ipArray[1], ipArray[2], oct4);

                    System.Net.NetworkInformation.Ping sender = new();
                    System.Net.NetworkInformation.PingReply reply = sender.Send(address, 50);
                    if (reply.Status == System.Net.NetworkInformation.IPStatus.Success)
                    {
                        synchronizationContext.Post(new SendOrPostCallback(o =>
                        {
                            comboBoxHost.Items.Add(reply.Address.ToString());
                        }), null);
                    }
                }
            });
        }

        private void SetLabelScreen()
        {
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;

            var sizeString = string.Format("{0} x {1}", width, height);
            labelScreen.Text = sizeString;
        }

        private void TakeScreenShot()
        {
            var bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            using (var g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(new Point(0, 0), new Point(0, 0), bmp.Size);
            }

            pictureBoxScreenShot.Image = bmp;
        }
    }
}