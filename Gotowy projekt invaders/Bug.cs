using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gotowy_projekt_invaders
{
    class Bug : Wrog
    {
        BugControl bugControl;
        private bool zablokowane = false;

        public override bool ZablokowaneStrzelaniaPrzezPotwora { get { return zablokowane; } set { zablokowane = value; } }
        public override BugControl bbugControl { get { return this.BugControl; } set { bugControl = value; } }
        public override Point Lokalizacja { get { return BugControl.Location; } set { BugControl.Location = value; } }
        public override int Punkty { get { return 10; } }
        public BugControl BugControl { get { return bugControl; } }



        public Bug(Timer timer1)
        {
            bugControl = new BugControl(timer1);
        }

        public void ZmienLocation(int increment)
        {

        }

        public BugControl ReturnBugControl()
        {
            return bugControl;
        }

    }
}
