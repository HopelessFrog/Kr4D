

using System.Drawing;
using WinFormsApp1.View;

namespace Multiprocessor_And_Multithreaded_Programming.Presenter
{
    public interface IChangePresenter
    {
        public void Run(int id);
        public void ReloadWayBox();
        event EventHandler CloseForm;
        event EventHandler OpenWayAdd;
    }
    public class TrainChangePresenter : IChangePresenter
    {
        public event EventHandler? CloseForm;
        public event EventHandler? OpenWayAdd;

        private readonly IMessageService MessageInt;
        private readonly IValidator ValidatorInt;
        private readonly ITrainChange TrainChange;
        int tmp_id;
        public TrainChangePresenter(ITrainChange TrainChange, IMessageService MessageInt, IValidator validatorInt)
        {
            this.TrainChange = TrainChange;
            this.MessageInt = MessageInt;
            ValidatorInt = validatorInt;
            TrainChange.OpenWayForm += new EventHandler(OpenWayForm);
            TrainChange.TryToChange += new EventHandler(TryTrainChange);
            TrainChange.TryToDelete += new EventHandler(TryTrainDelete);


        }
        public void ReloadWayBox()
        {
            TrainChange.ClearComboBox();
            LoadData();
        }

        public void OpenWayForm(object? sender, EventArgs e)
        {
            if (OpenWayAdd != null) OpenWayAdd(this, EventArgs.Empty);
        }
        public void Run(int id)
        {
            tmp_id = id;
            LoadData();
            TrainChange.ShowForm();
        }
        public void LoadData()
        {
            var train = DbManagement.GetTrain(tmp_id);
            TrainChange.trainsName = train!.TrainsName!;
            TrainChange.trainsDOC = train!.TrainsDOC!;
            TrainChange.trainsType = train!.TrainsType!;
            List<WhereFromWay> ways = DbManagement.GetWayList();
            TrainChange.InsertWayComboBox(ways);
            
            TrainChange.SelectWayComboBox(train.WhereWay!);
            TrainChange.whereWay = train.WhereWay!;
            TrainChange.departure = train!.Departure;
            TrainChange.arrival = train!.Arrival;
        }

        private void TryTrainChange(object? sender, EventArgs e)
        {
            string erorrs = ValidatorInt.TrainAddPreValidation(TrainChange.trainsName, TrainChange.trainsDOC);
            if (erorrs != "")
            {
                MessageInt.ShowError(erorrs);
                return;
            }
            Trains newTrain = new(TrainChange.trainsName, TrainChange.trainsDOC, TrainChange.departure, TrainChange.arrival, TrainChange.trainsType);
            if (erorrs != "")
            {
                MessageInt.ShowError(erorrs);
                return;
            }
            var train = DbManagement.GetTrain(tmp_id);
            DbManagement.ChangeTrains(train!, TrainChange.whereWay.ToString()!, newTrain);
            string message = "Данные изменены!";
            MessageInt.ShowMessage(message);
            TrainChange.ClearFields();
            if (CloseForm != null) CloseForm(this, EventArgs.Empty);
            TrainChange.CloseForm();

        }
        private void TryTrainDelete(object? sender, EventArgs e)
        {
            var student = DbManagement.GetTrain(tmp_id);
            DbManagement.DeleteTrain(student!);
            string message = "Поезд успешно удалён!";
            MessageInt.ShowMessage(message);
            TrainChange.ClearFields();
            if (CloseForm != null) CloseForm(this, EventArgs.Empty);
            TrainChange.CloseForm();
        }


    }
}
