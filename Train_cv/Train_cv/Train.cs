using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_cv
{
    class Train
    {

        private Locomotive locomotive;
        private List<IWagons> wagons = new List<IWagons>();
        public Locomotive Locomotive { get { return locomotive; } set { locomotive = value; } }
        public List<IWagons> Wagons { get { return wagons; } set { wagons = value; } }
        public Train() { }
        public Train(Locomotive locomotive)
        {
            this.locomotive = locomotive;
        }
        public Train(Locomotive locomotive, List<IWagons> wagons)
        {
            this.locomotive = locomotive;
            this.wagons = wagons;
        }

        public override string ToString()
        {
            string vyslednyVlak = Locomotive.ToString() + "\n";
            foreach (var wag in Wagons)
            {
                vyslednyVlak += wag.ToString() + "\n";
            }
            return vyslednyVlak;
        }
        public void ReserveChair(int cisloWagonu, int cisloSedadla)
        {
            if (cisloWagonu > wagons.Count)
                Console.WriteLine("Sedadlo nelze rezervovat, tolik vagonu vlak nemá");
            else if (Wagons[(cisloWagonu - 1)] is Hopper)
                Console.WriteLine("Sedadlo nelze rezervovat, jedná se o nákladní vagon");
            else if (cisloSedadla > ((PersonalWagon)wagons[cisloWagonu - 1]).NumberOfChairs)
                Console.WriteLine("Sedadlo nelze rezervovat, vagon nemá tolik sedadel");
            else if (((PersonalWagon)wagons[cisloWagonu - 1]).Sits[cisloSedadla - 1].Reserved == true)
                Console.WriteLine("Toto sedadlo je už rezervované");
            else
            {
                ((PersonalWagon)wagons[cisloWagonu - 1]).Sits[cisloSedadla - 1].Reserved = true;
                Console.WriteLine("Sedadlo úspěšně rezervováno");
            }
        }
        public void ListReservedChairs()
        {
            int i = 1;
            foreach (IWagons wagonX in wagons)
            {
                if (wagonX is PersonalWagon)
                {
                    Console.WriteLine("Rezervované místa");
                    Console.WriteLine($"Vagon č. {i}:");
                    i++;
                    foreach (Chair chairX in ((PersonalWagon)wagonX).Sits)
                    {
                        if (chairX.Reserved == true)
                        {
                            Console.WriteLine($"sedačka: {chairX.Number}");
                        }
                    }
                }
            }
        }
    }
}