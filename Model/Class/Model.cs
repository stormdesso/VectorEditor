using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorEditor.Model.Interface;

namespace VectorEditor.Model.Class
{
    internal class Model : VectorEditor.Model.Interface.IModel
    {
        public Model(VectorEditor.GraphSystem gs)
        {
            Store store = new Store();
            factory = new Factory(store);
            gr = new GrPropChannel(factory);
            scene = new Scene(gs, store);            
        }

        private GrPropChannel gr;
        IGrProperties IModel.GrProperties { get { return gr; } }

        private Scene scene;
        IGrController IModel.GrController { get { return scene; } }

        private Factory factory;
        IFactory IModel.Factory { get { return factory; } }
    }
}
