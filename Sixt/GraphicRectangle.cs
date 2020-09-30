using System;
using System.Collections.Generic;
using System.Text;

namespace Sixt
{
    class GraphicRectangle : IDraw
    {
        public virtual void Draw()
        {
            Console.WriteLine("Das Rechteck wird gezeichnet");
        }
    }
}
