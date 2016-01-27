using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj4
{
    class Blade
    {
        public string Shoot { get; set; }
        public string Softness { get; set; }
        public string Color { get; set; }
        public override string ToString()
        {
            return "Shoot: "+ Shoot + " Softness: " + Softness+ " Color: " + Color;
        }
    }
}
