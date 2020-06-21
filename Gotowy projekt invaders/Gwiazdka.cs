using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gotowy_projekt_invaders
{
    class Gwiazdka : PictureBox
    {

        public Gwiazdka()
        {
            timer1.Enabled = true;
            timer1.Interval = 150;
            timer1.Tick += new EventHandler(animationTimer_Tick);
            timer1.Start();


            Size = new Size(15, 15);
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        const string StalyObraz = @"C:\Users\test\source\repos\WindowsFormsApp35\WindowsFormsApp35\Resources\gwiazdka.jpg";
        private Timer timer1 = new Timer();
        Random random = new Random();
        float angle = 0;
        private int cell = 0;


        public void UstawLokalizacje(Point location)
        {
            this.Location = location;
        }
  
        private void animationTimer_Tick(object sender, EventArgs e)
        {
            Image image = Image.FromFile(StalyObraz);
            cell++; 
            switch (cell)
            {
                case 1:
                    {
                        image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        BackgroundImage = image;
                        break;
                    }
                case 2:
                    {
                        image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        BackgroundImage = image;
                        break;
                    }
                default:
                    {
                        image.RotateFlip(RotateFlipType.Rotate90FlipX);
                        BackgroundImage = image;
                        cell = 0;
                        break;
                    }
            }
        }
    }
}
