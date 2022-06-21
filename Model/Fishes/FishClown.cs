using System;
using System.Drawing;

namespace Aquarium.Model.Fishes
{
    public class FishClown :Fish
    {
        public FishClown() :
            base(new Bitmap(Image.FromFile(@"F:\Project C#\Aquarium\Resources\fish3.png")), new Size(50, 35), DateTime.Now, new TimeSpan(0, 0, 50))
        {
            this.Name = "Clown Fish";
            this.Speed = 7;
        }
    }
}
