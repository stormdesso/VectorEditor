using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorEditor.Model.Interface
{
    internal interface IGrController
    {
        void SetPort(Graphics g);
        void Repaint();
    }
}
