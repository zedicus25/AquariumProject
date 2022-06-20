using Aquarium.Model;
using System.Drawing;
using System.Windows.Forms;

namespace Aquarium.View
{
    public partial class FishControl : UserControl
    {
        public FishControl()
        {
            InitializeComponent();
        }

        public FishControl(Fish fish) : this()
        {
            fishPB.Image = fish.FishIcon;
            fishPB.Name = fish.Name;
        }
    }
}
