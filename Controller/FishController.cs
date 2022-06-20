using Aquarium.Model;
using System;
using System.Drawing;

namespace Aquarium.Controller
{
    public class FishController
    {
        public Fish Fish { get; set; }

        public Rectangle FishRectangle
        {
            get => new Rectangle(Fish.Position, Fish.FishSize);
        }
        private event Action<int> _currentMove;
        private int _speed;


        public FishController(Bitmap fishImage,TimeSpan lifeTime, int speed, int width, int height)
        {
            Random rnd = new Random();
            Fish = new Fish(fishImage, new Point(rnd.Next(50,width-75), rnd.Next(20,height-35)), new Size(50, 20),
                DateTime.Now, lifeTime);
            _speed = speed;

            _currentMove = MoveRight;
        }

        public void Move(int minX, int maxX)
        {

            if (_currentMove == MoveRight && (Fish.Position.X + _speed >= maxX))
            {
                _currentMove = MoveLeft;
            }

            else if (_currentMove == MoveLeft && (Fish.Position.X + _speed <= minX))
            {
                _currentMove = MoveRight;
            }

            _currentMove?.Invoke(_speed);
        }


        public void MoveTo(Feed feed)
        {

            if (Fish.Position.X + Fish.FishSize.Width / 2 < feed.Position.X)
            {
                _currentMove = MoveRight;
            }

            if (Fish.Position.X > feed.Position.X)
            {
                _currentMove = MoveLeft;
            }

            if (Fish.Position.Y + Fish.FishSize.Height / 2 < feed.Position.Y)
            {
                _currentMove = MoveDown;
            }

            if (Fish.Position.Y > feed.Position.Y + feed.FeedSize.Height)
            {
                _currentMove = MoveUp;
            }
            _currentMove?.Invoke(_speed*3);
        }

        public bool CanEat(Feed feed) => (Fish.IsAlive && this.FishRectangle.IntersectsWith(feed.Bounds));


        private void MoveRight(int speed)
        {
            Fish.Position = new Point(Fish.Position.X + speed, Fish.Position.Y);
        }
        private void MoveLeft(int speed)
        {
            Fish.Position = new Point(Fish.Position.X - speed, Fish.Position.Y);
        }
        private void MoveUp(int speed)
        {
            Fish.Position = new Point(Fish.Position.X, Fish.Position.Y - speed);
        }
        private void MoveDown(int speed)
        {
            Fish.Position = new Point(Fish.Position.X, Fish.Position.Y + speed);
        }
    }
}
