using Autofac;
using Multiprocessor_And_Multithreaded_Programming.Presenter;
using WinFormsApp1.View;


namespace Multiprocessor_And_Multithreaded_Programming.Presenter
{
    public class MainPresenter
    {
        private IChangePresenter changePresenter;
        private IMainFormPresenter mainFormPresenter;
        private ITrainAddPresenter trainAddPresenter;
        private IWayAddPresenter wayAddPresenter;
        private object? LastSender;
        public MainPresenter(IChangePresenter changePresenter, IMainFormPresenter mainFormPresenter,
            ITrainAddPresenter trainAddPresenter, IWayAddPresenter wayAddPresenter)
        {
            this.changePresenter = changePresenter;
            this.mainFormPresenter = mainFormPresenter;
            this.trainAddPresenter = trainAddPresenter;
            this.wayAddPresenter = wayAddPresenter;

            wayAddPresenter.CloseForm += new EventHandler(ReloadWayData);

            changePresenter.OpenWayAdd += new EventHandler(OpenWayAddForm);
            changePresenter.CloseForm += new EventHandler(ReloadData);

            trainAddPresenter.OpenWayAdd += new EventHandler(OpenWayAddForm);
            trainAddPresenter.CloseForm += new EventHandler(ReloadData);

            mainFormPresenter.OpenTrainAdd += new EventHandler(OpenTrainAddForm);
            mainFormPresenter.OpenTrainChange += new EventHandler<OpenTrainChangeEventArgs>(OpenChangeForm);
        }

        public void ReloadWayData(object? sender, EventArgs e)
        {
            if (LastSender!.GetType() == changePresenter.GetType())
            {
                changePresenter.ReloadWayBox();
            }
            else if (LastSender!.GetType() == trainAddPresenter.GetType()) 
            {
                trainAddPresenter.ReloadWayBox();
            }

        }

        public void ReloadData(object? sender, EventArgs e)
        {

            mainFormPresenter.ReloadData();
        }

        public void OpenMainForm()
        {
            mainFormPresenter.Run();
        }

        public void OpenTrainAddForm(object? sender, EventArgs e)
        {
            var scope = AutofacManager.Container!.BeginLifetimeScope();
            var tmp_resenter = scope.Resolve<ITrainAddPresenter>();
            trainAddPresenter = tmp_resenter;
            trainAddPresenter.OpenWayAdd += new EventHandler(OpenWayAddForm);
            trainAddPresenter.CloseForm += new EventHandler(ReloadData);
            trainAddPresenter.Run();

        }

        public void OpenChangeForm(object? sender, OpenTrainChangeEventArgs e)
        {
            var scope1 = AutofacManager.Container!.BeginLifetimeScope();
            var tmp_resenter = scope1.Resolve<IChangePresenter>();
            changePresenter = tmp_resenter;
            changePresenter.OpenWayAdd += new EventHandler(OpenWayAddForm);
            changePresenter.CloseForm += new EventHandler(ReloadData);
            changePresenter.Run(e.id);


        }

        public void OpenWayAddForm(object? sender, EventArgs e)
        {
            LastSender = sender;
            var scope2 = AutofacManager.Container!.BeginLifetimeScope();
            var tmp_resenter = scope2.Resolve<IWayAddPresenter>();
            wayAddPresenter = tmp_resenter;
            wayAddPresenter.CloseForm += new EventHandler(ReloadWayData);
            wayAddPresenter.Run();

        }

    }
}


