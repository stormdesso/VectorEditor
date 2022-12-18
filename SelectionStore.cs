using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorEditor
{
    class SelectionStore:List<MySelection>
    {
        
        public MySelection TryGrab(int x, int y) 
        {           
            for (int i = this.Count -1; i >= 0; i--)
            {
                if (this[i].TryGrab(x, y))
                {
                    activeSelection = this[i];
                    return this[i];
                }
            }

            return null;               
        }

        private MySelection activeSelection;
        public MySelection ActiveSelection//Grab Selection
        {
            get 
            {
                MySelection _active = null;
                int count = 0;

                foreach (MySelection item in this)
                    if (item.IsGrab || item.bodyIsActive)
                    {
                        if (count > 1)
                        {
                            Console.WriteLine("Активно более 2-х фигур");
                        }
                        _active = item;
                    }

                    return _active;
            }
        }

        public void Release()
        {
            activeSelection = null;
            foreach (MySelection item in this)
            {
                item.ReleaseGrab();
            }
        }

        public void Draw(GraphSystem gs)
        {
            foreach (MySelection item in this)
            {
                if (item.IsGrab || item.bodyIsActive)
                    item.Draw(gs);
            }
        }

    
        public List<GraphItem> GetSelectItems()
        {
            List<GraphItem> items = new List<GraphItem>();

            foreach (MySelection item in this)            
                if (item.IsGrab || item.bodyIsActive)
                    items.Add(item.Item);
            
            return items;
        }       
    }
}
