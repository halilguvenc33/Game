using Game_Library.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Library.Abstract
{
    internal abstract class anObject : PictureBox, ImoveObject
    {
        

        public Size Movementarea { get; }

        public int MovementRange { get; protected set; }

        public bool moveOb(Directt directt)
        {
            switch(directt)
            {
                case directt.left:
                    break;
                case directt.right:
                    break;



            }
        }

        protected anObject(Size movementarea)
        {
            SizeMode = PictureBoxSizeMode.AutoSize;
            Movementarea = movementarea;
        }
    }
    
}
