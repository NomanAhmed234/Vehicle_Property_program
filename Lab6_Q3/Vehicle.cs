using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Q3
{
    internal class Vehicle
    {
        private string model, color, engine;
        public string getmodel()
        {
            return model;
        }

        public void setmodel(string _model)
        {
            model = _model;
        }

        public string getcolor()
        {
            return color;
        }

        public void setcolor(string _color)
        {
            color = _color;
        }

        public string getengine()
        {
            return engine;
        }

        public void setengine(string _engine)
        {
            engine = _engine;
        }
    }
}
