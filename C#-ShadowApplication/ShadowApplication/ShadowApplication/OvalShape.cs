using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowApplication
{
    public class OvalShape
    {
        public Rectangle BoundingRectangle { get; set; }
        public Color Colour { get; set; }
        public bool Filled { get; set; }

        public OvalShape(Rectangle boundingRectangle, Color colour, bool filled)
        {
            BoundingRectangle = boundingRectangle;
            Colour = colour;
            Filled = filled;
        }

        public void Draw(Graphics gr)
        {
            if (Filled)
                gr.FillEllipse(new SolidBrush(Colour), BoundingRectangle);
            else
                gr.DrawEllipse(new Pen(Colour), BoundingRectangle);
        }
    }
}
