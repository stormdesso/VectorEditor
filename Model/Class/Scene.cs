using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorEditor.Model.Interface;

namespace VectorEditor.Model.Class
{
    internal class Scene : Interface.IGrController
    {
        public Scene(VectorEditor.GraphSystem gs, Store store, SelectionStore selectionStore)
        {
            this.store = store;
            this.gs = gs;
            this.selectionStore = selectionStore;
        }

        void IGrController.Repaint()
        {
            gs.graphics.Clear(Color.White);            

            foreach (var item in store)
            {
                item.Draw(gs);
            }

            selectionStore.Draw(gs);
        }

        void IGrController.SetPort(Graphics g)//добавить область вывода
        {
            gs.graphics = g;            
        }

        private SelectionStore selectionStore;
        public SelectionStore SelectionStore
        {
            get { return selectionStore; }
            set { selectionStore = value; }
        }
        public Store store { get; set; }
        public VectorEditor.GraphSystem gs { get; set; }
    }
}
