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
    public interface IAddWay
    {
        string whereWay { get; }
        void ShowForm();
        void ClearFields();
        void CloseForm();
        event EventHandler TryToAddWay;
        event EventHandler Exit;
    }
    public partial class WayForm : Form, IAddWay
    {
       



        public WayForm()
        {
            InitializeComponent();
        }
        public string whereWay
        {
            get
            {
                return WayTextBox.Text;
            }
        }
        public event EventHandler? TryToAddWay;
        public event EventHandler? Exit;

        public void ClearFields()
        {
            WayTextBox.Text = "";
        }
        public void CloseForm()
        {
            this.Close();
        }

        public void ShowForm()
        {
            this.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (Exit != null) Exit(this, EventArgs.Empty);
           
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (TryToAddWay != null) 
                TryToAddWay(this, EventArgs.Empty);
        }

        
    }
}
