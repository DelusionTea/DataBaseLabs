namespace WinFormsApp
{
    partial class Form4
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
            printDialog1 = new PrintDialog();
            checkBox1 = new CheckBox();
            checkedListBox1 = new CheckedListBox();
            label1 = new Label();
            checkedListBox2 = new CheckedListBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(32, 41);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(86, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Все записи";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Фамилия", "Имя", "Отчество", "Пол", "Год рождения", "Оценка 1", "Оценка 2", "Оценка 3", "Оценка 4", "Средняя оценка", "Оплачено" });
            checkedListBox1.Location = new Point(34, 122);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 94);
            checkedListBox1.TabIndex = 1;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 99);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 2;
            label1.Text = "Поля для печати";
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "Фамилия", "Имя", "Отчество", "Кафедра", "Должность", "Предмет", "Занятость" });
            checkedListBox2.Location = new Point(220, 122);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(120, 94);
            checkedListBox2.TabIndex = 3;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(168, 41);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(78, 19);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "Студенты";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(292, 41);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(111, 19);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "Преподаватели";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(148, 274);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Печать";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 450);
            Controls.Add(button1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkedListBox2);
            Controls.Add(label1);
            Controls.Add(checkedListBox1);
            Controls.Add(checkBox1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PrintDialog printDialog1;
        private CheckBox checkBox1;
        private CheckedListBox checkedListBox1;
        private Label label1;
        private CheckedListBox checkedListBox2;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Button button1;
    }
}