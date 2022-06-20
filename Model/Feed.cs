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

        public Feed(Point position, Size feedSize, int fallSpeed)
        {
            this.Position = position;
            this.FeedSize = feedSize;
            this.FallSpeed = fallSpeed;
        }
    }
}
