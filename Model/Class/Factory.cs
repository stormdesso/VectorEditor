using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VectorEditor.Model.Class
{
    class Factory : VectorEditor.Model.Interface.IFactory
    {
        public Factory(Store store, SelectionsController sc)
        {
            this.store = store;
            itemType = Interface.ItemType.Line;
            contProp = new ContourProps(System.Drawing.Color.Black, 5);
            fillProp = new FillProps(System.Drawing.Color.White);
            SelectionsController = sc;
        }       

        public void CreateAndGrabItem(int x, int y)
        {
            GraphItem item = CreateItem(x,y);
            SelectionsController.SelectAndGrabItem(item, x, y);
        }

        private SelectionsController selectionsController;
        public SelectionsController SelectionsController
        {
            get { return selectionsController; }
            set { selectionsController = value; }
        }
        public GraphItem CreateItem(int x, int y)
        {            
            PropList property = new PropList();
            ContourProps tmpConProp = new ContourProps(contProp.Color, contProp.Thickness);
            if (itemType == Interface.ItemType.Line)
            {                
                property.Add(tmpConProp);
                Line line = new Line(new Frame(x, y, x, y), property);
                store.Add(line);
                return line;
            }
            else            
            {
                FillProps tmpFillProp = new FillProps(fillProp.Color);
                property.Add(tmpConProp);
                property.Add(tmpFillProp);
                Rect rect = new Rect(new Frame(x, y, x, y), property);
                store.Add(rect);
                return rect;
            }           
        }


        public Interface.ItemType itemType { get; set; }
        public Store store { get; set; }
        public ContourProps contProp { get; set; }
        public FillProps fillProp { get; set; }
    }
}
