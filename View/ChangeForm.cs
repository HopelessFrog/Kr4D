using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Multiprocessor_And_Multithreaded_Programming;

namespace WinFormsApp1.View
{
    public interface ITrainChange
    {
        string trainsName { get; set; }
        string trainsDOC { get; set; }
        DateTime departure { get; set; }
        object whereWay { get; set; }
        string trainsType { get; set; }
        DateTime arrival { get; set; }
        void InsertWayComboBox(List<WhereFromWay> way);
        void SelectWayComboBox(WhereFromWay way);
        void ClearFields();
        void ClearComboBox();
        void ShowForm();
        void CloseForm();

        event EventHandler TryToChange;
        event EventHandler TryToDelete;
        event EventHandler OpenWayForm;

    }

    public partial class ChangeForm : Form, ITrainChange
    {
        public ChangeForm()
        {
            InitializeComponent();
        }

        public string trainsName
        {
            get
            {
                return trainsNameTextBox.Text;
            }
            set
            {
                trainsNameTextBox.Text = value;
                this.Refresh();
            }
        }

        public string trainsDOC
        {
            get
            {
                return trainsDOCTextBox.Text;
            }
            set
            {
                trainsDOCTextBox.Text = value;
                this.Refresh();
            }
        }

        public string trainsType
        {
            get
            {
                return typeTrainTextBox.Text;
            }
            set
            {
                typeTrainTextBox.Text = value;
                this.Refresh();
            }
        }

        public DateTime departure
        {
            get
            {
                return departureTimePicker.Value;
            }
            set
            {
                departureTimePicker.Value = value;
                this.Refresh();
            }
        }

        public DateTime arrival
        {
            get
            {
                return arrivalTimePicker.Value;
            }
            set
            {
                arrivalTimePicker.Value = value;
                this.Refresh();
            }
        }

        public object whereWay
        {
            get
            {
                return WayComboBox.SelectedItem;
            }
            set
            {
                foreach (var way in WayComboBox.Items)
                {
                    if (way.Equals(value))
                    {
                        WayComboBox.SelectedItem = way;
                        break;
                    }
                }
                this.Refresh();
            }
        }
        public event EventHandler? TryToChange;
        public event EventHandler? TryToDelete;
        public event EventHandler? OpenWayForm;

        public void ClearComboBox()
        {
            WayComboBox.Items.Clear();
            WayComboBox.Refresh();
        }

        public void ClearFields()
        {
            trainsNameTextBox.Text = "";
            trainsNameTextBox.Refresh();
            trainsDOCTextBox.Text = "";
            trainsDOCTextBox.Refresh();
            typeTrainTextBox.Text = "";
            typeTrainTextBox.Refresh();

        }

        public void CloseForm()
        {
            this.Close();
        }

        public void InsertWayComboBox(List<WhereFromWay> way)
        {
            WayComboBox.Items.Add("Добавление пункта назначения");
            foreach (var item in way)
            {

                WayComboBox.Items.Add(item.WhereWay);
            }
        }

        public void SelectWayComboBox(WhereFromWay way)
        {
            for (int i = 0; i < WayComboBox.Items.Count; i++)
            {
                if (WayComboBox.Items[i].ToString() == way.WhereWay)
                {
                    WayComboBox.SelectedIndex = i; break;
                }
            }

        }

        public void ShowForm()
        {
            this.ShowDialog();
        }

        private void WayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WayComboBox.SelectedItem.ToString() == "Добавление пункта назначения")
            {
                if (OpenWayForm != null) OpenWayForm(this, EventArgs.Empty);
                WayComboBox.ResetText();//TO DO(Постановка пустой строки)
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (TryToDelete != null) TryToDelete(this, EventArgs.Empty);
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if(TryToChange!=null) TryToChange(this, EventArgs.Empty);
        }
    }
}
