using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_cv
{
    class Chair
    {
        private int number;
        private bool nearWindow;
        private bool reserved;
        public int Number { get { return number; } set { number = value; } }
        public bool NearWindow { get { return nearWindow; } set { nearWindow = value; } }
        public bool Reserved { get { return reserved; } set { reserved = value; } }
        public Chair() { }
        public Chair(int number)
        {
            this.number = number;
            this.reserved = false;
        }
    }
}

