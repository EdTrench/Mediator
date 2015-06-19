using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class RiderChangedEventArgs : EventArgs
    {
        public Model.Rider Rider { get; set; }
    }
}