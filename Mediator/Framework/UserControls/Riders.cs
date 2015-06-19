using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mediator.Model;

namespace Mediator.Framework.UserControls
{
    public partial class Riders : UserControl
    {
        readonly List<Rider> _riders = new List<Rider>()
        {
            new Rider {Name = "Frederick Stanley Trencahrd"},
            new Rider {Name = "William Albert Trenchard"},
            new Rider {Name = "Sarah Clare Trenchard"}
        };
        
        public Riders()
        {
            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            cboRiders.DisplayMember = "Name";
            cboRiders.DataSource = _riders;
        }

        private void cboRiders_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Mediator.GetInstance().OnRaceChanged(this, (Rider)cboRiders.SelectedItem);
        }
    }
}
