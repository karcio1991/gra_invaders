using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gotowy_projekt_invaders
{
    class BugControl : PictureBox
    {

        public BugControl(Timer timer1)
        {
            this.timer1 = timer1;
            timer1.Enabled = true;
            timer1.Interval = 15;
            timer1.Tick += new EventHandler(animationTimer_Tick);
            timer1.Start();



            Size = new Size(25, 25);
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;

        }

        public const int Punkty = 10;
        private Timer timer1;
        private int cell = 0;


        private void animationTimer_Tick(object sender, EventArgs e)
        {
            cell++;
            switch (cell)
            {
                case 1:
                    {
                        BackgroundImage = Properties.Resources.bug1; break;
                    }
                case 2:
                    {
                        BackgroundImage = Properties.Resources.bug2; break;
                    }
                case 3:
                    {
                        BackgroundImage = Properties.Resources.bug3; break;
                    }
                default:
                    {
                        BackgroundImage = Properties.Resources.bug4;
                        cell = 0;
                        break;
                    }
            }
        }


    }
}