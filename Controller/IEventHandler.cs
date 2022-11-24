using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorEditor.Controller
{
    internal interface IEventHandler
    {
        void LeftMouseUp(int x, int y);       
    }
}
