using System;
using System.Windows.Forms;

namespace Mediator.Framework.UserControls
{
    public class HostPanel : Panel
    {
        public event EventHandler ParentClosing;

        private Form _parentForm;

        public void Initialise()
        {
            _parentForm = this.FindForm();
            _parentForm.FormClosing += FormClosing;
        }

        private void FormClosing(Object sender, FormClosingEventArgs e)
        {
            var del = ParentClosing;
            if (del != null)
            {
                del(this, EventArgs.Empty);
            }
        }
    }
}