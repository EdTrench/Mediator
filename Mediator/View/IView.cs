using Mediator.Framework.UserControls;

namespace Mediator.View
{
    public interface IView
    {
        HostPanel HostPanel { get; set; }
        void SetPanel(HostPanel hostPanel);
    }
}
