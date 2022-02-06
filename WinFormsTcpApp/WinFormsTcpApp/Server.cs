// Copyright (c) 2022 YA-androidapp(https://github.com/YA-androidapp) All rights reserved.


using SimpleTCP;

namespace WinFormsTcpApp
{
    public class Server
    {
        private const byte NULL_TERMINATED = 0x00;

        private Form1 form1;
        private SimpleTcpServer server;

        public Server(Form1 Form1_Obj)
        {
            form1 = Form1_Obj;
        }

        public void Listen(int port)
        {
            if (server == null)
            {
                server = new SimpleTcpServer().Start(port);
                server.Delimiter = NULL_TERMINATED;
                server.DelimiterDataReceived += (sender, msg) =>
                {
                    msg.ReplyLine("Re: " + msg.MessageString);

                    if (form1 != null)
                    {
                        form1.textBox1SetText("Server Received: " + msg.MessageString);
                    }
                };
            }
        }
    }
}