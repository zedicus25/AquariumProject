using System.Drawing;

namespace Aquarium.Model
{
    public class Feed
    {
        public Point Position { get; set; }

        public Size FeedSize { get; set; }

        public int FallSpeed { get; set; }

        public Rectangle Bounds
        {
            get => new Rectangle(Position, FeedSize);
        }
    }
}
