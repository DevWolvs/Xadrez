﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace Xadrez {
    class Program {
        static void Main(string[] args) {
            Posicao P;

            P = new Posicao(3, 4);

            Console.WriteLine("Pos: " + P);

            Console.ReadLine();
        }
    }
}
