using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gotowy_projekt_invaders
{
    class Flyingsaucer : Wrog
    {


        FlyingsaucerControl flyingsaucerControl;
        private bool zablokowane = false;

        public FlyingsaucerControl FlyingsaucerControl { get { return flyingsaucerControl; } }
        public override FlyingsaucerControl fflyingsaucerControl { get { return this.flyingsaucerControl; } set { flyingsaucerControl = value; } }
        public override Point Lokalizacja { get { return FlyingsaucerControl.Location; } set { FlyingsaucerControl.Location = value; } }
        public override bool ZablokowaneStrzelaniaPrzezPotwora { get { return zablokowane; } set { zablokowane = value; } }
        public override int Punkty { get { return 20; } }



        public Flyingsaucer(Timer timer1)
        {
            flyingsaucerControl = new FlyingsaucerControl(timer1);
        }

     

    }
}
