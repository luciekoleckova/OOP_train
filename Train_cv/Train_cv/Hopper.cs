using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_cv
{
    class Hopper : IWagons
    {
        private double loadingCapacity;
        public double LoadingCapacity { get { return loadingCapacity; } set { loadingCapacity = value; } }
        public Hopper(double loadingCapacity){ 
            this.loadingCapacity = loadingCapacity; 
        }
        public override string ToString()
        {
            return $"Typ vagonu: {this.GetType().Name}, kapacita: {loadingCapacity}";
        }
        public void ConnectWagon(Train train)
        {
            if ((train.Wagons.Count >= 5) && (train.Locomotive.Engine.Type == "parni"))
                Console.WriteLine("Vagon nelze připojit, parní lokomotiva neutáhne více než 5 vagonu");
            else if (train.Wagons.Contains(this))
                Console.WriteLine("Vagon nelze připojit, protože už je ve vlaku obsažen");
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
