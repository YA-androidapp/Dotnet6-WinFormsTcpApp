// Copyright (c) 2022 YA-androidapp(https://github.com/YA-androidapp) All rights reserved.


using System.Net;
using System.Net.Sockets;


namespace WinFormsTcpApp
{
    public class NetworkUtil
    {
        public static Image Base64ToImage(string base64)
        {
            byte[] byteBuffer = Convert.FromBase64String(base64);
            using (MemoryStream memoryStream = new MemoryStream(byteBuffer))
            {
                memoryStream.Position = 0;
                return Image.FromStream(memoryStream);
            }
        }

        public static string ImageToBase64(Image image)
        {
            using (var ms = new MemoryStream())
            {
                using (var bitmap = new Bitmap(image))
                {
                    bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    var base64encoded = Convert.ToBase64String(ms.GetBuffer());
                    return base64encoded;
                }
            }
        }

        public static string GetMyIp()
        {
            string myIp = "localhost";

            IPAddress[] myAddresses = Dns.GetHostAddresses(Dns.GetHostName());

            foreach (IPAddress myAddress in myAddresses)
            {
                if (myAddress.AddressFamily.Equals(AddressFamily.InterNetwork))
                {
                    myIp = myAddress.ToString();
                    break;
                }
            }

            return myIp;
        }

        public static async Task<List<string>> GetHostsList()
        {
            var ipList = new List<string>();

            var ipArray = GetMyIp().Split(".");
            if(ipArray.Length < 4) { return ipList; }

            for (int oct4 = 1; oct4 <= 255; oct4++)
            {
                var address = string.Format("{0}.{1}.{2}.{3}", ipArray[0], ipArray[1], ipArray[2], oct4);

                System.Net.NetworkInformation.Ping sender = new();
                System.Net.NetworkInformation.PingReply reply = sender.Send(address, 50);
                if (reply.Status == System.Net.NetworkInformation.IPStatus.Success)
                {
                    ipList.Add(reply.Address.ToString());
                }
            }

            return ipList;
        }
    }
}
