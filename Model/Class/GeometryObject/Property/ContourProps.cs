using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorEditor
{
    class ContourProps : Property, Model.Interface.IContourProps
    {
        Color color = Color.Black;
        int thickness = 5;

        public ContourProps(Color _color, int _thickness)
        {
            color = _color;
            thickness = _thickness;
        }

        public int Thickness { get => thickness; set => thickness = value; }
        public Color Color { get => color; set => color = value; }

        public override void Apply(GraphSystem gs)
        {
            gs.Pen.Color = color;
            gs.Pen.Width = thickness;
        }
    }
}
