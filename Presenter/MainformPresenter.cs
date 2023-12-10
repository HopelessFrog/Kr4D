
using Multiprocessor_And_Multithreaded_Programming.Model;
using WinFormsApp1.View;
using WinFormsApp1.Properties;
using System;
using System.Windows.Forms;


namespace Multiprocessor_And_Multithreaded_Programming.Presenter
{
    public interface IMainFormPresenter
    {
        void Run();
        void ReloadData();
        event EventHandler OpenTrainAdd;
        event EventHandler<OpenTrainChangeEventArgs> OpenTrainChange;
    }
    public class OpenTrainChangeEventArgs : EventArgs
    {
        public readonly int id;


        public OpenTrainChangeEventArgs(int id)
        {
            this.id = id;

        }

    }
    public class MainformPresenter : IMainFormPresenter
    {


        public event EventHandler? OpenTrainAdd;
        public event EventHandler<OpenTrainChangeEventArgs>? OpenTrainChange;
        List<Trains> trains = new List<Trains>();
        List<Trains>? trainsSelectedList;
        private readonly IMain mainForm;
        private readonly IMessageService messageInt;
        private readonly IFileManager fileManagerInt;
        public MainformPresenter(IMain mainForm, IMessageService messageInt, IFileManager fileManagerInt)
        {
            this.mainForm = mainForm;
            this.messageInt = messageInt;
            this.fileManagerInt = fileManagerInt;
            mainForm.SaveData += new EventHandler(SaveData);
            mainForm.Selection += new EventHandler(MainFormSelection);
            mainForm.Reset += new EventHandler(Reset);
            mainForm.LoadData += new EventHandler(MainFormLoadData);
            mainForm.OpenForm += new EventHandler(Open);
            mainForm.OpenChangeForm += new EventHandler(MainFormChangeRun);
            mainForm.ShowMainForm += new EventHandler(MainFormShow);

            
        }
        private void MainFormShow(object? sender, EventArgs e)
        {
            if (Settings.Default.grettings)
            {
                messageInt.ShowMessage("Вербецкий 415 Контрольная работа №4 Вариант№3\n Задание: Программа хранящая список поездов");

            }
        }
        private void MainFormChangeRun(object? sender, EventArgs e)
        {
            if (OpenTrainChange != null) OpenTrainChange(this, new OpenTrainChangeEventArgs(mainForm.Id));

        }
        private void Reset(object? sender, EventArgs e)
        {
            mainForm.ResetSample();
            List<List<string?>> trainsList = GetStringTrainList(trains);
            mainForm.LoadDataTable(trainsList);
        }
        private void MainFormSelection(object? sender, EventArgs e)
        {
            mainForm.DataGridClear();
            if ((mainForm.selectectedType.ToString() == "") && mainForm.selectectedWay.ToString() == "-") { return; }
            else if (mainForm.selectectedType.ToString() == "")
            {
                trainsSelectedList = DbManagement.GetTrainsWayX(mainForm.selectectedWay.ToString()!);
            }
            else if (mainForm.selectectedWay.ToString() == "-")
            {

                trainsSelectedList = DbManagement.GetTrainsTypeX(mainForm.selectectedType.ToString()!);
            }
            else
            {
                trainsSelectedList = DbManagement.GetTrainsWayAndTypeX (mainForm.selectectedWay.ToString()!, mainForm.selectectedType.ToString()!);
            }
            List<List<string?>> trainList = GetStringTrainList(trainsSelectedList);
            mainForm.LoadDataTable(trainList);
        }

        private void SaveData(object? sender, EventArgs e)
        {
            if (mainForm.FilePath == "")
                return;
            try
            {
                fileManagerInt.ExportData(trains, mainForm.FilePath!);
            }
            catch (Exception)
            {

                messageInt.ShowError("Файл был закрыт до внесения изменений!");
            }


        }
        private void Open(object? sender, EventArgs e)
        {
            if (OpenTrainAdd != null) OpenTrainAdd(this, EventArgs.Empty);
        }
        private void MainFormLoadData(object? sender, EventArgs e)
        {

            LoadData();
        }
        private List<List<string?>> GetStringTrainList(List<Trains> trains)
        {
            List<List<string?>> trainList = new List<List<string?>>();
            foreach (Trains train in trains)
            {
                List<string?> trainData = new List<string?>

                {
                    train.Id.ToString(),
                    train.TrainsName,
                    train.TrainsDOC,
                   
                };
                trainData.Add(train.Arrival.ToString("D"));
                trainData.Add(train.Departure.ToString("D"));
                trainData.Add(train.TrainsType);
                trainData.Add(train.WhereWay!.WhereWay);
                trainList.Add(trainData);
            }
            return trainList;
        }

        public void Run()
        {

            mainForm.ShowForm();

        }

        public void LoadData()
        {
            ConectString.conectionString = Settings.Default.ConectionString;
            trains = DbManagement.GetTrainsList();
            List<WhereFromWay> ways = DbManagement.GetWayList();
            List<List<string?>> trainList = GetStringTrainList(trains);
            mainForm.LoadDataTable(trainList);
            mainForm.InsertWayComboBox(ways);
        }

        public void ReloadData()
        {
            mainForm.DataGridClear();
            mainForm.ComboboxClear();
            LoadData();
        }


    }
}
