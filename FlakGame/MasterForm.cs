using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game_Library.Contrete;

namespace FlakGame
{
    public partial class MasterForm : Form
    {
        private readonly Game _game;

        public MasterForm()
        {
            InitializeComponent();
            _game = new Game(flakArea);
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MasterForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    _game.startGame();
                    break;
                case Keys.Space:
                    _game.flakFire();
                    break;
            }
        }
    }

    
}
