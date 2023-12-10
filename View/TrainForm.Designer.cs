namespace WinFormsApp1.View
{
    partial class TrainForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            trainsNameTextBox = new TextBox();
            trainsDOCTextBox = new TextBox();
            trainsTypeTextBox = new TextBox();
            BackTrainButton = new Button();
            SaveTrainButton = new Button();
            wayTrainComboBox = new ComboBox();
            departureTimePicker = new DateTimePicker();
            arrivalTimePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(178, 16);
            label1.Name = "label1";
            label1.Size = new Size(184, 25);
            label1.TabIndex = 0;
            label1.Text = "Добавление поезда";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 67);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 1;
            label2.Text = "Наименование";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 101);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 2;
            label3.Text = "Дни курсирования";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 136);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "Тип поезда";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 171);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 4;
            label5.Text = "Время прибытия";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 206);
            label6.Name = "label6";
            label6.Size = new Size(116, 15);
            label6.TabIndex = 5;
            label6.Text = "Время отправления";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 237);
            label7.Name = "label7";
            label7.Size = new Size(107, 15);
            label7.TabIndex = 6;
            label7.Text = "Пункт назначения";
            // 
            // trainsNameTextBox
            // 
            trainsNameTextBox.Location = new Point(179, 64);
            trainsNameTextBox.Margin = new Padding(3, 2, 3, 2);
            trainsNameTextBox.Name = "trainsNameTextBox";
            trainsNameTextBox.Size = new Size(193, 23);
            trainsNameTextBox.TabIndex = 7;
            // 
            // trainsDOCTextBox
            // 
            trainsDOCTextBox.Location = new Point(179, 99);
            trainsDOCTextBox.Margin = new Padding(3, 2, 3, 2);
            trainsDOCTextBox.Name = "trainsDOCTextBox";
            trainsDOCTextBox.Size = new Size(193, 23);
            trainsDOCTextBox.TabIndex = 8;
            // 
            // trainsTypeTextBox
            // 
            trainsTypeTextBox.Location = new Point(179, 134);
            trainsTypeTextBox.Margin = new Padding(3, 2, 3, 2);
            trainsTypeTextBox.Name = "trainsTypeTextBox";
            trainsTypeTextBox.Size = new Size(193, 23);
            trainsTypeTextBox.TabIndex = 9;
            // 
            // BackTrainButton
            // 
            BackTrainButton.Location = new Point(263, 277);
            BackTrainButton.Margin = new Padding(3, 2, 3, 2);
            BackTrainButton.Name = "BackTrainButton";
            BackTrainButton.Size = new Size(109, 30);
            BackTrainButton.TabIndex = 13;
            BackTrainButton.Text = "Назад";
            BackTrainButton.UseVisualStyleBackColor = true;
            BackTrainButton.Click += BackTrainButton_Click;
            // 
            // SaveTrainButton
            // 
            SaveTrainButton.Location = new Point(143, 277);
            SaveTrainButton.Margin = new Padding(3, 2, 3, 2);
            SaveTrainButton.Name = "SaveTrainButton";
            SaveTrainButton.Size = new Size(109, 30);
            SaveTrainButton.TabIndex = 14;
            SaveTrainButton.Text = "Добавить";
            SaveTrainButton.UseVisualStyleBackColor = true;
            SaveTrainButton.Click += SaveTrainButton_Click;
            // 
            // wayTrainComboBox
            // 
            wayTrainComboBox.FormattingEnabled = true;
            wayTrainComboBox.Location = new Point(179, 235);
            wayTrainComboBox.Margin = new Padding(3, 2, 3, 2);
            wayTrainComboBox.Name = "wayTrainComboBox";
            wayTrainComboBox.Size = new Size(193, 23);
            wayTrainComboBox.TabIndex = 15;
            wayTrainComboBox.SelectedIndexChanged += wayTrainComboBox_SelectedIndexChanged;
            // 
            // departureTimePicker
            // 
            departureTimePicker.Location = new Point(178, 167);
            departureTimePicker.Margin = new Padding(3, 2, 3, 2);
            departureTimePicker.Name = "departureTimePicker";
            departureTimePicker.Size = new Size(194, 23);
            departureTimePicker.TabIndex = 16;
            // 
            // arrivalTimePicker
            // 
            arrivalTimePicker.Location = new Point(178, 202);
            arrivalTimePicker.Margin = new Padding(3, 2, 3, 2);
            arrivalTimePicker.Name = "arrivalTimePicker";
            arrivalTimePicker.Size = new Size(194, 23);
            arrivalTimePicker.TabIndex = 17;
            // 
            // TrainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(457, 338);
            Controls.Add(arrivalTimePicker);
            Controls.Add(departureTimePicker);
            Controls.Add(wayTrainComboBox);
            Controls.Add(SaveTrainButton);
            Controls.Add(BackTrainButton);
            Controls.Add(trainsTypeTextBox);
            Controls.Add(trainsDOCTextBox);
            Controls.Add(trainsNameTextBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TrainForm";
            Text = "Добавление";
            FormClosing += TrainForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox trainsNameTextBox;
        private TextBox trainsDOCTextBox;
        private TextBox trainsTypeTextBox;
        private Button BackTrainButton;
        private Button SaveTrainButton;
        private ComboBox wayTrainComboBox;
        private DateTimePicker departureTimePicker;
        private DateTimePicker arrivalTimePicker;
    }
}