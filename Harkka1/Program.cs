using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harkka1
{
    class Program
    {
        static void Main(string[] args)
        {

            Tyres tyre = new Tyres();
            tyre.Name = " Hankook";
            tyre.Model = "Winter iPike";
            tyre.Size = "235/45/R17";
            Tyres tyr = new Tyres();
            tyr.Name = "Hankook";
            tyr.Model = "Winter iPike";
            tyr.Size = "265/50/R17";

            Car car = new Car();
            car.Vehicle = "Mercedes";
            car.Model = "E330";
            car.AddTyre(tyre);
            car.AddTyre(tyre);
            car.AddTyre(tyr);
            car.AddTyre(tyr);
            Console.WriteLine(car.ToString());


            Console.ReadLine();
        }
    }
}
