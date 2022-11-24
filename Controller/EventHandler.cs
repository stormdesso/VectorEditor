using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorEditor.Model.Interface;

namespace VectorEditor.Controller
{
    internal class EventHandler : IEventHandler
    {
        private IModel model;
        public EventHandler(IModel model)
        {
            this.model = model;
        }

        public void LeftMouseUp(int x, int y)
        {
            model.Factory.CreateItem(x, y);            
        }
    }
}
