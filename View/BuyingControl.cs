using Aquarium.Model;
using Aquarium.Model.Fishes;
using System;
using System.Collections.Generic;
using System.Linq;
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

            _fishControls.Add(new FishControl(new GoldFish()) { Location = new System.Drawing.Point(10,10)});
            _fishControls.Add(new FishControl(new FishClown()) { Location = new System.Drawing.Point(10+_fishControls.Last().Width, 10)});
            _fishControls.Add(new FishControl(new TropicalFish()) { Location = new System.Drawing.Point(10, 10+ _fishControls.Last().Height) });
            _fishControls.Add(new FishControl(new BlueFish()) { Location = new System.Drawing.Point(10+_fishControls.Last().Width, 10+ _fishControls.Last().Height) });
            this.Controls.AddRange(_fishControls.ToArray());
        }

        
    }
}
