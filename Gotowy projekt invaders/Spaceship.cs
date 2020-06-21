using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gotowy_projekt_invaders
{
    class Spaceship : Wrog
    {

        SpaceshipControl spaceshipControl;
        private bool zablokowane = false;
        public SpaceshipControl SpaceshipControl { get { return spaceshipControl; } }
        public override Point Lokalizacja { get { return SpaceshipControl.Location; } set { SpaceshipControl.Location = value; } }
        public override SpaceshipControl sspaceshipControl
        {
            get { return this.spaceshipControl; }
            set { spaceshipControl = value; }
        }
        public override bool ZablokowaneStrzelaniaPrzezPotwora { get { return zablokowane; } set { zablokowane = value; } }
        public override int Punkty { get { return 30; } }


        public Spaceship(Timer timer1)
        {
            spaceshipControl = new SpaceshipControl(timer1);
        }



    }
}
