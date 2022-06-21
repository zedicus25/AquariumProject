using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium.Model.Fishes
{
    public class GoldFish : Fish
    {
        public GoldFish() :
            base(new Bitmap(Image.FromFile(@"F:\Project C#\Aquarium\Resources\fish2.png")), new Size(50,35), DateTime.Now, new TimeSpan(0,0,35))
        {
            this.Name = "Gold Fish";
            this.Speed = 5;
        }
    }
}
