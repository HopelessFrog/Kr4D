using Microsoft.EntityFrameworkCore.Storage;
using WinFormsApp1.View;

namespace Multiprocessor_And_Multithreaded_Programming.Presenter
{
    public interface IWayAddPresenter
    {
        public void Run();

        event EventHandler CloseForm;


    }
    public class AddWayPresenter : IWayAddPresenter
    {
        public event EventHandler? CloseForm;


        private readonly IMessageService MessageInt;
        private readonly IAddWay AddWayTrainsInt;
        private readonly IValidator ValidatorInt;

        public AddWayPresenter(IAddWay addWayTrains, IMessageService MessageInt, IValidator ValidatorInt)
        {
            AddWayTrainsInt = addWayTrains;
            this.MessageInt = MessageInt;
            this.ValidatorInt = ValidatorInt;

            addWayTrains.TryToAddWay += new EventHandler(WayTryToAdd);
            addWayTrains.Exit += new EventHandler(TryToExit);

        }

        public void Run()
        {
            AddWayTrainsInt.ShowForm();

        }
        private void WayTryToAdd(object? sender, EventArgs e)
        {

            AddWay();
        }
        public void AddWay()
        {
            string? whereWay = AddWayTrainsInt.whereWay;
            string erorrs = ValidatorInt.WayValidation(whereWay);
            if (erorrs != "")
            {
                AddWayTrainsInt.ClearFields();
                MessageInt.ShowError(erorrs);
                return;
            }
            erorrs = ValidatorInt.WayIsValidation(whereWay);
            if (erorrs != "")
            {
                AddWayTrainsInt.ClearFields();
                MessageInt.ShowError(erorrs);
                return;
            }
            DbManagement.AddWhereWay(whereWay);
            string message = "Пункт назначения успешно сохранен";
            MessageInt.ShowMessage(message);
            AddWayTrainsInt.ClearFields();



        }
        private void TryToExit(object? sender, EventArgs e)
        {

            Exit();
        }
        private void Exit()
        {
            if (AddWayTrainsInt.whereWay != "")
            {
                string message = "Остались введённые данные. Выйти?";
                DialogResult result = MessageInt.ShowExitMessage(message);
                if (result == DialogResult.OK)
                {
                    AddWayTrainsInt.CloseForm();
                    if (CloseForm != null) CloseForm(this, EventArgs.Empty);
                }

            }
            else
            {
                if (CloseForm != null) CloseForm(this, EventArgs.Empty);
                AddWayTrainsInt.CloseForm();
            }
        }



    }
}
