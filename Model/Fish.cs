using System;
using System.Drawing;

namespace Aquarium.Model
{
    public class Fish
    {
        public Bitmap FishIcon { get; set; }

        public Point Position { get; set; }

        public Size FishSize { get; set; }

        public int FishSpeed { get; set; }

        public DateTime LastEat { get; set; }

        public TimeSpan LifeTime { get; set; }

        public bool IsAlive 
        { 
            get => DateTime.Now.Subtract(LastEat) < LifeTime; 
        }
    }
}
