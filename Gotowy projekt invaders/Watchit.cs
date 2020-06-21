using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gotowy_projekt_invaders
{
    class Watchit : Wrog
    {

        WatchitControl watchitControl;
        private bool zablokowane = false;

        public WatchitControl WatchitControl { get { return watchitControl; } }
        public override Point Lokalizacja
        {
            get { return WatchitControl.Location; }
            set { WatchitControl.Location = value; }
        }
        public override bool ZablokowaneStrzelaniaPrzezPotwora { get { return zablokowane; } set { zablokowane = value; } }
        public override WatchitControl wwatchiControl { get { return this.watchitControl; } set { watchitControl = value; } }
        public override int Punkty { get { return 40; } }


        public Watchit(Timer timer1)
        {
            watchitControl = new WatchitControl(timer1);
        }

    }
}
