namespace WinFormsApp
{
    partial class Form3
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
            students = new RadioButton();
            techers = new RadioButton();
            radioButton1 = new RadioButton();
            dataGridView1 = new DataGridView();
            listBox1 = new ListBox();
            maskedTextBox1 = new MaskedTextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // students
            // 
            students.AutoSize = true;
            students.Location = new Point(162, 30);
            students.Name = "students";
            students.Size = new Size(77, 19);
            students.TabIndex = 0;
            students.Text = "Студенты";
            students.UseVisualStyleBackColor = true;
            students.CheckedChanged += students_CheckedChanged;
            // 
            // techers
            // 
            techers.AutoSize = true;
            techers.Location = new Point(286, 30);
            techers.Name = "techers";
            techers.Size = new Size(111, 19);
            techers.TabIndex = 1;
            techers.Text = "Преподователи";
            techers.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(34, 30);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(85, 19);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Все записи";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(148, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(484, 279);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Фамилия", "Год Рождения", "Средняя оценка", "Должность", "Занятость" });
            listBox1.Location = new Point(655, 46);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 6;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(652, 168);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(655, 143);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 8;
            label1.Text = "Поиск";
            // 
            // button1
            // 
            button1.Location = new Point(655, 197);
            button1.Name = "button1";
            button1.Size = new Size(55, 23);
            button1.TabIndex = 9;
            button1.Text = "Искать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(655, 19);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 10;
            label2.Text = "Сортировка";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(maskedTextBox1);
            Controls.Add(listBox1);
            Controls.Add(dataGridView1);
            Controls.Add(radioButton1);
            Controls.Add(techers);
            Controls.Add(students);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton students;
        private RadioButton techers;
        private RadioButton radioButton1;
        private DataGridView dataGridView1;
        private ListBox listBox1;
        private MaskedTextBox maskedTextBox1;
        private Label label1;
        private Button button1;
        private Label label2;
    }
}