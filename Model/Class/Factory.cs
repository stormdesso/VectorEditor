using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VectorEditor.Model.Class
{
    internal class Factory : VectorEditor.Model.Interface.IFactory
    {
        public Factory(Store store)
        {
            this.store = store;
            itemType = Interface.ItemType.Line;
            contProp = new ContourProps(System.Drawing.Color.Black, 5);
            fillProp = new FillProps(System.Drawing.Color.White);
        }

        public void CreateItem(int x, int y)
        {
            PropList property = new PropList();
            ContourProps tmpConProp = new ContourProps(contProp.Color, contProp.Thickness);
            if (itemType == Interface.ItemType.Line)
            {                
                property.Add(tmpConProp);
                Line line = new Line(new Frame(x, y), property);
                store.Add(line);
            }
            else
            if (itemType == Interface.ItemType.Rect)
            {
                FillProps tmpFillProp = new FillProps(fillProp.Color);
                property.Add(tmpConProp);
                property.Add(tmpFillProp);
                Rect rect = new Rect(new Frame(x, y), property);
                store.Add(rect);
            }
        }
        
        public Interface.ItemType itemType { get; set; }
        public Store store { get; set; }
        public ContourProps contProp { get; set; }
        public FillProps fillProp { get; set; }
    }
}
