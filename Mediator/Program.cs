using Mediator.View.BaseForms;
using System;
using System.Windows.Forms;

namespace Mediator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var session = Data.Helper.OpenSession();
            var presenter = new Presenter.RiderRaces(session, session.Get<Model.Rider>(1), new BaseForm());
            var startService = new Service.Start(presenter);
            //presenter.ExitApplication += delegate
            //{
            //    Application.ExitThread();
            //};
            Application.Run(startService);
        }
    }
}
