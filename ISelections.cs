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
        bool TryGrab(int x, int y);
        bool TrySelect(int x, int y, bool add);

        int Count { get;}
        bool Grouping();
        bool Ungrouping();
        void DeleteSelectedItems();

    }
}
