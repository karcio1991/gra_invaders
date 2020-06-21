using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gotowy_projekt_invaders
{
    // delegaty!
    delegate void PktZaZabicieWroga(int lPkt);
    delegate void PozostalaIloscZycia();

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.Black;
            gra = new Game(new Rectangle(this.Location, new Size(this.Size.Width - 55, this.Size.Height)), zegarGry0);
            zegarGry0.Enabled = true;
            zegarGry0.Interval = 33;
            zegarGry0.Start();

            zegarGry1.Enabled = true;
            zegarGry1.Interval = 100;
            zegarGry1.Start();


            listaStrzalow = new List<ShotControl>();
            listaStrzalowWroga = new List<ShotControl>();
            listaGwiazdek = new List<Gwiazdka>();

            gra.UzupelnijWrogow();

            foreach (var item in gra.ListaWrogow)
            {
                if (item is Bug)
                    this.Controls.Add((item as Bug).BugControl);
                else if (item is Flyingsaucer)
                    this.Controls.Add((item as Flyingsaucer).FlyingsaucerControl);
                else if (item is Spaceship)
                    this.Controls.Add((item as Spaceship).SpaceshipControl);
                else if (item is Watchit)
                    this.Controls.Add((item as Watchit).WatchitControl);
            }

            zabiciePunkty += Analizator.ZbierajPkt;
            zabiciePunkty += UzupelnienieStatystykGry;
            mojeZycie += Analizator.Zycie;

            int increment = 80;
            for (int i = 0; i < 3; i++)
            {
                this.Controls.Add(new ShipControl() { Location = new Point(this.Location.X + this.Width - increment, this.Location.Y) });
                increment += 70;
            }
        }


        private Game gra;
        private event PozostalaIloscZycia mojeZycie;
        private event PktZaZabicieWroga zabiciePunkty;

        private List<ShotControl> listaStrzalowWroga;
        private List<ShotControl> listaStrzalow;
        private List<Gwiazdka> listaGwiazdek;

        private Random randomaLiczba = new Random();


        private void UzupelnienieStatystykGry(int i)
        {
            labelPoints.Text = Analizator.Punkty.ToString();
        }

        private void zegarGry0_Tick(object sender, EventArgs e)
        {
            zegarGry0.Stop();

            if (Analizator.Zycia == 0) return;
            gra.RuchWroga1();

            foreach (var item in listaStrzalow)
            {
                item.Location = new Point(item.Location.X, item.Location.Y - 5);
            }
            //wykryj kolizje!
            CzyMojPociskTrafil();
            CzyTrafilMniePocisk();

            if (listaStrzalowWroga.Count < 2)
            {
                WrogStrzelaLosowo();
            }
            ShotControl doUsuniecia = null;
            foreach (var item in listaStrzalowWroga)
            {

                item.Location = new Point(item.Location.X, item.Location.Y + 5);
                if (item.Location.Y > pbPlayer.Location.Y)
                    doUsuniecia = item;
            }
            if (doUsuniecia != null)
            {
                if (doUsuniecia.ID > gra.ListaWrogow.Count)
                    doUsuniecia.ID--;
                gra.ListaWrogow[doUsuniecia.ID - 1].ZablokowaneStrzelaniaPrzezPotwora = false;
                listaStrzalowWroga.Remove(doUsuniecia);
                this.Controls.Remove(doUsuniecia);
            }
            zegarGry0.Start();
        }

        private void zegarGry1_Tick(object sender, EventArgs e)//odpowiedzialny za wyswietlanie gwiazdek
        {
            zegarGry1.Stop();
            if (listaGwiazdek.Count < 4)
            {
                Gwiazdka nowa = new Gwiazdka();
                nowa.Location = new Point(randomaLiczba.Next(0, 1000), randomaLiczba.Next(0, 1000));
                listaGwiazdek.Add(nowa);
                this.Controls.Add(nowa);
            }
            else
            {
                Control x = listaGwiazdek.First();
                listaGwiazdek.RemoveAt(0);
                this.Controls.Remove(x);
            }
            zegarGry1.Start();
        }

        private void CzyTrafilMniePocisk()
        {
            Rectangle rec = new Rectangle(pbPlayer.Location, new Size(pbPlayer.Size.Width + 50, pbPlayer.Size.Height));

            foreach (var item in listaStrzalowWroga)
            {

                if (rec.Contains(item.Location))
                {
                    mojeZycie();
                    this.Controls.Remove(item);
                    Control doUsuniecia = null;
                    foreach (var item2 in this.Controls)
                    {
                        if (item2 is ShipControl)
                        {
                            doUsuniecia = item2 as Control;
                        }
                    }
                    this.Controls.Remove(doUsuniecia);
                    if (Analizator.KoniecGry())
                    {
                        //koniec gry
                        labelKoniecGry.Text = "Game over! Aby zrestartować aplikacje naciśnij Q!";
                        zegarGry0.Stop();
                        zegarGry1.Stop();

                    }
                }
            }

        }

        private void CzyMojPociskTrafil()
        {
            Wrog doUsuniecia = null;
            Control x = null;
            foreach (var item in gra.ListaWrogow)
            {
                Rectangle rec = new Rectangle(item.Lokalizacja, new Size(50, 25));
                foreach (var item2 in listaStrzalow)
                {
                    if (rec.Contains(item2.Location))
                    {
                        zabiciePunkty(item.Punkty);
                        doUsuniecia = item;
                        x = item2;
                    }
                }
                listaStrzalow.Remove(x as ShotControl);
            }

            gra.ListaWrogow.Remove(doUsuniecia);
            this.Controls.Remove(x);
            if (doUsuniecia is Bug)
            {
                this.Controls.Remove(doUsuniecia.bbugControl);
            }
            else if (doUsuniecia is Flyingsaucer)
            {
                this.Controls.Remove(doUsuniecia.fflyingsaucerControl);
            }
            else if (doUsuniecia is Spaceship)
            {
                this.Controls.Remove(doUsuniecia.sspaceshipControl);
            }
            else if (doUsuniecia is Watchit)
            {
                this.Controls.Remove(doUsuniecia.wwatchiControl);
            }

        }
        private void WrogStrzelaLosowo()
        {
            int losPotwow = randomaLiczba.Next(gra.ListaWrogow.Count - 6, gra.ListaWrogow.Count);

            if (gra.ListaWrogow[losPotwow] != null && gra.ListaWrogow[losPotwow].ZablokowaneStrzelaniaPrzezPotwora == false) //mozna strzelac
            {
                gra.ListaWrogow[losPotwow].ZablokowaneStrzelaniaPrzezPotwora = true;

                ShotControl shot = new ShotControl() { Location = new Point(gra.ListaWrogow[losPotwow].Lokalizacja.X, gra.ListaWrogow[losPotwow].Lokalizacja.Y), ID = losPotwow };
                this.Controls.Add(shot);
                this.listaStrzalowWroga.Add(shot);

            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.A)
            {
                pbPlayer.Location = new Point(pbPlayer.Location.X - 10, pbPlayer.Location.Y);
            }
            else if (e.KeyChar == (char)Keys.D)
            {
                pbPlayer.Location = new Point(pbPlayer.Location.X + 10, pbPlayer.Location.Y);
            }
            else if (e.KeyChar == (char)Keys.S)
            {
                ShotControl shot = new ShotControl();
                shot.UstawLokalizacje(new Point(pbPlayer.Location.X + pbPlayer.Width / 2, pbPlayer.Location.Y - shot.Height));
                listaStrzalow.Add(shot);
                this.Controls.Add(shot);
            }
            else if (e.KeyChar == (char)Keys.Q)
            {

                Thread.Sleep(1000);
                Application.Restart();
            }
        }
    }
}
