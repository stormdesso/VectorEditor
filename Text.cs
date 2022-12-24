using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorEditor
{
    class Text : Figure
    {
        private string textValue;

        public string TextValue
        {
            get { return textValue; }
            set { textValue = value; }
        }

        public Text(Frame frame, PropList propList) : base(frame, propList)
        {
            TextValue = "";
        }

        public override MySelection CreateSelection()
        {
            return new TextSelection(this);
        }

        public override bool InBody(int x, int y)
        {
            if (this.Frame.X <= x & x <= this.Frame.X2 & this.Frame.Y <= y & y <= this.Frame.Y2
                 || this.Frame.X >= x & x >= this.Frame.X2 & this.Frame.Y >= y & y >= this.Frame.Y2

                 || this.Frame.X <= x & x <= this.Frame.X2 & this.Frame.Y >= y & y >= this.Frame.Y2
                 || this.Frame.X >= x & x >= this.Frame.X2 & this.Frame.Y <= y & y <= this.Frame.Y2
                )
            {
                BodyHitPoint = new System.Drawing.Point(x, y);
                return true;
            }
            return false;
        }

        protected override void DrawGeometry(GraphSystem gs)
        {
            gs.Text(TextValue, this.Frame.X, this.Frame.Y, this.Frame.X2, this.Frame.Y2);
        }
    }
}
