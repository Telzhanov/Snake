﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Game g = new Game();
            g.Start();

        }
    }
}