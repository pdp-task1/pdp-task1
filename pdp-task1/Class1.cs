﻿using System;

namespace PDPtask1
{
    class Board
    {
        public char[,] board =
        {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' }
        };

        public void DrawBoard()
        {
            Console.WriteLine("  {0} | {1} | {2} ", board[0, 0], board[0, 1], board[0, 2]);
            Console.WriteLine(" ---+---+---");
            Console.WriteLine("  {0} | {1} | {2} ", board[1, 0], board[1, 1], board[1, 2]);
            Console.WriteLine(" ---+---+---");
            Console.WriteLine("  {0} | {1} | {2} ", board[2, 0], board[2, 1], board[2, 2]);
        }
    }
}