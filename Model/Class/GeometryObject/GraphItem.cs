using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorEditor
{
    abstract class GraphItem
    {
        public Frame Frame { get; }
        public GraphItem(Frame _frame)
        {
            if (Frame == null)
                Frame = _frame;            
        }
        public abstract void Draw(GraphSystem gs);        
    }
}
