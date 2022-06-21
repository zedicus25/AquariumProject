using Aquarium.Model;
using System.Windows.Forms;

namespace Aquarium.View
{
    public partial class AddingForm : Form
    {
        public Fish SelectedFish { get; set; }
        public AddingForm()
        {
            InitializeComponent();
        }
    }
}
