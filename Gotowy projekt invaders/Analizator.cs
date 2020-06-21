using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gotowy_projekt_invaders
{
    static class Analizator
    {
        //poustawiaj jeszcze modyfikatory dostepu!

        private static int punkty;
        private static int zycia = 3;

        public static int Punkty { get { return punkty; } set { punkty = value; } }
        public static int Zycia { get { return zycia; } set { zycia = value; } }

        public static void ZbierajPkt(int lpkt)
        {
            punkty += lpkt;
        }

        public static void Zycie()
        {
            zycia--;


        }


        public static bool KoniecGry()
        {
            if (zycia == 0)
                return true;
            return false;
        }

    }
}
