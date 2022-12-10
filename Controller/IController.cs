using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorEditor.Controller
{
    
    interface IController
    {
        Model.Interface.IModel Model { get; set; }
        IEventHandler IEvHandler { get; }
    }
}
