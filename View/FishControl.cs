using Aquarium.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Aquarium.View
{
    public partial class FishControl : UserControl
    {
        private Fish _fish;
        public FishControl()
        {
            InitializeComponent();
        }

        public FishControl(Fish fish) : this()
        {
            _fish = fish;
            fishPB.Image = fish.FishIcon;
            nameL.Text = fish.Name;
        }

        private void saveBtn_Click(object sender, System.EventArgs e)
        {
            if(Parent.Parent is AddingForm)
            {
                (Parent.Parent as AddingForm).SelectedFish = GetFish();
                (Parent.Parent as AddingForm).Close();
            }
        }

        private Fish GetFish() => new Fish(_fish);
    }
}
