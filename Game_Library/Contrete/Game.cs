using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Library.Interface;

namespace Game_Library.Contrete
{
    public class Game : IGame
    {
        public bool isGameContinue => throw new NotImplementedException();

        public TimeSpan gettingTime => throw new NotImplementedException();

        public void flakFire()
        {
            throw new NotImplementedException();
        }

        public void startGame()
        {
            if (!isGameContinue)
            {
                isGameContinue = true;
            }

        }

        public void gameOver()

         {
            if (isGameContinue)
            {
                isGameContinue = false;
            }
        }            
    }
}

