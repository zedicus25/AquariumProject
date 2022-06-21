using Aquarium.Controller;
using Aquarium.Model;
using System.Windows.Forms;

namespace Aquarium.View
{
    public partial class AddingForm : Form
    {
        public Fish SelectedFish { get; set; }
        public int Balance => controller.Balance;
        AquariumController controller;
        public AddingForm()
        {
            InitializeComponent();
        }
        public AddingForm(AquariumController c) : this()
        {
            controller = c;
            InitializeComponent();
        }

        public void GetPrice(int cost)
        {
            controller.Balance -= cost;
        }
    }
}
