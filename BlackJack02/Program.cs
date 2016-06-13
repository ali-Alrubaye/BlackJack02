using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack02
{
    class Program
    {
        static void Main(string[] args)
        {
            BlackJackGame blackjackgame = new BlackJackGame();


            blackjackgame.Meny();
            blackjackgame.GameOn();
        }
    }
}
