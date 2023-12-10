using Autofac;
using Multiprocessor_And_Multithreaded_Programming;
using Multiprocessor_And_Multithreaded_Programming.Presenter;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            AutofacManager.RegisterDependencies();
            using (var scope = AutofacManager.Container!.BeginLifetimeScope())
            {
                var mainPresenter = scope.Resolve<MainPresenter>();
                mainPresenter.OpenMainForm();
            }
        }
    }
}