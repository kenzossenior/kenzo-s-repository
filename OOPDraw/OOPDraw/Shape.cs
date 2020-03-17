using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDraw
{
    interface Shape
    {
        void Draw();

        void MoveTo(float x, float y);
    }
}
