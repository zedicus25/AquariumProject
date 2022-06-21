using System;
using System.Drawing;

namespace Aquarium.Model.Fishes
{
    public class TropicalFish : Fish
    {
        public TropicalFish() :
            base(new Bitmap(Image.FromFile(@"F:\Project C#\Aquarium\Resources\fish1.png")), new Size(50, 50), DateTime.Now, new TimeSpan(0, 1, 0))
        {
            this.Name = "Tropical Fish";
            this.Speed = 10;
        }
    }
}
