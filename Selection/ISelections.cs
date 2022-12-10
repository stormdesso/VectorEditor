using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorEditor
{
    interface ISelections
    {
        void DragSelectionsTo(int x, int y);
        void ReleaseSelection();
        void DeleteSelections();

    }
}
