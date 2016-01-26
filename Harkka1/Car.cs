using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harkka1
{
    class Car
    {
        public string Vehicle { get; set; }
        public string Model { get; set; }
        public List<Tyres> Tyre { get; }
        public Car()
        {
            Tyre = new List<Tyres>();
        }
        public void AddTyre(Tyres tyre)
        {
            Tyre.Add(tyre);
        }
        public override string ToString()
        {
            string sCar = "Car name: " + Vehicle + " Model: " + Model + " Tyres: \n";
            foreach(Tyres tyre in Tyre)
            {
                sCar += tyre.ToString() + "\n";
            }
            return sCar;
        }

    }
}
