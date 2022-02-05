// Copyright (c) 2022 YA-androidapp(https://github.com/YA-androidapp) All rights reserved.


using SimpleTCP;

namespace WinFormsTcpApp
{
    public class Client
    {
        private Form1 form1;
        private SimpleTcpClient client;

        public Client(Form1 Form1_Obj)
        {
            form1 = Form1_Obj;
        }

        public void Send(string ipAddr, int port, string message)
        {
            if (client == null)
            {
                client = new SimpleTcpClient().Connect(ipAddr, port);
            }

            var replyMsg = client.WriteAndGetReply(message + '\0');

            if (form1 != null)
            {
                form1.textBox1SetText("Client Received: " + replyMsg.MessageString);
            }
        }
    }
}