using Aquarium.Controller;
using Aquarium.Model;
using Aquarium.Model.Fishes;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Aquarium.View
{
    public partial class MainForm : Form
    {
        private AquariumController _aquariumController;
        private Graphics _graphics;
        private Bitmap _bufferedImage;

        private AddingForm _addingForm;


        private Thread _moveThread;
        public MainForm()
        {
            InitializeComponent();
            _addingForm = new AddingForm();
            this.BackgroundImageLayout = ImageLayout.Center;
            _bufferedImage = new Bitmap(this.Width, this.Height);
            _graphics = Graphics.FromImage(_bufferedImage);
             this.DoubleBuffered = true;
            _aquariumController = new AquariumController();
            if(File.Exists("data.txt"))
                _aquariumController.Balance = Convert.ToInt32(File.ReadAllText("data.txt"));
            
        }

        private void MovingAll()
        {
            _graphics.DrawImage(Properties.Resources.back, this.ClientRectangle);
            _aquariumController.Move(10, Width,Height);

            _graphics.DrawString($"Balance = {_aquariumController.Balance}", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.DarkMagenta, new Point(10, 10));

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

            _moveThread = new Thread(new ThreadStart(MovingStart));
            _moveThread.IsBackground = true;
            _moveThread.Start();
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
            _addingForm.ShowDialog();
            Fish f = _addingForm.SelectedFish;
            if( f!=null )
                _aquariumController.AddFish(new FishController(f, f.Speed, Width, Height));
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText("data.txt", _aquariumController.Balance.ToString());
        }
    }
}
