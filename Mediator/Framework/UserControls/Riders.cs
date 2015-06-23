using System;
using System.Windows.Forms;
using Mediator.Model;

namespace Mediator.Framework.UserControls
{
    public partial class Riders : UserControl
    {
        public Riders()
        {
            InitializeComponent();
        }

        private void cboRiders_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mediator.GetInstance().OnRiderChanged(this, (Rider)cboRiders.SelectedItem);
        }
    }
}