using System.Collections.Generic;
using Mediator.Model;

namespace Mediator.View.RiderRaces
{
    interface IRiderRaces : IView
    {
        IEnumerable<Rider> Riders { set; }
        void ExitApplication();
    }
}