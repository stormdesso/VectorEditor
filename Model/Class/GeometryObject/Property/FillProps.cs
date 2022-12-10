using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorEditor
{
    class FillProps : Property, Model.Interface.IFillProps
    {
        Color color = Color.Red;
        public FillProps(Color _color)
        {
            color = _color;
        }

        public Color Color { get => color; set => color = value; }

        public override void Apply(GraphSystem gs)
        {
            gs.FillColor = color;
        }
    }
}
