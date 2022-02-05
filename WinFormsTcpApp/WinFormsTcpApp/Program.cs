// Copyright (c) 2022 YA-androidapp(https://github.com/YA-androidapp) All rights reserved.


namespace WinFormsTcpApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}