using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gotowy_projekt_invaders
{
    class ShotControl : PictureBox
    {
        public ShotControl()
        {
            timer1.Enabled = true;
            timer1.Interval = 150;
            timer1.Tick += new EventHandler(animationTimer_Tick);
            timer1.Start();


            Size = new Size(7, 22);
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        public int ID { get; set; }
        private Timer timer1 = new Timer();
        private int cell = 0;


        public void UstawLokalizacje(Point location)
        {
            this.Location = location;
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            cell++;
            switch (cell)
            {
                case 1:
                    {
                        BackgroundImage = Properties.Resources.shoot; break;
                    }
                case 2:
                    {
                        BackgroundImage = Properties.Resources.shoot1; break;
                    }
                default:
                    {
                        BackgroundImage = Properties.Resources.shoot2;
                        cell = 0;
                        break;
                    }
            }
        }


    }
}
