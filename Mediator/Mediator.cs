using System;

namespace Mediator
{
    public sealed class Mediator
    {
        private static readonly Mediator InstanceMediator = new Mediator();
        private Mediator() { }

        public static Mediator GetInstance()
        {
            return InstanceMediator;
        }

        //Instance functionality
        public event EventHandler<RiderChangedEventArgs> RiderChanged;

        public void OnRiderChanged(object sender, Model.Rider rider)
        {
            var riderChangedDelegate = RiderChanged as EventHandler<RiderChangedEventArgs>;
            if (riderChangedDelegate != null)
            {
                riderChangedDelegate(sender, new RiderChangedEventArgs() {Rider = rider});
            }
        }
    }
}