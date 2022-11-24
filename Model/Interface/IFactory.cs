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
        void CreateItem(int x, int y);
    }
}
