namespace WinFormsApp1.View
{
    partial class ChangeForm
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
            DeleteButton = new Button();
            ChangeButton = new Button();
            trainsNameTextBox = new TextBox();
            trainsDOCTextBox = new TextBox();
            typeTrainTextBox = new TextBox();
            WayComboBox = new ComboBox();
            departureTimePicker = new DateTimePicker();
            arrivalTimePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(256, 31);
            label1.Name = "label1";
            label1.Size = new Size(175, 25);
            label1.TabIndex = 0;
            label1.Text = "Изменение поезда";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 68);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 1;
            label2.Text = "Наименование";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 96);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 2;
            label3.Text = "Дни курсирования";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 128);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "Тип поезда";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 156);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 4;
            label5.Text = "Время прибытия";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(93, 186);
            label6.Name = "label6";
            label6.Size = new Size(116, 15);
            label6.TabIndex = 5;
            label6.Text = "Время отправления";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(93, 214);
            label7.Name = "label7";
            label7.Size = new Size(107, 15);
            label7.TabIndex = 6;
            label7.Text = "Пункт назначения";
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(54, 266);
            DeleteButton.Margin = new Padding(3, 2, 3, 2);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(116, 38);
            DeleteButton.TabIndex = 7;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += button1_Click;
            // 
            // ChangeButton
            // 
            ChangeButton.Location = new Point(495, 266);
            ChangeButton.Margin = new Padding(3, 2, 3, 2);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(125, 38);
            ChangeButton.TabIndex = 8;
            ChangeButton.Text = "Изменить";
            ChangeButton.UseVisualStyleBackColor = true;
            ChangeButton.Click += ChangeButton_Click;
            // 
            // trainsNameTextBox
            // 
            trainsNameTextBox.Location = new Point(256, 66);
            trainsNameTextBox.Margin = new Padding(3, 2, 3, 2);
            trainsNameTextBox.Name = "trainsNameTextBox";
            trainsNameTextBox.Size = new Size(256, 23);
            trainsNameTextBox.TabIndex = 9;
            // 
            // trainsDOCTextBox
            // 
            trainsDOCTextBox.Location = new Point(256, 94);
            trainsDOCTextBox.Margin = new Padding(3, 2, 3, 2);
            trainsDOCTextBox.Name = "trainsDOCTextBox";
            trainsDOCTextBox.Size = new Size(256, 23);
            trainsDOCTextBox.TabIndex = 10;
            // 
            // typeTrainTextBox
            // 
            typeTrainTextBox.Location = new Point(256, 125);
            typeTrainTextBox.Margin = new Padding(3, 2, 3, 2);
            typeTrainTextBox.Name = "typeTrainTextBox";
            typeTrainTextBox.Size = new Size(256, 23);
            typeTrainTextBox.TabIndex = 11;
            // 
            // WayComboBox
            // 
            WayComboBox.FormattingEnabled = true;
            WayComboBox.Location = new Point(256, 212);
            WayComboBox.Margin = new Padding(3, 2, 3, 2);
            WayComboBox.Name = "WayComboBox";
            WayComboBox.Size = new Size(256, 23);
            WayComboBox.TabIndex = 14;
            WayComboBox.SelectedIndexChanged += WayComboBox_SelectedIndexChanged;
            // 
            // departureTimePicker
            // 
            departureTimePicker.Location = new Point(256, 152);
            departureTimePicker.Margin = new Padding(3, 2, 3, 2);
            departureTimePicker.Name = "departureTimePicker";
            departureTimePicker.Size = new Size(256, 23);
            departureTimePicker.TabIndex = 15;
            // 
            // arrivalTimePicker
            // 
            arrivalTimePicker.Location = new Point(256, 182);
            arrivalTimePicker.Margin = new Padding(3, 2, 3, 2);
            arrivalTimePicker.Name = "arrivalTimePicker";
            arrivalTimePicker.Size = new Size(256, 23);
            arrivalTimePicker.TabIndex = 16;
            // 
            // ChangeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(700, 338);
            Controls.Add(arrivalTimePicker);
            Controls.Add(departureTimePicker);
            Controls.Add(WayComboBox);
            Controls.Add(typeTrainTextBox);
            Controls.Add(trainsDOCTextBox);
            Controls.Add(trainsNameTextBox);
            Controls.Add(ChangeButton);
            Controls.Add(DeleteButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ChangeForm";
            Text = "Редактирование";
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
        private Button DeleteButton;
        private Button ChangeButton;
        private TextBox trainsNameTextBox;
        private TextBox trainsDOCTextBox;
        private TextBox typeTrainTextBox;
        private ComboBox WayComboBox;
        private DateTimePicker departureTimePicker;
        private DateTimePicker arrivalTimePicker;
    }
}