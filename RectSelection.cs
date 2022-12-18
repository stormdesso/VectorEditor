using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorEditor
{
    class RectSelection : MySelection
    {
        public RectSelection(Rect _item) : base(_item)
        {

        }
        
        //public override void Draw(GraphSystem gs)
        //{
        //    gs.graphics.DrawEllipse(gs.penSelection, new System.Drawing.Rectangle(this.Item.Frame.X - px, this.Item.Frame.Y - px, 2 * px, 2 * px));
        //    gs.graphics.DrawEllipse(gs.penSelection, new System.Drawing.Rectangle(this.Item.Frame.X2 - px, this.Item.Frame.Y2 - px, 2 * px, 2 * px));
        //    gs.graphics.DrawEllipse(gs.penSelection, new System.Drawing.Rectangle(this.Item.Frame.X - px, this.Item.Frame.Y2 - px, 2 * px, 2 * px));
        //    gs.graphics.DrawEllipse(gs.penSelection, new System.Drawing.Rectangle(this.Item.Frame.X2 - px, this.Item.Frame.Y - px, 2 * px, 2 * px));
        //}

        
       
        //public override bool TryGrab(int x, int y)
        //{
        //    if (Item.Frame.X - px <= x & x <= Item.Frame.X + px & Item.Frame.Y - px <= y & y <= Item.Frame.Y + px)
        //    {
        //        GrabPoint = new Point(Item.Frame.X, Item.Frame.Y);
        //        IsGrab = true;
        //        return true;
        //    }
        //    if (Item.Frame.X2 - px <= x & x <= Item.Frame.X2 + px & Item.Frame.Y2 - px <= y & y <= Item.Frame.Y2 + px)
        //    {
        //        GrabPoint = new Point(Item.Frame.X2, Item.Frame.Y2);
        //        IsGrab = true;
        //        return true;
        //    }

        //    if (Item.Frame.X - px <= x & x <= Item.Frame.X + px & Item.Frame.Y2 - px <= y & y <= Item.Frame.Y2 + px)
        //    {
        //        GrabPoint = new Point(Item.Frame.X2, Item.Frame.Y2);
        //        IsGrab = true;
        //        return true;
        //    }

        //    if (Item.Frame.X2 - px <= x & x <= Item.Frame.X2 + px & Item.Frame.Y - px <= y & y <= Item.Frame.Y + px)
        //    {
        //        GrabPoint = new Point(Item.Frame.X2, Item.Frame.Y2);
        //        IsGrab = true;
        //        return true;
        //    }


        //    return false;
        //}
    }
}
