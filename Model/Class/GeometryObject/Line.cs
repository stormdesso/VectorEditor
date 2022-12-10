using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorEditor
{
    internal class Line : Figure
    {
        public Line(Frame frame, PropList propList) : base(frame, propList)
        {
        }

        public override Selection CreateSelection()
        {
            return new LineSelection(this);
        }

        protected override void DrawGeometry(GraphSystem gs)
        {
            gs.Line(this.Frame.X, this.Frame.Y, this.Frame.X2, this.Frame.Y2);
        }
    }
}
