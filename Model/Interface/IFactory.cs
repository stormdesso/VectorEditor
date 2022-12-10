using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorEditor.Model.Interface
{
    public enum ItemType  { Line, Rect, Nothing }
    public interface IFactory
    {        
        ItemType itemType { get; set; }
        //object CreateItem(int x, int y);        
        void CreateAndGrabItem(int x, int y);
    }
}
