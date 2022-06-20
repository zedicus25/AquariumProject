using System;
using System.Drawing;

namespace Aquarium.Model
{
    public class Fish
    {
        public Bitmap FishIcon { get; set; }

        public Point Position { get; set; }

        public Size FishSize { get; set; }

        public DateTime LastEat { get; set; }

        public TimeSpan LifeTime { get; set; }

        public string Name { get; set; }

        public bool IsAlive 
        { 
            get => DateTime.Now.Subtract(LastEat) < LifeTime; 
        }

        public Fish(Bitmap fishIcon, Size fishSize, DateTime lastEat, TimeSpan lifeTime)
        {
            FishIcon = new Bitmap(fishIcon, fishSize);
            FishIcon.MakeTransparent();
            FishSize = fishSize;
            LastEat = lastEat;
            LifeTime = lifeTime;
        }
    }
}
