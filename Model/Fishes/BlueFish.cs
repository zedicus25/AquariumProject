using System;
using System.Drawing;

namespace Aquarium.Model.Fishes
{
    public class BlueFish : Fish
    {
        public BlueFish() :
           base(new Bitmap(Image.FromFile(@"F:\Project C#\Aquarium\Resources\fish4.png")), new Size(50, 40), DateTime.Now, new TimeSpan(0, 1, 30))
        {
            this.Name = "Blue Fish";
            this.Speed = 8;
            this.Cost = 800;
        }
    }
}
