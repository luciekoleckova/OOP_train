using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_cv
{
    class EconomyWagon : PersonalWagon, IWagons
    {
        public EconomyWagon(int numberOfChairs) : base(numberOfChairs) { }
        public override string ToString()
        {
            return $"Typ vagonu: {this.GetType().Name}, počet sedadel: {NumberOfChairs}";
        }
    }
}