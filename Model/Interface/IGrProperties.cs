﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorEditor.Model.Interface
{
    internal interface IGrProperties
    {
        IContourProps ContourProps { get; }
        IFillProps FillProps { get; }
    }
}
