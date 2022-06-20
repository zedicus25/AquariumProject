using Aquarium.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aquarium.View
{
    public partial class Form1 : Form
    {
        private AquariumController _aquariumController;
        private Graphics _graphics;
        private Bitmap _bufferedImage;

        private Thread thread;
        public Form1()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Center;
            _bufferedImage = new Bitmap(this.Width, this.Height);
            _graphics = Graphics.FromImage(_bufferedImage);
             this.DoubleBuffered = true;
            _aquariumController = new AquariumController();
            
        }

        private void MovingAll()
        {
            _graphics.DrawImage(Properties.Resources.back, this.ClientRectangle);
            _aquariumController.Move(10, Width,Height);

            for (int i = 0; i < _aquariumController.FishControllers.Count; i++)
            {
                this._graphics.DrawImage(_aquariumController.FishControllers[i].Fish.FishIcon, _aquariumController.FishControllers[i].Fish.Position);
            }

            for (int i = 0; i < _aquariumController.FeedController.Feeds.Count; i++)
            {
                this._graphics.DrawImage(_aquariumController.FeedController.Feeds[i].FeedImage, _aquariumController.FeedController.Feeds[i].Position);
            }
            this.BackgroundImage = _bufferedImage;
            this.Invalidate();
        }
        private void Start()
        {

            thread = new Thread(new ThreadStart(MovingStart));
            thread.IsBackground = true;
            thread.Start();
        }

        private void MovingStart()
        {
            while (true)
            {
                this.BeginInvoke(new Action(() => {
                    MovingAll();
                }));

                Thread.Sleep(200);
            }
        }

        private void addFishBtn_Click(object sender, EventArgs e)
        {
            _aquariumController.AddFish(new FishController(
                new Bitmap(Image.FromFile(@"F:\Project C#\Aquarium\Resources\fish.png")), 
                new TimeSpan(0, 2, 0), 5, Width, Height));
        }

        private void addFeedBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            _aquariumController.AddFood(new Point(rnd.Next(10,Width),25));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Start();
        }
    }
}
