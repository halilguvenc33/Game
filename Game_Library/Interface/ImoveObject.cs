using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Library.Interface
{
    internal interface ImoveObject
    {

        Size MovementArea { get; }
        int MovementRange { get; }
        /// <summary>
        /// Move to Object desired direction
        /// </summary>
        /// <param name="directt"></param>
        /// <returns> return true if object exceed screen </returns>
        bool moveOb(Directt directt); 
    }
}
