using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorEditor.Model.Interface;

namespace VectorEditor.Model.Class
{
    internal class GrPropChannel : VectorEditor.Model.Interface.IGrProperties
    {
        public GrPropChannel(Factory f)
        {            
            contProp = f.contProp;
            fillProp = f.fillProp;
        }

        private ContourProps contProp;
        public IContourProps ContourProps => contProp;
        private FillProps fillProp;
        public IFillProps FillProps => fillProp;
    }
}
