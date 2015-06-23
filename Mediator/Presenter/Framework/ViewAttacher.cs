using Mediator.Framework.UserControls;
using Mediator.View;

namespace Mediator.Presenter.Framework
{
    class ViewAttacher
    {
        public void Attach(IView view, HostPanel hostPanel)
        {
            view.SetPanel(hostPanel);
        }
    }
}
