using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gotowy_projekt_invaders
{
    class Game
    {

        public Game(Rectangle rectangle, Timer timer1)
        {
            this.zegarGry1 = timer1;
            listaWrogow = new List<Wrog>();
            this.obramowanieFormatki = rectangle;
        }

        private int zwiekszInteger = -5;
        private Rectangle obramowanieFormatki;
        private Timer zegarGry1;
        private List<Wrog> listaWrogow;

        public List<Wrog> ListaWrogow { get { return listaWrogow; } }

        public void RuchWroga1() // ruch potworow w lewo do konca granicy, potem W dol (RuchWroga2) a nastepnie w prawo do granicy i tak dalej...
        {
            foreach (var item in listaWrogow)
            {
                item.Lokalizacja = new Point(item.Lokalizacja.X + zwiekszInteger, item.Lokalizacja.Y);
            }
            foreach (var item in listaWrogow)
            {
                if (!obramowanieFormatki.Contains(item.Lokalizacja))
                {
                    RuchWroga2();
                    if (zwiekszInteger < 0) zwiekszInteger = 5;
                    else
                        zwiekszInteger = -5;
                    break;
                }
            }
        }

        public void RuchWroga2() // ruch potworow w dol 
        {
            foreach (var item in listaWrogow)
            {
                item.Lokalizacja = new Point(item.Lokalizacja.X, item.Lokalizacja.Y + 5);
            }
        }

        // uzupelnienie wszystkich wrogow 
        public void UzupelnijWrogow()
        {
            int incrementX = 0;
            for (int i = 0; i < 8; i++)
            {

                Bug bug = new Bug(zegarGry1);
                bug.BugControl.Location = new Point(incrementX, 33);
                listaWrogow.Add(bug);
                incrementX += 50;
            }

            incrementX = 0;
            for (int i = 0; i < 8; i++)
            {
                Flyingsaucer flying = new Flyingsaucer(zegarGry1);
                flying.FlyingsaucerControl.Location = new Point(incrementX, 50 + 33);
                listaWrogow.Add(flying);
                incrementX += 50;
            }

            incrementX = 0;

            for (int i = 0; i < 8; i++)
            {
                Spaceship space = new Spaceship(zegarGry1);
                space.SpaceshipControl.Location = new Point(incrementX, 100 + 33);
                listaWrogow.Add(space);
                incrementX += 50;
            }


            incrementX = 0;

            for (int i = 0; i < 8; i++)
            {
                Watchit watch = new Watchit(zegarGry1);
                watch.WatchitControl.Location = new Point(incrementX, 150 + 33);
                listaWrogow.Add(watch);
                incrementX += 50;
            }
        }

    }
}
