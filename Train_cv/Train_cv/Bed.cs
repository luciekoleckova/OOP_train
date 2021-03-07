using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_cv
{
    class Bed
    {
        private int number;
        private bool reserved;
        public int Number { get { return number; } set { number = value; } }
        public bool Reserved { get { return reserved; } set { reserved = value; } }
        public Bed() { }
        public Bed(bool reserved)
        {
            this.reserved = reserved;
        }
        public Bed(bool reserved, int number)
        {
            this.reserved = reserved;
            this.number = number;
        }
    }
}