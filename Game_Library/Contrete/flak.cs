using Game_Library.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Library.Contrete
{
    internal class flak : anObject 
    {
        public flak(int panelSize, Size movementArea) : base (movementArea)
        {
            Left = (panelSize - Width) / 2;
            Movementarea = 
        }
    }
}
