using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }



        private void inputButton_Click(object sender, EventArgs e)
        {

            // Create a new instance of the Form2 class
            Form2 settingsForm = new Form2();

            // Show the settings form
            settingsForm.ShowDialog();
            settingsForm.Show();
            this.Close();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            Form3 settingsForm = new Form3();

            // Show the settings form
            settingsForm.ShowDialog();
            settingsForm.Show();
            this.Close();

        }

        private void printButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            Form4 settingsForm = new();

            settingsForm.ShowDialog();
            settingsForm.Show();
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye");
            Application.Exit();
            this.Close();
        }

        private void inputButton_Click_1(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            Form2 settingsForm = new Form2();

            // Show the settings form
            settingsForm.ShowDialog();
            settingsForm.Show();
            this.Close();
        }

        private void findButton_Click_1(object sender, EventArgs e)
        {
            Form3 settingsForm = new Form3();

            // Show the settings form
            settingsForm.ShowDialog();
            settingsForm.Show();
            this.Close();
        }

        private void printButton_Click_1(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            Form4 settingsForm = new();

            settingsForm.ShowDialog();
            settingsForm.Show();
            this.Close();
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye");
            Application.Exit();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 settingsForm = new Form5();

            // Show the settings form
            settingsForm.ShowDialog();
            settingsForm.Show();
            this.Close();

            DataBase db = new DataBase();
            string name = "check";
            string sql = "SELECT * FROM students Limit 2";
            string response = "";
            db.openConnection();
            // объект для выполнения SQL-запроса
            MySqlCommand command = new MySqlCommand(sql, db.getConnection());

            MySqlDataReader reader = command.ExecuteReader();
            // читаем результат
            while (reader.Read())
            {
                // элементы массива [] - это значения столбцов из запроса SELECT
                response += (reader[0].ToString() + " " + reader[1].ToString());
            }

            // выполняем запрос и получаем ответ
            //command.ExecuteNonQuery();
            //name = command.ExecuteScalar().ToString();
            // выводим ответ в консоль
            Console.WriteLine(name);
            label1.Text = response;
            db.closeConnection();
        }
    }
}