using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorEditor.Model.Interface;

namespace VectorEditor.Controller
{
    internal class Controller : IController
    {
        public Controller(object Model)
        {            
            this.Model = (IModel)Model;  
            eh = new EventHandler((IModel)Model);
        }

        public IModel Model { get; set; }

        private EventHandler eh;
        public IEventHandler IEvHandler { get => eh; }
    }
}
