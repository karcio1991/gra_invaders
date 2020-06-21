using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gotowy_projekt_invaders
{
    class ShipControl : PictureBox
    {

        const string Player = @"C:\Users\test\source\repos\WindowsFormsApp35\WindowsFormsApp35\Resources\player.png";

        public ShipControl()
        {
            this.Image = Image.FromFile(Player);
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void UstawLokalizacje(Point location)
        {
            this.Location = location;
        }

    }
}
