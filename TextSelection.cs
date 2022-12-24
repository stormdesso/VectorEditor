using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorEditor
{
    class TextSelection : MySelection
    {
        public TextSelection(Text _item) : base(_item)
        {
        }

        public override void Draw(GraphSystem gs)
        {
            base.Draw(gs);//нарисовали круги          
            List<Point> points = new List<Point>
            {
                new Point(this.Item.Frame.X, this.Item.Frame.Y),
                new Point(this.Item.Frame.X2, this.Item.Frame.Y),
                new Point(this.Item.Frame.X2, this.Item.Frame.Y2),
                new Point(this.Item.Frame.X, this.Item.Frame.Y2)
            };
            Pen p = new Pen(Color.Black, 1);
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            gs.graphics.DrawPolygon(p, points.ToArray());
        }
    }
}
