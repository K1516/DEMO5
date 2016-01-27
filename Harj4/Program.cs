using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj4
{
    class Program
    {
        static void Main(string[] args)
        {
            Grip grip = new Grip();
            grip.Color = "Red";
            Blade blade = new Blade();
            blade.Shoot = "Right";
            blade.Color = "Green";
            blade.Softness = "Exrta hard";
            Floorballstick stick = new Floorballstick();
            stick.Name = "FatPipe";
            stick.Model = "Hole";
            stick.Height = "110 cm";
            stick.Flex = "2.3";
            stick.Color = "Black";
            stick.AddBlad(blade);
            Console.WriteLine(stick.ToString());

            Console.ReadLine();

        }
    }
}
