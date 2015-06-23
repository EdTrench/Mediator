using System.Collections.Generic;

namespace Mediator.Presenter
{
    class ViewListPopulator
    {
        private readonly View.RiderRaces.IRiderRaces _view;
        private readonly IEnumerable<Model.Rider> _riders;

        public ViewListPopulator(View.RiderRaces.IRiderRaces view,
            IEnumerable<Model.Rider> riders)
        {
            _view = view;
            _riders = riders;
        }

        public void Populate()
        {
            _view.Riders = _riders;
        }
    }
}