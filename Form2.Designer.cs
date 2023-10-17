namespace WinFormsApp
{
    partial class Form2
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

        private RadioButton GetAll()
        {
            return all;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            students = new RadioButton();
            teachers = new RadioButton();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            add = new Button();
            edit = new Button();
            maskedTextBoxLastName = new MaskedTextBox();
            maskedTextBoxFirstName = new MaskedTextBox();
            maskedTextBoxMiddleName = new MaskedTextBox();
            maskedTextBoxYearOrKaff = new MaskedTextBox();
            LastNameLabel = new Label();
            FirstNameLabel = new Label();
            MiddleNameLabel = new Label();
            find = new Button();
            error = new Label();
            add_save = new Button();
            button1 = new Button();
            maskedTextBoxGenOrJob = new MaskedTextBox();
            maskedTextMark1OrSubject = new MaskedTextBox();
            maskedTextBoxMark2OrLoad = new MaskedTextBox();
            maskedTextBoxMark3 = new MaskedTextBox();
            maskedTextBoxMark4 = new MaskedTextBox();
            maskedTextBoxMark5 = new MaskedTextBox();
            maskedTextBoxPayment = new MaskedTextBox();
            labelBoxYearOrKaff = new Label();
            labelGenOrJob = new Label();
            labelMark1OrSubject = new Label();
            labelMark2OrLoad = new Label();
            labelMark3 = new Label();
            labelMark4 = new Label();
            labelMarkAvg = new Label();
            labelPayment = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // students
            // 
            students.AutoSize = true;
            students.Checked = true;
            students.Location = new Point(29, 50);
            students.Name = "students";
            students.Size = new Size(93, 19);
            students.TabIndex = 1;
            students.TabStop = true;
            students.Text = "«Учащиеся»";
            students.UseVisualStyleBackColor = true;
            students.CheckedChanged += students_CheckedChanged;
            // 
            // teachers
            // 
            teachers.AutoSize = true;
            teachers.Location = new Point(29, 75);
            teachers.Name = "teachers";
            teachers.Size = new Size(122, 19);
            teachers.TabIndex = 2;
            teachers.Text = "«Преподаватели»";
            teachers.UseVisualStyleBackColor = true;
            teachers.CheckedChanged += teachers_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 20);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(284, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(484, 279);
            dataGridView1.TabIndex = 4;
            // 
            // add
            // 
            add.Location = new Point(40, 134);
            add.Name = "add";
            add.Size = new Size(139, 23);
            add.TabIndex = 5;
            add.Text = "Добавить запись";
            add.UseVisualStyleBackColor = true;
            add.Click += button1_Click;
            // 
            // edit
            // 
            edit.Location = new Point(40, 178);
            edit.Name = "edit";
            edit.Size = new Size(139, 23);
            edit.TabIndex = 6;
            edit.Text = "Редактировать запись";
            edit.UseVisualStyleBackColor = true;
            edit.Click += edit_Click;
            // 
            // maskedTextBoxLastName
            // 
            maskedTextBoxLastName.Location = new Point(123, 220);
            maskedTextBoxLastName.Name = "maskedTextBoxLastName";
            maskedTextBoxLastName.Size = new Size(132, 23);
            maskedTextBoxLastName.TabIndex = 7;
            maskedTextBoxLastName.Visible = false;
            // 
            // maskedTextBoxFirstName
            // 
            maskedTextBoxFirstName.Location = new Point(123, 261);
            maskedTextBoxFirstName.Name = "maskedTextBoxFirstName";
            maskedTextBoxFirstName.Size = new Size(132, 23);
            maskedTextBoxFirstName.TabIndex = 8;
            maskedTextBoxFirstName.Visible = false;
            // 
            // maskedTextBoxMiddleName
            // 
            maskedTextBoxMiddleName.Location = new Point(123, 301);
            maskedTextBoxMiddleName.Name = "maskedTextBoxMiddleName";
            maskedTextBoxMiddleName.Size = new Size(132, 23);
            maskedTextBoxMiddleName.TabIndex = 9;
            maskedTextBoxMiddleName.Visible = false;
            // 
            // maskedTextBoxYearOrKaff
            // 
            maskedTextBoxYearOrKaff.Location = new Point(123, 339);
            maskedTextBoxYearOrKaff.Name = "maskedTextBoxYearOrKaff";
            maskedTextBoxYearOrKaff.Size = new Size(132, 23);
            maskedTextBoxYearOrKaff.TabIndex = 10;
            maskedTextBoxYearOrKaff.Text = "  ";
            maskedTextBoxYearOrKaff.Visible = false;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(53, 223);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(58, 15);
            LastNameLabel.TabIndex = 11;
            LastNameLabel.Text = "Фамилия";
            LastNameLabel.Visible = false;
            LastNameLabel.Click += label2_Click;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(53, 264);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(31, 15);
            FirstNameLabel.TabIndex = 12;
            FirstNameLabel.Text = "Имя";
            FirstNameLabel.Visible = false;
            // 
            // MiddleNameLabel
            // 
            MiddleNameLabel.AutoSize = true;
            MiddleNameLabel.Location = new Point(53, 304);
            MiddleNameLabel.Name = "MiddleNameLabel";
            MiddleNameLabel.Size = new Size(58, 15);
            MiddleNameLabel.TabIndex = 13;
            MiddleNameLabel.Text = "Отчество";
            MiddleNameLabel.Visible = false;
            MiddleNameLabel.Click += label4_Click;
            // 
            // find
            // 
            find.Location = new Point(293, 328);
            find.Name = "find";
            find.Size = new Size(139, 23);
            find.TabIndex = 14;
            find.Text = "Поиск";
            find.UseVisualStyleBackColor = true;
            find.Visible = false;
            find.Click += find_Click;
            // 
            // error
            // 
            error.AutoSize = true;
            error.Enabled = false;
            error.ForeColor = Color.IndianRed;
            error.Location = new Point(299, 374);
            error.Name = "error";
            error.Size = new Size(319, 15);
            error.TabIndex = 15;
            error.Text = "Запись не найдена. Добавить запись с такими данными?";
            error.Visible = false;
            error.Click += label2_Click_1;
            // 
            // add_save
            // 
            add_save.Location = new Point(293, 413);
            add_save.Name = "add_save";
            add_save.Size = new Size(139, 23);
            add_save.TabIndex = 16;
            add_save.Text = "Да";
            add_save.UseVisualStyleBackColor = true;
            add_save.Visible = false;
            add_save.Click += add_save_Click;
            // 
            // button1
            // 
            button1.Location = new Point(451, 413);
            button1.Name = "button1";
            button1.Size = new Size(139, 23);
            button1.TabIndex = 17;
            button1.Text = "Нет";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            // 
            // maskedTextBoxGenOrJob
            // 
            maskedTextBoxGenOrJob.Location = new Point(123, 385);
            maskedTextBoxGenOrJob.Name = "maskedTextBoxGenOrJob";
            maskedTextBoxGenOrJob.Size = new Size(132, 23);
            maskedTextBoxGenOrJob.TabIndex = 18;
            maskedTextBoxGenOrJob.Text = "  ";
            maskedTextBoxGenOrJob.Visible = false;
            // 
            // maskedTextMark1OrSubject
            // 
            maskedTextMark1OrSubject.Location = new Point(123, 429);
            maskedTextMark1OrSubject.Name = "maskedTextMark1OrSubject";
            maskedTextMark1OrSubject.Size = new Size(132, 23);
            maskedTextMark1OrSubject.TabIndex = 19;
            maskedTextMark1OrSubject.Text = "  ";
            maskedTextMark1OrSubject.Visible = false;
            // 
            // maskedTextBoxMark2OrLoad
            // 
            maskedTextBoxMark2OrLoad.Location = new Point(123, 471);
            maskedTextBoxMark2OrLoad.Name = "maskedTextBoxMark2OrLoad";
            maskedTextBoxMark2OrLoad.Size = new Size(132, 23);
            maskedTextBoxMark2OrLoad.TabIndex = 20;
            maskedTextBoxMark2OrLoad.Text = "  ";
            maskedTextBoxMark2OrLoad.Visible = false;
            // 
            // maskedTextBoxMark3
            // 
            maskedTextBoxMark3.Location = new Point(123, 513);
            maskedTextBoxMark3.Name = "maskedTextBoxMark3";
            maskedTextBoxMark3.Size = new Size(132, 23);
            maskedTextBoxMark3.TabIndex = 21;
            maskedTextBoxMark3.Text = "  ";
            maskedTextBoxMark3.Visible = false;
            // 
            // maskedTextBoxMark4
            // 
            maskedTextBoxMark4.Location = new Point(123, 555);
            maskedTextBoxMark4.Name = "maskedTextBoxMark4";
            maskedTextBoxMark4.Size = new Size(132, 23);
            maskedTextBoxMark4.TabIndex = 22;
            maskedTextBoxMark4.Text = "  ";
            maskedTextBoxMark4.Visible = false;
            // 
            // maskedTextBoxMark5
            // 
            maskedTextBoxMark5.Location = new Point(123, 628);
            maskedTextBoxMark5.Name = "maskedTextBoxMark5";
            maskedTextBoxMark5.Size = new Size(132, 23);
            maskedTextBoxMark5.TabIndex = 23;
            maskedTextBoxMark5.Text = "  ";
            maskedTextBoxMark5.Visible = false;
            // 
            // maskedTextBoxPayment
            // 
            maskedTextBoxPayment.Location = new Point(123, 665);
            maskedTextBoxPayment.Name = "maskedTextBoxPayment";
            maskedTextBoxPayment.Size = new Size(132, 23);
            maskedTextBoxPayment.TabIndex = 24;
            maskedTextBoxPayment.Text = "  ";
            maskedTextBoxPayment.Visible = false;
            maskedTextBoxPayment.MaskInputRejected += maskedTextBox4_MaskInputRejected;
            // 
            // labelBoxYearOrKaff
            // 
            labelBoxYearOrKaff.AutoSize = true;
            labelBoxYearOrKaff.Location = new Point(53, 342);
            labelBoxYearOrKaff.Name = "labelBoxYearOrKaff";
            labelBoxYearOrKaff.Size = new Size(58, 15);
            labelBoxYearOrKaff.TabIndex = 25;
            labelBoxYearOrKaff.Text = "Отчество";
            labelBoxYearOrKaff.Visible = false;
            // 
            // labelGenOrJob
            // 
            labelGenOrJob.AutoSize = true;
            labelGenOrJob.Location = new Point(53, 385);
            labelGenOrJob.Name = "labelGenOrJob";
            labelGenOrJob.Size = new Size(58, 15);
            labelGenOrJob.TabIndex = 26;
            labelGenOrJob.Text = "Отчество";
            labelGenOrJob.Visible = false;
            // 
            // labelMark1OrSubject
            // 
            labelMark1OrSubject.AutoSize = true;
            labelMark1OrSubject.Location = new Point(57, 429);
            labelMark1OrSubject.Name = "labelMark1OrSubject";
            labelMark1OrSubject.Size = new Size(58, 15);
            labelMark1OrSubject.TabIndex = 27;
            labelMark1OrSubject.Text = "Отчество";
            labelMark1OrSubject.Visible = false;
            // 
            // labelMark2OrLoad
            // 
            labelMark2OrLoad.AutoSize = true;
            labelMark2OrLoad.Location = new Point(53, 471);
            labelMark2OrLoad.Name = "labelMark2OrLoad";
            labelMark2OrLoad.Size = new Size(58, 15);
            labelMark2OrLoad.TabIndex = 28;
            labelMark2OrLoad.Text = "Отчество";
            labelMark2OrLoad.Visible = false;
            // 
            // labelMark3
            // 
            labelMark3.AutoSize = true;
            labelMark3.Location = new Point(57, 516);
            labelMark3.Name = "labelMark3";
            labelMark3.Size = new Size(58, 15);
            labelMark3.TabIndex = 29;
            labelMark3.Text = "Отчество";
            labelMark3.Visible = false;
            // 
            // labelMark4
            // 
            labelMark4.AutoSize = true;
            labelMark4.Location = new Point(59, 555);
            labelMark4.Name = "labelMark4";
            labelMark4.Size = new Size(58, 15);
            labelMark4.TabIndex = 30;
            labelMark4.Text = "Отчество";
            labelMark4.Visible = false;
            // 
            // labelMarkAvg
            // 
            labelMarkAvg.AutoSize = true;
            labelMarkAvg.Location = new Point(59, 631);
            labelMarkAvg.Name = "labelMarkAvg";
            labelMarkAvg.Size = new Size(58, 15);
            labelMarkAvg.TabIndex = 31;
            labelMarkAvg.Text = "Отчество";
            labelMarkAvg.Visible = false;
            // 
            // labelPayment
            // 
            labelPayment.AutoSize = true;
            labelPayment.Location = new Point(59, 676);
            labelPayment.Name = "labelPayment";
            labelPayment.Size = new Size(58, 15);
            labelPayment.TabIndex = 32;
            labelPayment.Text = "Отчество";
            labelPayment.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 700);
            Controls.Add(labelPayment);
            Controls.Add(labelMarkAvg);
            Controls.Add(labelMark4);
            Controls.Add(labelMark3);
            Controls.Add(labelMark2OrLoad);
            Controls.Add(labelMark1OrSubject);
            Controls.Add(labelGenOrJob);
            Controls.Add(labelBoxYearOrKaff);
            Controls.Add(maskedTextBoxPayment);
            Controls.Add(maskedTextBoxMark5);
            Controls.Add(maskedTextBoxMark4);
            Controls.Add(maskedTextBoxMark3);
            Controls.Add(maskedTextBoxMark2OrLoad);
            Controls.Add(maskedTextMark1OrSubject);
            Controls.Add(maskedTextBoxGenOrJob);
            Controls.Add(button1);
            Controls.Add(add_save);
            Controls.Add(error);
            Controls.Add(find);
            Controls.Add(MiddleNameLabel);
            Controls.Add(FirstNameLabel);
            Controls.Add(LastNameLabel);
            Controls.Add(maskedTextBoxYearOrKaff);
            Controls.Add(maskedTextBoxMiddleName);
            Controls.Add(maskedTextBoxFirstName);
            Controls.Add(maskedTextBoxLastName);
            Controls.Add(edit);
            Controls.Add(add);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(teachers);
            Controls.Add(students);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton students;
        private RadioButton teachers;
        private Label label1;
        private DataGridView dataGridView1;
        private Button add;
        private Button edit;
        private MaskedTextBox maskedTextBoxLastName;
        private MaskedTextBox maskedTextBoxFirstName;
        private MaskedTextBox maskedTextBoxMiddleName;
        private MaskedTextBox maskedTextBoxYearOrKaff;
        private Label LastNameLabel;
        private Label FirstNameLabel;
        private Label MiddleNameLabel;
        private Button find;
        private Label error;
        private Button add_save;
        private Button button1;
        private MaskedTextBox maskedTextBoxGenOrJob;
        private MaskedTextBox maskedTextMark1OrSubject;
        private MaskedTextBox maskedTextBoxMark2OrLoad;
        private MaskedTextBox maskedTextBoxMark3;
        private MaskedTextBox maskedTextBoxMark4;
        private MaskedTextBox maskedTextBoxMark5;
        private MaskedTextBox maskedTextBoxPayment;
        private Label labelBoxYearOrKaff;
        private Label labelGenOrJob;
        private Label labelMark1OrSubject;
        private Label labelMark2OrLoad;
        private Label labelMark3;
        private Label labelMark4;
        private Label labelMarkAvg;
        private Label labelPayment;
        private RadioButton all;
    }
}