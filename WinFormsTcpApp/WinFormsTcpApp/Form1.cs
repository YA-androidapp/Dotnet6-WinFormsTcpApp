// Copyright (c) 2022 YA-androidapp(https://github.com/YA-androidapp) All rights reserved.


namespace WinFormsTcpApp
{
    public partial class Form1 : Form
    {
        private Client client;
        private Server server;

        public Form1()
        {
            InitializeComponent();
        }

        delegate void SetTextCallback(string text);

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

        private async void Form1_Load(object sender, EventArgs e)
        {
            client = new Client(this);
            server = new Server(this);

            var result = await Task.Run(async () =>
            {
                return await NetworkUtil.GetHostsList();
            });
            comboBox1.Items.AddRange(result.ToArray());
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            var host = textBoxHost.Text;
            var message = textBoxMessage.Text;
            var port = decimal.ToInt32(numericClientPort.Value);
            if ((!string.IsNullOrEmpty(host)) && (!string.IsNullOrEmpty(message)))
            {
                client.Send(host, port, message);
            }
        }

        private void buttonListen_Click(object sender, EventArgs e)
        {
            var port = decimal.ToInt32(numericServerPort.Value);
            server.Listen(port);
        }

        private void buttonCheckIp_Click(object sender, EventArgs e)
        {
            labelMyIp.Text = NetworkUtil.GetMyIp();
        }
    }
}