using WinFormsApp1.View;
namespace Multiprocessor_And_Multithreaded_Programming.Presenter
{
    public interface ITrainAddPresenter //интерфейс добавления 
    {
        public void Run();
        public void ReloadWayBox();

        event EventHandler CloseForm;

        event EventHandler OpenWayAdd;
    }
    public class TrainAddPresenter : ITrainAddPresenter
    {
        public event EventHandler? CloseForm;
        public event EventHandler? OpenWayAdd;

        private readonly ITrainAdd TrainAddInt;
        private readonly IMessageService MessageInt;
        private readonly IValidator validatorInt;


        public TrainAddPresenter(ITrainAdd TrainAddInt, IMessageService MessageInt, IValidator validatorInt)
        {
            this.TrainAddInt = TrainAddInt;
            this.MessageInt = MessageInt;
            this.validatorInt = validatorInt;

            TrainAddInt.TryToAdd += new EventHandler(TryTrainAdd);
            TrainAddInt.Exit += new EventHandler(TryToExit);
            TrainAddInt.OpenForm += new EventHandler(OpenWayAddForm);


        }

        public void ReloadWayBox()
        {
            TrainAddInt.ClearComboBox();
            LoadData();
        }
        public void OpenWayAddForm(object? sender, EventArgs e)
        {
            if (OpenWayAdd != null) OpenWayAdd(this, EventArgs.Empty);
        }

        private void TryToExit(object? sender, EventArgs e)
        {
            Exit();
        }

        public void Run()//вывод всех 
        {
            LoadData();
            TrainAddInt.ShowForm();
        }

        public void LoadData() //загрузка данных
        {

            List<WhereFromWay> ways = DbManagement.GetWayList();

            TrainAddInt.InsertWayComboBox(ways);
        }
        private void Exit()
        {
            if (TrainAddInt.trainsName != "" || TrainAddInt.trainsDOC != "" ||  TrainAddInt.whereWay != null)
            {
                string message = "Остались введённые данные. Выйти?";
                DialogResult result = MessageInt.ShowExitMessage(message);
                if (result == DialogResult.Yes)
                {
                    if (CloseForm != null) CloseForm(this, EventArgs.Empty);
                    TrainAddInt.CloseForm();
                }
            }
            else
            {
                if (CloseForm != null) CloseForm(this, EventArgs.Empty);
                TrainAddInt.CloseForm();
            }
        }

        private void TryTrainAdd(object? sender, EventArgs e)
        {
            string erorrs = validatorInt.TrainAddPreValidation(TrainAddInt.trainsName, TrainAddInt.trainsDOC);
            if (erorrs != "")
            {
                MessageInt.ShowError(erorrs);
                return;
            }
            Trains train = new(TrainAddInt.trainsName, TrainAddInt.trainsDOC, TrainAddInt.departure, TrainAddInt.arrival, TrainAddInt.trainsType);
            erorrs = validatorInt.WayValidation(TrainAddInt.whereWay);
            if (erorrs != "")
            {
                MessageInt.ShowError(erorrs);
                return;
            }
            DbManagement.AddWayToTrain(train, TrainAddInt.whereWay.ToString()!);
            string message = "Поезд успешно добавлен!";
            MessageInt.ShowMessage(message);
            TrainAddInt.ClearFields();
            

        }
    }
}
