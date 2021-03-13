using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Library.Interface
{
    internal interface IGame
    {
        bool GameContinue { get; }

        void startGame();
        void flakFire();

    }
}
