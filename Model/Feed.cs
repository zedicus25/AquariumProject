using System.Drawing;

namespace Aquarium.Model
{
    public class Feed
    {
        public Point Position { get; set; }

        public Size FeedSize { get; set; }

        public int FallSpeed { get; set; }
        public Bitmap FeedImage { get; set; }

        public Rectangle Bounds
        {
            get => new Rectangle(Position, FeedSize);
        }

        public Feed(Bitmap image,Point position, Size feedSize, int fallSpeed)
        {
            FeedImage = new Bitmap(image, feedSize);
            Position = position;
            FeedSize = feedSize;
            FallSpeed = fallSpeed;
        }
    }
}
