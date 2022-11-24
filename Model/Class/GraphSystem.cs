using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VectorEditor
{
    class GraphSystem
    {
        public Graphics graphics { get; set; }

        private Pen pen;
        public Pen Pen
        {
            get { return pen; }
            set { pen = value; }
        }
        private Color fillColor;
        public Color FillColor
        {
            get { return fillColor; }
            set { fillColor = value; }
        }
        public GraphSystem(Graphics gr)
        {
            graphics = gr;
            Pen = new Pen(Color.Black);
        }

        public void Line(int x, int y)
        {
            graphics.DrawLine(Pen, x, y, x+50, y+50);
        }

        public void Rect(int x, int y)
        {
            Rectangle rectangle = new Rectangle(x, y, 50, 50);    
            graphics.DrawRectangle(Pen,rectangle);
            SolidBrush sb = new SolidBrush(FillColor);
            graphics.FillRectangle(sb, rectangle);
        }

    }
}
