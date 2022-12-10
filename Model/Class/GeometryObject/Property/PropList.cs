﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorEditor
{
    internal class PropList :List<Property>
    {
        public void Aplly(GraphSystem graphSystem)
        {
            for (int i = 0; i < Count; i++)
            {
                this[i].Apply(graphSystem);//у текущего элемента(объекта) вызываем метод Apply
            }
        }
    }
}
