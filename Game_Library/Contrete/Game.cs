using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game_Library.Interface;
using System.Drawing;

namespace Game_Library.Contrete
{
    public class Game : IGame
    {
        private readonly Panel _flakArea;

        public bool GameContinue { get; private set; }

        public void flakFire()
        {
            throw new NotImplementedException();
        }

        public void startGame()
        {
            if (!GameContinue)
            {
                GameContinue = true;
            
                createFlak();
    
            }

        }
        public Game (Panel flakArea)
        {
            _flakArea = flakArea;

        }

        private void createFlak()
        {
            var _flak = new flak(_flakArea.Width, _flakArea.Size)
            {
                Image = Image.FromFile(@"Flak.png")
            };
           
            _flakArea.Controls.Add(_flak);

        }

        public void stopGame()
        {
            if (GameContinue)
            {
                GameContinue = false;
            }
        }
    }
}