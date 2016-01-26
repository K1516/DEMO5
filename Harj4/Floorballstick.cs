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
        public List<Grip>Gri { get; }
        public Floorballstick()
        {
            Gri = new List<Grip>();
        }
        public void AddGrip(Grip grip)
        {
            Gri.Add(grip);
        }
        public override string ToString()
        {
            string sStick = "Stick name: " + Name + " Model: " + Model + " Grip: \n";
            foreach (Grip grip in Gri)
            {
                sStick += grip.ToString() + "\n";
            }
            return sStick;
        }
        public List<Blade> Bla { get; }

        {
            Bla = new List<Blade>();
        }
        public void AddGrip(Blade blade)
        {
            Bla.Add(blade);
        }
        public override string ToString()
        {
            string sStick = "Stick name: " + Name + " Model: " + Model + " Grip\n";
            foreach (Blade blade in Bla)
            {
                sStick += blade.ToString() + "\n";
            }
            return sStick;
        }
    }
}
