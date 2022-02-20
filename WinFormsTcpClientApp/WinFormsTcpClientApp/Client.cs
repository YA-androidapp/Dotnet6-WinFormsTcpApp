// Copyright (c) 2022 YA-androidapp(https://github.com/YA-androidapp) All rights reserved.


using SimpleTCP;
using System.Text.Json;

namespace WinFormsTcpClientApp
{
    public class Client
    {
        private Form1 form1;
        private SimpleTcpClient client;

        public Client(Form1 Form1_Obj)
        {
            form1 = Form1_Obj;
        }

        public void Send(string ipAddr, int port, string message, Image? screenshot)
        {
            if (client == null)
            {
                client = new SimpleTcpClient().Connect(ipAddr, port);
            }

            var jsonDict = new Dictionary<string, string>
            {
                { "Message", message}
            };
            if (screenshot != null) {
                jsonDict.Add("Screenshot", NetworkUtil.ImageToBase64(screenshot));
            }
            var jsonStr = JsonSerializer.Serialize(jsonDict);

            try
            {
                var replyMsg = client.WriteAndGetReply(jsonStr + '\0');

                if (form1 != null)
                {
                    form1.textBox1SetText("Client Received: " + replyMsg.MessageString);
                }
            }
            catch (Exception)
            {
                form1.textBox1SetText("Exception");
            }
        }
    }
}