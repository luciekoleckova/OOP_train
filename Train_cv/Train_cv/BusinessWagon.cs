using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_cv
{
    class BusinessWagon : PersonalWagon, IWagons
    {
        private Person steward;
        public Person Steward { get { return steward; } set { steward = value; } }
        public BusinessWagon(int numberOfChairs, Person steward) : base(numberOfChairs)
        {
            this.steward = steward;
        }
        public override string ToString()
        {
            return $"Typ vagonu: {this.GetType().Name}, počet sedadel: {NumberOfChairs}, steward {steward}"; 
        }
    }
}
