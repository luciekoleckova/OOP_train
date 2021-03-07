using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_cv
{
    class Locomotive
    {
        private Person driver;
        private Engine engine;

        public Person Driver { get { return driver; } set { driver = value; } }
        public Engine Engine { get { return engine; } set { engine = value; } }

        public Locomotive(){ }
        public Locomotive(Person driver)
        {
            this.driver = driver;
        }
        public Locomotive(Person driver, Engine engine)
        {
            this.driver = driver;
            this.engine = engine;
        }
        public override string ToString()
        {
             return $"Lokomotiva, typ motoru: {engine}, strojvedouci: {driver}";
        }
    }
}
