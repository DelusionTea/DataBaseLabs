using MySql.Data.MySqlClient;
using System.IO.Packaging;

namespace WinFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public class Student
        {
            public string name;
            public string lastName;
            public string middleName;
            public string year;
            public string gender;
            public string mark1;
            public string mark2;
            public string mark3;
            public string mark4;
            public string markAvg;
            public string payment;
        }
        public class Teacher
        {
            public string name;
            public string lastName;
            public string middleName;
            public string kaffedra;
            public string job;
            public string subject;
            public string load;

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            edit.Enabled = false;
            students.Enabled = false;
            teachers.Enabled = false;
            find.Visible = true;
            button1.Enabled = false;
            find.Text = "Отменить";
            FirstNameLabel.Visible = true;
            LastNameLabel.Visible = true;
            MiddleNameLabel.Visible = true;
            maskedTextBoxMiddleName.Visible = true;
            maskedTextBoxFirstName.Visible = true;
            maskedTextBoxLastName.Visible = true;
            maskedTextBoxGenOrJob.Visible = true;
            maskedTextBoxMark2OrLoad.Visible = true;
            maskedTextBoxYearOrKaff.Visible = true;
            maskedTextMark1OrSubject.Visible = true;
            labelBoxYearOrKaff.Visible = true;
            labelGenOrJob.Visible = true;
            labelMark1OrSubject.Visible = true;
            labelGenOrJob.Visible = true;
            labelMark2OrLoad.Visible = true;

            if (students.Checked)
            {
                labelMark3.Visible = true;
                labelMark4.Visible = true;
                labelMarkAvg.Visible = true;
                labelPayment.Visible = true;

                labelBoxYearOrKaff.Text = "Год рождения";
                labelGenOrJob.Text = "Пол";
                labelMark1OrSubject.Text = "Оценка 1";
                labelMark2OrLoad.Text = "Оценка 2";
                labelMark3.Text = "Оценка 3";
                labelMark4.Text = "Оценка 4";
                labelMarkAvg.Text = "Оценка ср.";
                labelPayment.Text = "Оплачено";
                maskedTextBoxMark5.Visible = true;
                maskedTextBoxMark4.Visible = true;
                maskedTextBoxMark3.Visible = true;
                maskedTextBoxPayment.Visible = true;

            }
            if (teachers.Checked)
            {
                labelBoxYearOrKaff.Text = "Каффедра";
                labelGenOrJob.Text = "Должность";
                labelMark1OrSubject.Text = "Предмет";
                labelMark2OrLoad.Text = "Нагрузка";

            }


        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void students_CheckedChanged(object sender, EventArgs e)
        {
            if (students.Checked)
            {
                teachers.Checked = false;
            }
        }

        private void teachers_CheckedChanged(object sender, EventArgs e)
        {
            if (teachers.Checked)
            {
                students.Checked = false;
            }
        }

        public Student foundInDataBaseS(string f, string i, string o)
        {

            {
                //Call to database
                Student student = new Student();
                DataBase db = new DataBase();
                string rq = "SELECT * FROM students WHERE LastName=" + f + " AND FirstName=" + i + " AND MiddleName=" + o;
                MySqlCommand command = new MySqlCommand(rq, db.getConnection());

                string rp = command.ExecuteScalar().ToString();
                Console.WriteLine(rp);

                /*rp.
                student.lastName = f;
                student.name = f;
                student.payment;
                student.gender;
                student.year;
                student.mark1 = f;
                student.mark2 = f;
                student.mark3 = f;
                student.mark4 = f;
                student.markAvg = f;
                student.middleName = f;*/

                return student;
            }

        }
        public Teacher foundInDataBaseT(string f, string i, string o)
        {

            //Call to database
            Teacher teacher = new Teacher();
            return teacher;

        }

        public void foundInDataBase(string f, string i, string o, string role)
        {
            //check
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("COUNT(*) FROM '@role' ", db.getConnection());


            command.Parameters.Add("@role", MySqlDbType.VarChar).Value = role;


            db.closeConnection();
        }
        public bool foundInDataBaseExist(string f, string i, string o, string role)
        {
            DataBase db = new DataBase();
            string sql = "SELECT name FROM " + role;
            MySqlCommand command = new MySqlCommand("sql", db.getConnection());

            int result = (int)command.ExecuteScalar();
            if (result >= 1) { return true; }
            return false;
        }
        private void find_Click(object sender, EventArgs e)
        {
            bool exist = false;
            string firstName = maskedTextBoxFirstName.Text;
            string lastName = maskedTextBoxLastName.Text;
            string middleName = maskedTextBoxMiddleName.Text;
            if (students.Checked)
            {
                exist = foundInDataBaseExist(firstName,
                    lastName,
                    middleName,
                    "student");

            }
            if (teachers.Checked)
            {
                exist = foundInDataBaseExist(firstName,
                lastName,
                middleName,
                "teacher");
            }
            if (students.Checked)
            {
                foundInDataBase(firstName,
                    lastName,
                    middleName,
                    "student");
            }
            if (teachers.Checked)
            {
                foundInDataBase(firstName,
                lastName,
                middleName,
                "teacher");
            }
            if (find.Text == "Поиск")
            {
                if (!exist)
                {
                    error.Visible = true;
                    add_save.Visible = true;
                    button1.Visible = true;
                    FirstNameLabel.Enabled = false;
                    LastNameLabel.Enabled = false;
                    MiddleNameLabel.Enabled = false;

                    /*TO DO**/
                    //Create new
                }
                else
                {
                    labelBoxYearOrKaff.Visible = true;
                    labelGenOrJob.Visible = true;
                    labelMark1OrSubject.Visible = true;
                    labelMark2OrLoad.Visible = true;
                    if (students.Checked)
                    {
                        labelMark3.Visible = true;
                        labelMark4.Visible = true;
                        labelMarkAvg.Visible = true;
                        labelPayment.Visible = true;
                        labelBoxYearOrKaff.Text = "Год рождения";
                        labelGenOrJob.Text = "Пол";
                        labelMark1OrSubject.Text = "Оценка 1";
                        labelMark2OrLoad.Text = "Оценка 2";
                        labelMark3.Text = "Оценка 3";
                        labelMark4.Text = "Оценка 4";
                        labelMarkAvg.Text = "Оценка ср.";
                        labelPayment.Text = "Оплачено";


                        Student student = foundInDataBaseS(firstName,
                            lastName,
                            middleName);
                        maskedTextBoxGenOrJob.Text = student.gender;
                        maskedTextBoxMark2OrLoad.Text = student.mark2;
                        maskedTextBoxMark3.Text = student.mark3;
                        maskedTextBoxMark4.Text = student.mark4;
                        maskedTextBoxMark5.Text = student.markAvg;
                        maskedTextBoxPayment.Text = student.payment;


                    }
                    if (teachers.Checked)
                    {
                        labelBoxYearOrKaff.Text = "Каффедра";
                        labelGenOrJob.Text = "Должность";
                        labelMark1OrSubject.Text = "Предмет";
                        labelMark2OrLoad.Text = "Нагрузка";

                        foundInDataBase(firstName,
                        lastName,
                        middleName,
                        "teacher");

                        Teacher teacher = foundInDataBaseT(firstName,
        lastName,
        middleName);
                        maskedTextBoxGenOrJob.Text = teacher.job;


                        maskedTextBoxMark2OrLoad.Text = teacher.load;
                        maskedTextBoxYearOrKaff.Text = teacher.kaffedra;
                    }
                }
            }
            if (find.Text == "Отменить")
            {
                edit.Enabled = true;

                find.Visible = false;
                button1.Enabled = true;
                students.Enabled = true;
                teachers.Enabled = true;
                FirstNameLabel.Visible = false;
                LastNameLabel.Visible = false;
                MiddleNameLabel.Visible = false;
                maskedTextBoxMiddleName.Visible = false;
                maskedTextBoxFirstName.Visible = false;
                maskedTextBoxLastName.Visible = false;
                maskedTextBoxGenOrJob.Visible = false;
                maskedTextBoxMark2OrLoad.Visible = false;
                maskedTextMark1OrSubject.Visible = false;
                maskedTextBoxYearOrKaff.Visible = false;
                labelMark3.Visible = false;
                labelMark4.Visible = false;
                labelMarkAvg.Visible = false;
                labelPayment.Visible = false;
                maskedTextBoxMark5.Visible = false;
                maskedTextBoxMark4.Visible = false;
                maskedTextBoxMark3.Visible = false;
                maskedTextBoxPayment.Visible = false;
                labelBoxYearOrKaff.Visible = false;
                labelGenOrJob.Visible = false;
                labelMark1OrSubject.Visible = false;
                labelMark2OrLoad.Visible = false;
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {

            find.Visible = true;
            FirstNameLabel.Visible = true;
            LastNameLabel.Visible = true;
            MiddleNameLabel.Visible = true;
            maskedTextBoxMiddleName.Visible = true;
            maskedTextBoxFirstName.Visible = true;
            maskedTextBoxLastName.Visible = true;
            string firstName = maskedTextBoxFirstName.Text;
            string lastName = maskedTextBoxLastName.Text;
            string middleName = maskedTextBoxMiddleName.Text;

        }

        private void add_save_Click(object sender, EventArgs e)
        {

        }
    }
}
