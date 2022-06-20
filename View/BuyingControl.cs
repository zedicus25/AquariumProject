using Aquarium.Model.Fishes;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Aquarium.View
{
    public partial class BuyingControl : UserControl
    {
        private List<FishControl> _fishControls;
        public BuyingControl()
        {
            InitializeComponent();
            _fishControls = new List<FishControl>();

            _fishControls.Add(new FishControl(new GoldFish()));
            _fishControls.Add(new FishControl(new FishClown()));
        }

        
    }
}
