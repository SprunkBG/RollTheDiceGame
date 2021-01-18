using System;
using System.Collections.Generic;
using System.Text;

namespace RollTheDice
{
    interface IDice
    {

        int attemptsPlayer1 { get; set; }
        int attemptsPlayer2 { get; set; }

        void DicePlayer1();
        void DicePlayer2();
        void Greeting();
        void AskForPlayer2();
        void Player2();
        void Winner();
    }
}
