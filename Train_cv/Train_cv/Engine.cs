using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_cv
{
    class Engine
    {
        private string type;
        public string Type { get { return type; } set { type = value; } }
        public Engine(){ }
        public Engine(string type)
        {
            this.type = type;
        }
        public override string ToString()
        {
            return type;
        }
    }
}
