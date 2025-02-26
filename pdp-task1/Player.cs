using System;

namespace pdptask1
{

    class Player
    {
        public char currentPlayer = 'X';

        public void SwitchPlayer()
        {
            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
        }
    }
}