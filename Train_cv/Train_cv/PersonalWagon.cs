using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_cv
{
    abstract class PersonalWagon : IWagons
    {
        private List<Door> doors = new List<Door>();
        private List<Chair> sits = new List<Chair>();

        private int numberOfChairs;
        public List<Door> Doors { get { return doors; } set { doors = value; } }
        public List<Chair> Sits { get { return sits; } set { sits = value; } }
        public int NumberOfChairs { get { return numberOfChairs; } set { numberOfChairs = value; } }
        public PersonalWagon(int numberOfChairs)
        {
            this.numberOfChairs = numberOfChairs;
            for (int i = 0; i < numberOfChairs; i++)
            {
                Sits.Add(new Chair(i + 1));
            }
        }
        public void ConnectWagon(Train train)
        {
            if ((train.Wagons.Count >= 5) && (train.Locomotive.Engine.Type == "parni"))
                Console.WriteLine("Vagon nelze připojit, parní lokomotiva neutáhne více než 5 vagonu");
            else if (train.Wagons.Contains(this))
                Console.WriteLine("Vagon nelze připojit, protože už je k vlaku připojen");
            else
            {
                train.Wagons.Add(this);
                Console.WriteLine("Vagon byl připojen");
            }
        }
        public void DisconnectWagon(Train train)
        {
            if (train.Wagons.Contains(this))
                 train.Wagons.Remove(this);
            else
                Console.WriteLine("Vagon nelze odpojit, protože není ve vlaku obsažen");
        }

    }
}
