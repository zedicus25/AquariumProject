using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium.Controller
{
    public class AquariumController
    {
        public List<FishController> FishControllers { get; }
        public FeedController FeedController { get; }

        public int Balance { get; set; } = 0;

        public AquariumController()
        {
            FishControllers = new List<FishController>();
            FeedController = new FeedController(new Bitmap(Image.FromFile(@"F:\Project C#\Aquarium\Resources\apple.png")));
        }

        public void AddFood(Point pos) => FeedController.AddFeed(pos);


        public void AddFish(FishController fish) => FishControllers.Add(fish);

        public void RemoveFish(FishController fish) => FishControllers.Remove(fish);

        public void Move(int minX, int maxX, int maxY)
        {
            FeedController.Fall(maxY);
            if (FeedController.Feeds.Count > 0)
            {
                for (int i = 0; i < FishControllers.Count; i++)
                {
                    if (FishControllers[i].Fish.IsAlive)
                        FishControllers[i].MoveTo(FeedController.Feeds[0]);
                    else
                    {
                        Balance += FishControllers[i].SellPrice;
                        FishControllers.Remove(FishControllers[i]);
                        --i;
                    }
                }
            }
            else
            {
                for (int i = 0; i < FishControllers.Count; i++)
                {
                    if (FishControllers[i].Fish.IsAlive)
                        FishControllers[i].Move(minX, maxX);
                    else
                    {
                        Balance += FishControllers[i].SellPrice;
                        FishControllers.Remove(FishControllers[i]);
                        --i;
                    }
                }
            }

            for (int i = 0; i < FeedController.Feeds.Count; i++)
            {
                for (int j = 0; j < FishControllers.Count; j++)
                {
                    if (FishControllers[j].CanEat(FeedController.Feeds[i]))
                    {
                        FishControllers[j].Fish.LastEat = DateTime.Now;
                        FeedController.Feeds.Remove(FeedController.Feeds[i]);
                        break;
                    }
                }
            }
        }
 
    }
}
