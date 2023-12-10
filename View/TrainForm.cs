using Multiprocessor_And_Multithreaded_Programming;
using System.Windows.Forms;

namespace WinFormsApp1.View
{
    public interface ITrainAdd
    {
        string trainsName { get; }
        string trainsDOC { get; }
        string trainsType { get; }
        object whereWay { get; }
        DateTime departure { get; }
        DateTime arrival { get; }
        void InsertWayComboBox(List<WhereFromWay> way);

        void ClearFields();
        void ClearComboBox();
        void ShowForm();
        void CloseForm();
        event EventHandler TryToAdd;
        event EventHandler Exit;
        event EventHandler OpenForm;
        

    }
    public partial class TrainForm : Form, ITrainAdd
    {
        private bool closeName = true;
        const string A = "-Добавить пункт-";
        public TrainForm()
        {
            InitializeComponent();
        }

        public void InsertWayComboBox(List<WhereFromWay> way)
        {
            wayTrainComboBox.Items.Add(A);
            foreach (var item in way)
            {

                wayTrainComboBox.Items.Add(item.WhereWay);
            }
        }

        public string trainsName => trainsNameTextBox.Text;

        public string trainsDOC => trainsDOCTextBox.Text;

        public string trainsType => trainsTypeTextBox.Text;
        public object whereWay => wayTrainComboBox.SelectedItem;

        public DateTime departure => departureTimePicker.Value;

        public DateTime arrival => arrivalTimePicker.Value;

        public event EventHandler? TryToAdd;
        public event EventHandler? OpenForm;
        public event EventHandler? Exit;
        


        private void wayTrainComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(wayTrainComboBox.SelectedIndex == -1) 
                return;
            if (wayTrainComboBox.SelectedItem.ToString() == A)
            {

                if (OpenForm != null) OpenForm(this, EventArgs.Empty);
                wayTrainComboBox.ResetText();

            }
        }

       

        private void BackTrainButton_Click(object sender, EventArgs e)
        {
            if (Exit != null) Exit(this, EventArgs.Empty);
        }

        private void SaveTrainButton_Click(object sender, EventArgs e)
        {
            if (TryToAdd != null) 
                TryToAdd(this, EventArgs.Empty);

        }
        public void ShowForm()
        {
            this.Show();
        }

        public void ClearFields()
        {
            trainsNameTextBox.Text = "";
            trainsNameTextBox.Refresh();
            trainsDOCTextBox.Text = "";
            trainsDOCTextBox.Refresh();
            trainsTypeTextBox.Text = "";
            trainsTypeTextBox.Refresh();
            departureTimePicker.Value = DateTime.Now;
            departureTimePicker.Refresh();
            arrivalTimePicker.Value = DateTime.Now;
            arrivalTimePicker.Refresh();
            wayTrainComboBox.SelectedIndex = -1;
          

        }

        public void CloseForm()
        {
            closeName = false;
            this.Close();

        }

        public void ClearComboBox()
        {
            wayTrainComboBox.Items.Clear();
            wayTrainComboBox.Refresh();
        }

        private void TrainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing && closeName)
            {
                if (Exit != null) Exit(this, EventArgs.Empty);
            }

        }
    }
}
