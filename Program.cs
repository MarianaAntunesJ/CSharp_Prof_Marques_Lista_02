﻿using System;
using System.Threading;

namespace Lista_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Menu.MenuOpcoes();
        }
    }
}
