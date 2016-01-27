using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj4
{
    class Floorballstick
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Height { get; set; }
         public string Flex { get; set; }
        public string Color { get; set; }
       
        public List<Blade> Bla { get; }
        public Floorballstick()
        {
            Bla = new List<Blade>();
        }
        public void AddBlad(Blade blade)
        {
            Bla.Add(blade);
        }
        public override string ToString()
        {
            string sStick = "Stick name: " + Name + " Model: " + Model + " Height: " + Height + " Flex: " + Flex + " Grip color:  " + Color + " Grip\n";
            foreach (Blade blade in Bla)
            {
                sStick += blade.ToString() + "\n";
            }
            return sStick;
        }
    }
}
