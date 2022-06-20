using Aquarium.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium.Controller
{
    public class FeedController
    {
        private List<Feed> _feeds;
        private Bitmap _feedImage;

        public FeedController(Bitmap image)
        {
            _feeds = new List<Feed>();
            _feedImage = image;
        }

        public void AddFeed(Point spawnPos)
        {
            Random rnd = new Random();
            _feeds.Add(new Feed(spawnPos, new Size(35,35), rnd.Next(7,18)));
        }

        public void Fall(int maxY)
        {

            for (int i = 0; i < _feeds.Count; i++)
            {
                _feeds[i].Position = new Point(_feeds[i].Position.X, _feeds[i].Position.Y + _feeds[i].FallSpeed);

                if (_feeds[i].Position.Y >= maxY)
                {
                    _feeds.Remove(_feeds[i]);
                    --i;
                }
            }
        }
    }
}
