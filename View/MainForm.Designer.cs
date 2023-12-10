namespace WinFormsApp1.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            trainsNameColumn = new DataGridViewTextBoxColumn();
            trainsDOCColumn = new DataGridViewTextBoxColumn();
            departureColumn = new DataGridViewTextBoxColumn();
            arrivalColumn = new DataGridViewTextBoxColumn();
            trainsTypeColumn = new DataGridViewTextBoxColumn();
            whereWayColumn = new DataGridViewTextBoxColumn();
            additionButton = new Button();
            saveButton = new Button();
            filtrationButton = new Button();
            label2 = new Label();
            resetButton = new Button();
            WayComboBox = new ComboBox();
            label1 = new Label();
            TypeTextBox = new TextBox();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, trainsNameColumn, trainsDOCColumn, departureColumn, arrivalColumn, trainsTypeColumn, whereWayColumn });
            dataGridView1.Location = new Point(10, 82);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(704, 200);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // id
            // 
            id.HeaderText = "Column1";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 125;
            // 
            // trainsNameColumn
            // 
            trainsNameColumn.HeaderText = "Наименование";
            trainsNameColumn.MinimumWidth = 6;
            trainsNameColumn.Name = "trainsNameColumn";
            trainsNameColumn.ReadOnly = true;
            trainsNameColumn.Width = 125;
            // 
            // trainsDOCColumn
            // 
            trainsDOCColumn.HeaderText = "Дни курсирования";
            trainsDOCColumn.MinimumWidth = 6;
            trainsDOCColumn.Name = "trainsDOCColumn";
            trainsDOCColumn.ReadOnly = true;
            trainsDOCColumn.Width = 125;
            // 
            // departureColumn
            // 
            departureColumn.HeaderText = "Прибытие";
            departureColumn.MinimumWidth = 6;
            departureColumn.Name = "departureColumn";
            departureColumn.ReadOnly = true;
            departureColumn.Width = 125;
            // 
            // arrivalColumn
            // 
            arrivalColumn.HeaderText = "Отправление";
            arrivalColumn.MinimumWidth = 6;
            arrivalColumn.Name = "arrivalColumn";
            arrivalColumn.ReadOnly = true;
            arrivalColumn.Width = 125;
            // 
            // trainsTypeColumn
            // 
            trainsTypeColumn.HeaderText = "Тип поезда";
            trainsTypeColumn.MinimumWidth = 6;
            trainsTypeColumn.Name = "trainsTypeColumn";
            trainsTypeColumn.ReadOnly = true;
            trainsTypeColumn.Width = 125;
            // 
            // whereWayColumn
            // 
            whereWayColumn.HeaderText = "Пункт назначения";
            whereWayColumn.MinimumWidth = 6;
            whereWayColumn.Name = "whereWayColumn";
            whereWayColumn.ReadOnly = true;
            whereWayColumn.Width = 125;
            // 
            // additionButton
            // 
            additionButton.Location = new Point(494, 317);
            additionButton.Margin = new Padding(3, 2, 3, 2);
            additionButton.Name = "additionButton";
            additionButton.Size = new Size(197, 40);
            additionButton.TabIndex = 1;
            additionButton.Text = "Добавить поезд";
            additionButton.UseVisualStyleBackColor = true;
            additionButton.Click += additionButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(551, 12);
            saveButton.Margin = new Padding(3, 2, 3, 2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(140, 28);
            saveButton.TabIndex = 2;
            saveButton.Text = "Сохранение";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // filtrationButton
            // 
            filtrationButton.Location = new Point(31, 9);
            filtrationButton.Margin = new Padding(3, 2, 3, 2);
            filtrationButton.Name = "filtrationButton";
            filtrationButton.Size = new Size(125, 31);
            filtrationButton.TabIndex = 3;
            filtrationButton.Text = "Фильтрация";
            filtrationButton.UseVisualStyleBackColor = true;
            filtrationButton.Click += filtrationButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 44);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 5;
            label2.Text = "Пункт назначения";
            // 
            // resetButton
            // 
            resetButton.Location = new Point(31, 44);
            resetButton.Margin = new Padding(3, 2, 3, 2);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(125, 31);
            resetButton.TabIndex = 8;
            resetButton.Text = "Сброс";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // WayComboBox
            // 
            WayComboBox.FormattingEnabled = true;
            WayComboBox.Items.AddRange(new object[] { "-" });
            WayComboBox.Location = new Point(316, 44);
            WayComboBox.Margin = new Padding(3, 2, 3, 2);
            WayComboBox.Name = "WayComboBox";
            WayComboBox.Size = new Size(174, 23);
            WayComboBox.TabIndex = 10;
           
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(192, 14);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 4;
            label1.Text = "Тип поезда";
            // 
            // TypeTextBox
            // 
            TypeTextBox.Location = new Point(316, 14);
            TypeTextBox.Margin = new Padding(3, 2, 3, 2);
            TypeTextBox.Name = "TypeTextBox";
            TypeTextBox.Size = new Size(174, 23);
            TypeTextBox.TabIndex = 12;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Snow;
            checkBox1.Location = new Point(563, 51);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(96, 19);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Приветствие";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(725, 385);
            Controls.Add(checkBox1);
            Controls.Add(TypeTextBox);
            Controls.Add(WayComboBox);
            Controls.Add(resetButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(filtrationButton);
            Controls.Add(saveButton);
            Controls.Add(additionButton);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Поезда";
            Load += MainForm_Load_1;
            Shown += MainForm_Shown;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn trainsNameColumn;
        private DataGridViewTextBoxColumn trainsDOCColumn;
        private DataGridViewTextBoxColumn departureColumn;
        private DataGridViewTextBoxColumn arrivalColumn;
        private DataGridViewTextBoxColumn trainsTypeColumn;
        private DataGridViewTextBoxColumn whereWayColumn;
        private Button additionButton;
        private Button saveButton;
        private Button filtrationButton;
        private Label label2;
        private Button resetButton;
        private ComboBox WayComboBox;
        private Label label1;
        private TextBox TypeTextBox;
        private CheckBox checkBox1;
    }
}