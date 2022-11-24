using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorEditor
{
    internal class Rect : Figure
    {
        public Rect(Frame frame, PropList propList) : base(frame, propList)
        {
        }

        protected override void DrawGeometry(GraphSystem gs)
        {
            gs.Rect(this.Frame.X, this.Frame.Y);
        }
    }
}
