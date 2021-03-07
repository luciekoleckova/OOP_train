using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_cv
{
    class Program
    {

        static void Main(string[] args)
        {
            BusinessWagon b1 = new BusinessWagon(20, new Person("Lenka", "Kozakova"));
            NightWagon n1 = new NightWagon(10 , 30);
            Hopper h1 = new Hopper(200);
            Locomotive l1 = new Locomotive(new Person("Karel" , "Novak"), new Engine("diesel"));
            Train t1 = new Train(l1, new List<IWagons> { b1, n1, h1 });
            Console.WriteLine(t1);
          
            Hopper h2 = new Hopper(300);
            h2.ConnectWagon(t1);
            Console.WriteLine(t1);
           
            Locomotive l2 = new Locomotive(new Person("Jan", "Skacel"), new Engine("parni"));
            Hopper h3 = new Hopper(300);
            Hopper h4 = new Hopper(350);
            Hopper h5 = new Hopper(400);
            Hopper h6 = new Hopper(450);
            Hopper h7 = new Hopper(500);
            Train t2 = new Train(l2, new List<IWagons> { h3, h4, h5, h6, h7 });
            Console.WriteLine(t2);

            Hopper h8 = new Hopper(550);
            h8.ConnectWagon(t2);

            t1.ReserveChair(1, 15);
            t2.ReserveChair(2, 10);
            t1.ReserveChair(1, 15);
            t1.ReserveChair(1, 18);
            t1.ReserveChair(1, 5);
            t1.ListReservedChairs();

            Console.WriteLine(t1);
            Console.WriteLine(t2);

            Console.ReadKey();
        }
    }
}
