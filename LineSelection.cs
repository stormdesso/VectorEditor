using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorEditor
{
    class LineSelection : MySelection
    {
        public LineSelection(Line _item) : base(_item)
        {

        }

        public override bool frameTryDragTo(int x, int y)
        {
            if (IsGrab)
            {                                
                if (this.Item.Frame.X == this.GrabPoint.X & this.Item.Frame.Y == this.GrabPoint.Y)
                {
                    this.Item.Frame.X = x;
                    this.Item.Frame.Y = y;
                    this.GrabPoint = new Point(x, y);
                }
                else if (this.Item.Frame.X2 == this.GrabPoint.X & this.Item.Frame.Y2 == this.GrabPoint.Y)
                {
                    this.Item.Frame.X2 = x;
                    this.Item.Frame.Y2 = y;
                    this.GrabPoint = new Point(x, y);
                }
                return true;
            }
            else if (bodyIsActive)
            {

                Item.Frame.X += x - Item.BodyHitPoint.X;
                Item.Frame.X2 += x - Item.BodyHitPoint.X;
                Item.Frame.Y += y - Item.BodyHitPoint.Y;
                Item.Frame.Y2 += y - Item.BodyHitPoint.Y;

                Item.InBody(x, y);
                return true;
                /*
                int dx = Math.Abs(Item.Frame.X2 - Item.Frame.X) / 2;
                int dy = Math.Abs(Item.Frame.Y2 - Item.Frame.Y) / 2;


                if (Item.Frame.X <= x & x <= Item.Frame.X2 & Item.Frame.Y <= y & y <= Item.Frame.Y2)
                {
                    Item.Frame.X = x - dx;
                    Item.Frame.Y = y - dy;

                    Item.Frame.X2 = x + dx;
                    Item.Frame.Y2 = y + dy;
                }
                if (Item.Frame.X2 <= x & x <= Item.Frame.X & Item.Frame.Y2 <= y & y <= Item.Frame.Y  )
                {
                    Item.Frame.X2 = x - dx;
                    Item.Frame.Y2 = y - dy;

                    Item.Frame.X = x + dx;
                    Item.Frame.Y = y + dy;
                }

                if (Item.Frame.X <= x & x <= Item.Frame.X2 & Item.Frame.Y2 <= y & y <= Item.Frame.Y)
                {
                    Item.Frame.X = x - dx;
                    Item.Frame.Y = y + dy;

                    Item.Frame.X2 = x + dx;
                    Item.Frame.Y2 = y - dy;
                }

                if (Item.Frame.X2  <= x & x <= Item.Frame.X & Item.Frame.Y <= y & y <= Item.Frame.Y2)
                {
                    Item.Frame.X = x + dx;
                    Item.Frame.Y = y - dy;

                    Item.Frame.X2 = x - dx;
                    Item.Frame.Y2 = y + dy;
                }

                return true;
                */
            }
            else
                return false;
        }

        public override void Draw(GraphSystem gs)
        {
            gs.graphics.DrawEllipse(gs.penSelection, new System.Drawing.Rectangle(this.Item.Frame.X - px, this.Item.Frame.Y - px, 2 * px, 2 * px));
            gs.graphics.DrawEllipse(gs.penSelection, new System.Drawing.Rectangle(this.Item.Frame.X2 - px, this.Item.Frame.Y2 - px, 2 * px, 2 * px));
        }
                
        public override bool TryGrab(int x, int y)// попытка захватить какой-либо маркер линии
        {

            if (Item.Frame.X - px <= x & x <= Item.Frame.X + px    &    Item.Frame.Y - px <= y & y <= Item.Frame.Y + px)
            {
                GrabPoint= new Point(Item.Frame.X, Item.Frame.Y);
                IsGrab = true;
                return true;
            }
            if (Item.Frame.X2 - px <= x & x <= Item.Frame.X2 + px    &    Item.Frame.Y2 - px <= y & y <= Item.Frame.Y2 + px)
            {
                GrabPoint = new Point(Item.Frame.X2, Item.Frame.Y2);
                IsGrab = true;
                return true;
            }
            return false;
        }
    }
}
