﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListNetworkComputers;
using Ini;
using System.Collections;

namespace conSol
{
    class Program
    {
        static void Main(string[] args)
        {
            IniFile ini = new IniFile("C:\\users\\ade\\test.ini");
            ini.IniWriteValue("marcha", "dos", "pescadores");
            String readString = ini.IniReadValue("marcha", "dos");
            System.Console.WriteLine("Hello " + readString);

            ArrayList networkComputers = new ArrayList();

            NetworkBrowser nb = new NetworkBrowser();
            networkComputers = nb.getNetworkComputers();

            Console.WriteLine( networkComputers[0]);



        }
    }
}
