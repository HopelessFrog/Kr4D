namespace WinFormsApp1.View
{
    partial class WayForm
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
            BackButton = new Button();
            CreateButton = new Button();
            WayTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Location = new Point(65, 225);
            BackButton.Margin = new Padding(3, 2, 3, 2);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(125, 34);
            BackButton.TabIndex = 0;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(210, 225);
            CreateButton.Margin = new Padding(3, 2, 3, 2);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(130, 34);
            CreateButton.TabIndex = 1;
            CreateButton.Text = "Создать";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // WayTextBox
            // 
            WayTextBox.Location = new Point(65, 81);
            WayTextBox.Margin = new Padding(3, 2, 3, 2);
            WayTextBox.Name = "WayTextBox";
            WayTextBox.Size = new Size(275, 23);
            WayTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(79, 23);
            label1.Name = "label1";
            label1.Size = new Size(243, 25);
            label1.TabIndex = 3;
            label1.Text = "Введите пункт назначения";
            // 
            // WayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(391, 338);
            Controls.Add(label1);
            Controls.Add(WayTextBox);
            Controls.Add(CreateButton);
            Controls.Add(BackButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "WayForm";
            Text = "Пункт назначения";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private Button CreateButton;
        private TextBox WayTextBox;
        private Label label1;
    }
}