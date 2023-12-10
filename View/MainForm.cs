using Multiprocessor_And_Multithreaded_Programming;
using WinFormsApp1.Properties;

namespace WinFormsApp1.View
{
    public interface IMain
    {
        public int Id { get; }
        
        public object selectectedType { get; }
        public object selectectedWay { get; }
        string? FilePath { get; }
        public void InsertWayComboBox(List<WhereFromWay> way);
        public void DataGridClear();
        void ComboboxClear();
        public void ResetSample();
        public void ShowForm();
        public void LoadDataTable(List<List<string?>> trainsList);
        event EventHandler LoadData;
        event EventHandler Selection;
        event EventHandler Reset;
        event EventHandler SaveData;
        event EventHandler OpenForm;
        event EventHandler OpenChangeForm;
        event EventHandler ShowMainForm;
    }
    public partial class MainForm : Form, IMain
    {
        public int tmp_id;
        public void ShowForm()
        {
            Application.Run(this);
        }

        public object selectectedWay
        {
            get
            {
                return WayComboBox.Text;
            }
        }

        public string? FilePath
        {
            get;
            private set;
        }

        public object selectectedType
        {
            get
            {
                return TypeTextBox.Text;
            }
        }
        public int Id
        {
            get
            {
                return tmp_id!;
            }
        }


        public MainForm()
        {
            InitializeComponent();
            WayComboBox.SelectedItem = "-";


        }

        public event EventHandler? LoadData;
        public event EventHandler? Selection;
        public event EventHandler? OpenForm;
        public event EventHandler? ShowMainForm;
        public event EventHandler? Reset;
        public event EventHandler? SaveData;
        public event EventHandler? OpenChangeForm;

        public void InsertWayComboBox(List<WhereFromWay> way)
        {
            foreach (var item in way)
            {
                WayComboBox.Items.Add(item.WhereWay);
            }
        }


        public void LoadDataTable(List<List<string?>> trainsList)
        {
            foreach (var train in trainsList)
            {
                dataGridView1.Rows.Add(train.ToArray());
            }
        }

        public void DataGridClear()
        {
            dataGridView1.Rows.Clear();
        }
        public void ComboboxClear()
        {
            dataGridView1.Rows.Clear();
            WayComboBox.Items.Clear();
            WayComboBox.Refresh();
        }


        private void filtrationButton_Click(object sender, EventArgs e)
        {
            if (Selection != null) Selection(this, EventArgs.Empty);
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            if (OpenForm != null) OpenForm(this, EventArgs.Empty);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (Reset != null) Reset(this, EventArgs.Empty);
        }
        public void ResetSample()
        {
            dataGridView1.Rows.Clear();
            WayComboBox.SelectedItem = "-";
            TypeTextBox.Text = "";
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string? trainId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tmp_id = Int32.Parse(trainId!);
            if (OpenChangeForm != null) OpenChangeForm(this, EventArgs.Empty);

        }
        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (ShowMainForm != null) ShowMainForm(this, EventArgs.Empty);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.OverwritePrompt = true;
            dialog.Filter = "Xlsx|*.xlsx";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = dialog.FileName;
            }
            else
            {
                FilePath = "";
            }
            if (SaveData != null) SaveData(this, EventArgs.Empty);
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            WayComboBox.SelectedValue = 0;

            if (LoadData != null) LoadData(this, EventArgs.Empty);
            if (Settings.Default.grettings)
            { checkBox1.Checked = true; }
            else { checkBox1.Checked = false; }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            { Settings.Default.grettings = true; }
            else { Settings.Default.grettings = false; }
            Settings.Default.Save();
        }

        
    }
}
