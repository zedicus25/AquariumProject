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
            costL.Text = fish.Cost.ToString();
        }

        private void saveBtn_Click(object sender, System.EventArgs e)
        {
            if(Parent.Parent is AddingForm)
            {
                AddingForm f = (Parent.Parent as AddingForm);
                if (_fish.Cost <= f.Balance)
                {
                    f.SelectedFish = GetFish();
                    f.GetPrice(_fish.Cost);
                    f.Close();
                }
                else
                {
                    MessageBox.Show("Dont have money");
                }
            }
        }

        private Fish GetFish() => new Fish(_fish);
    }
}
