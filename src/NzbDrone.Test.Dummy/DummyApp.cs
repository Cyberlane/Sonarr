﻿using System;
using System.Diagnostics;

namespace NzbDrone.Test.Dummy
{
    public class DummyApp
    {
        public const string DUMMY_PROCCESS_NAME = "NzbDrone.Test.Dummy";

        static void Main(string[] args)
        {
            Console.WriteLine("Dummy process. ID:{0}  Path:{1}", Process.GetCurrentProcess().Id, Process.GetCurrentProcess().MainModule.FileName);
            Console.ReadLine();
        }
    }
}
