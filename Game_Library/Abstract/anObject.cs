using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Library.Abstract
{
    internal abstract class anObject : PictureBox
    {
        protected anObject()
        {
            SizeMode = PictureBoxSizeMode.AutoSize;
        }

    }
    
}
