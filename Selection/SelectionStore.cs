using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorEditor
{
    class SelectionStore:List<Selection>
    {
        
        public Selection TryGrab(int x, int y) 
        {
            /*
            //foreach (Selection item in this)
            //{
            //    if (item.TryGrab(x, y))
            //    {
            //        activeSelection = item;
            //        return item;
            //    }
            //}
            */

            for (int i = this.Count -1; i >= 0; i++)
            {
                if (this[i].TryGrab(x, y))
                {
                    activeSelection = this[i];
                    return this[i];
                }
            }

            return null;               
        }

        private Selection activeSelection;
        public Selection ActiveSelection//Grab Selection
        {
            get { return activeSelection; }
        }

        public void Release()
        {
            activeSelection = null;
            foreach (Selection item in this)
            {
                item.ReleaseGrab();
            }
        }

        public void Draw(GraphSystem gs)
        {
            foreach (Selection item in this)
            {
                if (item.selectionIsGrab)
                    item.Draw(gs);
            }
        }

    }
}
