﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class HUD
    {
        Player player = new Player();

        public void Draw() // TEMP
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(45, 0);
            Console.WriteLine("Player Stats:");
            Console.SetCursorPosition(45, 1);
            Console.WriteLine("Health: ");
            Console.SetCursorPosition(45, 2);

        }

        void Update()
        {

        }
    }
}
