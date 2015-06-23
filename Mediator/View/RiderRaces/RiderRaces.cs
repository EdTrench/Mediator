using System.Collections.Generic;
using System.Windows.Forms;
using Mediator.Framework.UserControls;
using Mediator.Model;

namespace Mediator.View.RiderRaces
{
    public partial class RiderRaces : UserControl, IRiderRaces
    {
        public HostPanel HostPanel { get; set; }
        public IEnumerable<Rider> Riders
        {
            set
            {
                riders.cboRiders.DisplayMember = "Name";
                riders.cboRiders.DataSource = value;
            }
        }

        public void ExitApplication()
        {
            
        }

        public RiderRaces()
        {
            InitializeComponent();
        }

        public void SetPanel(HostPanel hostPanel)
        {
            HostPanel = hostPanel;
            HostPanel.Controls.Add(this);
            hostPanel.Initialise();
        }
    }
}