using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorEditor.Model.Interface
{
    interface IContourProps
    {
        int Thickness { get; set; }
        Color Color { get; set; }
    }
}
