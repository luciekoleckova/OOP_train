using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_cv
{
    class NightWagon : PersonalWagon, IWagons
    {
        private Bed[] beds;
        private int numberOfBeds;
        public int NumberOfBeds { get { return numberOfBeds; } set { numberOfBeds = value; } }
        public Bed[] Beds { get { return beds; } set { beds = value; } }
        public NightWagon(int numberOfChairs, int numberOfBeds) : base(numberOfChairs)
        {
            this.numberOfBeds = numberOfBeds;
            Bed[] beds = new Bed[numberOfBeds];
           
        }
        public override string ToString()
        {
            return $"Typ vagonu: {this.GetType().Name}, počet sedadel: {NumberOfChairs}, počet lehátek: {numberOfBeds}";
        }
    }
}
