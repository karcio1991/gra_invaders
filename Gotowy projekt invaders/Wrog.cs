using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gotowy_projekt_invaders
{
    class Wrog
    {
        public Wrog()
        {

        }

        public virtual bool ZablokowaneStrzelaniaPrzezPotwora { get; set; }
        public virtual int Punkty { get; set; }
        public virtual Point Lokalizacja { get; set; }
        public virtual BugControl bbugControl { get; set; }
        public virtual FlyingsaucerControl fflyingsaucerControl { get; set; }
        public virtual SpaceshipControl sspaceshipControl { get; set; }
        public virtual WatchitControl wwatchiControl { get; set; }


    }

}
