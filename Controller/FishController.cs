using Aquarium.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium.Controller
{
    public class FishController
    {
        private event Action _currentMove;
        private Fish _fish;
        private int _speed;


        public FishController(Bitmap fishImage,TimeSpan lifeTime, int speed)
        {
            _fish = new Fish();
            _fish.FishIcon = fishImage;
            _fish.FishIcon.MakeTransparent();
            _fish.FishSize = new Size(50, 20);
            _fish.LastEat = DateTime.Now;
            _fish.LifeTime = lifeTime;
            _speed = speed;

            _currentMove = MoveRight;
        }

        public void Move(int minX, int maxX)
        {

            if (_currentMove == MoveRight && (_fish.Position.X + _speed >= maxX))
            {
                _currentMove = MoveLeft;
            }

            else if (_currentMove == MoveLeft && (_fish.Position.X + _speed <= minX))
            {
                _currentMove = MoveRight;
            }

        }


        public void MoveTo(Feed feed)
        {

            if (_fish.Position.X + _fish.FishSize.Width / 2 < feed.Position.X)
            {
                _currentMove = MoveRight;
                return;
            }

            if (_fish.Position.X > feed.Position.X)
            {
                _currentMove = MoveLeft;
                return;
            }

            if (_fish.Position.Y + _fish.FishSize.Height / 2 < feed.Position.Y)
            {
                _currentMove = MoveDown;
                return;
            }

            if (_fish.Position.Y > feed.Position.Y + feed.FeedSize.Height / 2)
            {
                _currentMove = MoveUp;
                return;
            }
        }

        private void MoveRight()
        {
            _fish.Position = new Point(_fish.Position.X + _speed, _fish.Position.Y);
        }
        private void MoveLeft()
        {
            _fish.Position = new Point(_fish.Position.X - _speed, _fish.Position.Y);
        }
        private void MoveUp()
        {
            _fish.Position = new Point(_fish.Position.X, _fish.Position.Y - _speed);
        }
        private void MoveDown()
        {
            _fish.Position = new Point(_fish.Position.X, _fish.Position.Y + _speed);
        }
    }
}
