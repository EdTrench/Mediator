using System;
using System.Windows.Forms;
using Mediator.Presenter;

namespace Mediator.Service
{
    class Start : ApplicationContext
    {
        public Start(RiderRaces riderRaces)
        {
            riderRaces.Show();
        }
    }
}