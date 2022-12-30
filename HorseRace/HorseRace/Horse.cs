using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace HorseRace
{
    internal class Horse : Button
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Radius { get; set; }
        public double Degrees { get; set; }

        public Horse()
        {
            //this.BackgroundImage =
        }
    }
}
