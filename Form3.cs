using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form3 : Form
    {
        //arraylist to getter and setter data  
        private static ArrayList ListFirstname = new ArrayList();
        private static ArrayList ListLastname = new ArrayList();
        private static ArrayList ListMiddleName = new ArrayList();
        private static ArrayList ListYear = new ArrayList();
        private static ArrayList ListGender = new ArrayList();
        private static ArrayList ListMark1 = new ArrayList();
        private static ArrayList ListMark2 = new ArrayList();
        private static ArrayList ListMark3 = new ArrayList();
        private static ArrayList ListMark4 = new ArrayList();
        private static ArrayList ListMarkAvg = new ArrayList();
        private static ArrayList ListPayment = new ArrayList();
        private static ArrayList ListSubject = new ArrayList();
        private static ArrayList ListKaff = new ArrayList();
        private static ArrayList ListJob = new ArrayList();
        private static ArrayList ListLoad = new ArrayList();
        public Form3()
        {
            InitializeComponent();
        }
        private void GetDataGrid()
        {
            DataBase db = new DataBase();

            MySqlDataReader row;
            string pf = " ORDER BY ";
            db.openConnection();
            listBox1.Items.Clear();
            listBox1.Items.Add("LastName");
            /*Переписать на JOIN*/

            string rQ = "";
            if (radioButton1.Checked)
            {
                rQ = "SELECT * FROM students FULL JOIN teachers";
                listBox1.Items.Add("year");
                listBox1.Items.Add("markavg");
                listBox1.Items.Add("job");
                listBox1.Items.Add("load");
                switch (listBox1.SelectedIndex)
                {
                    case 0:
                        pf += "LastName";
                        break;
                    case 1:
                        pf += "year";
                        break;
                    case 2:
                        pf += "markavg";
                        break;
                    case 3:
                        pf += "job";
                        break;
                    case 4:
                        pf += "load";
                        break;
                    default:
                        pf = "";
                        break;
                }
                rQ += pf;
            }
            else if (students.Checked)
            {
                rQ = "SELECT * FROM students LIMIT 5";
                listBox1.Items.Add("year");
                listBox1.Items.Add("markavg");
                switch (listBox1.SelectedIndex)
                {
                    case 0:
                        pf += "LastName";
                        break;
                    case 1:
                        pf += "year";
                        break;
                    case 2:
                        pf += "markavg";
                        break;
                    default:
                        pf = "";
                        break;
                }
                rQ += pf;
            }
            else
            {
                rQ = "SELECT * FROM `course`.`teachers` LIMIT 5";
                listBox1.Items.Add("job");
                listBox1.Items.Add("load");
                switch (listBox1.SelectedIndex)
                {
                    case 0:
                        pf += "LastName";
                        break;
                    case 1:
                        pf += "job";
                        break;
                    case 2:
                        pf += "load";
                        break;
                    default:
                        pf = "";
                        break;
                }
                rQ += pf;
            }


            row = db.ExecuteReader(rQ);
            if (row.HasRows)
            {
                while (row.Read())
                {
                    ListFirstname.Add(row["FirstName"].ToString());
                    ListLastname.Add(row["LastName"].ToString());
                    ListMiddleName.Add(row["MiddleName"].ToString());
                    if (students.Checked || radioButton1.Checked)
                    {
                        ListGender.Add(row["gender"]).ToString();
                        ListYear.Add(row["year"]).ToString();
                        ListMark1.Add(row["mark1"]).ToString();
                        ListMark2.Add(row["mark2"]).ToString();
                        ListMark3.Add(row["mark3"]).ToString();
                        ListMark4.Add(row["mark4"]).ToString();
                        ListMarkAvg.Add(row["markavg"]).ToString();
                        ListPayment.Add(row["payment"]).ToString();
                    }
                    if (techers.Checked || radioButton1.Checked)
                    {
                        ListLoad.Add(row["load"]).ToString();
                        ListJob.Add(row["job"]).ToString();
                        ListKaff.Add(row["department"]).ToString();
                        ListSubject.Add(row["subject"]).ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Data not found " + rQ);
            }
            db.closeConnection();
        }
        private void updateDatagridAll()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < ListFirstname.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(dataGridView1);


                newRow.Cells[0].Value = ListFirstname[i];
                newRow.Cells[1].Value = ListLastname[i];
                newRow.Cells[2].Value = ListMiddleName[i];
                newRow.Cells[3].Value = ListGender[i];
                newRow.Cells[5].Value = ListMark1[i];
                newRow.Cells[6].Value = ListMark2[i];
                newRow.Cells[7].Value = ListMark3[i];
                newRow.Cells[8].Value = ListMark4[i];
                newRow.Cells[9].Value = ListMarkAvg[i];

                newRow.Cells[10].Value = ListPayment[i];
                newRow.Cells[11].Value = ListLoad[i];
                newRow.Cells[12].Value = ListKaff[i];
                newRow.Cells[13].Value = ListSubject[i];

                dataGridView1.Rows.Add(newRow);
            }
        }

        private void updateDatagridTeachers()
        {
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            this.dataGridView1.Columns.Add("Firstname", "Firstname");
            this.dataGridView1.Columns.Add("Lastname", "Lastname");
            this.dataGridView1.Columns.Add("MiddleName", "MiddleName");
            this.dataGridView1.Columns.Add("Load", "Load");
            this.dataGridView1.Columns.Add("Kaff", "Kaff");
            this.dataGridView1.Columns.Add("Subject", "Subject");

            for (int i = 0; i < ListLoad.Count; i++)
            {
                //Create the new row first and get the index of the new row
                //int rowIndex = this.dataGridView1.Rows.Add();

                //Obtain a reference to the newly created DataGridViewRow 
                //var row = this.dataGridView1.Rows[rowIndex];

                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridView1);
                newRow.Cells[0].Value = ListFirstname[i];
                newRow.Cells[1].Value = ListLastname[i];
                newRow.Cells[2].Value = ListMiddleName[i];
                newRow.Cells[3].Value = ListLoad[i];
                newRow.Cells[4].Value = ListKaff[i];
                newRow.Cells[5].Value = ListSubject[i];

                dataGridView1.Rows.Add(newRow);
            }
        }

        private void updateDatagridStudents()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            this.dataGridView1.Columns.Add("Firstname", "Firstname");
            this.dataGridView1.Columns.Add("Lastname", "Lastname");
            this.dataGridView1.Columns.Add("MiddleName", "MiddleName");
            this.dataGridView1.Columns.Add("Gender", "Gender");
            this.dataGridView1.Columns.Add("Mark1", "Mark1");
            this.dataGridView1.Columns.Add("Mark2", "Mark2");
            this.dataGridView1.Columns.Add("Mark3", "Mark3");
            this.dataGridView1.Columns.Add("Mark4", "Mark4");
            this.dataGridView1.Columns.Add("MarkAvg", "MarkAvg");
            this.dataGridView1.Columns.Add("Payment", "Payment");
            this.dataGridView1.Columns.Add("Year", "Year");
            for (int i = 0; i < ListGender.Count; i++)
            {
                //Create the new row first and get the index of the new row
                
                //int rowIndex = this.dataGridView1.Rows.Add();

                //Obtain a reference to the newly created DataGridViewRow 
                //var row = this.dataGridView1.Rows[rowIndex];

                DataGridViewRow newRow = new DataGridViewRow();
                
                newRow.CreateCells(dataGridView1);
                newRow.Cells[0].Value = ListFirstname[i];
                newRow.Cells[1].Value = ListLastname[i];
                newRow.Cells[2].Value = ListMiddleName[i];
                newRow.Cells[3].Value = ListGender[i];
                newRow.Cells[5].Value = ListMark1[i];
                newRow.Cells[6].Value = ListMark2[i];
                newRow.Cells[7].Value = ListMark3[i];
                newRow.Cells[8].Value = ListMark4[i];
                newRow.Cells[9].Value = ListMarkAvg[i];
                newRow.Cells[9].Value = ListYear[i];

                dataGridView1.Rows.Add(newRow);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataBase db = new DataBase();
            //String rQ = "SELECT * FROM Students, Teachers LIMIT 5";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetDataGrid();
            if (radioButton1.Checked)
            {
                updateDatagridAll();
            }
            else if (students.Checked)
            {
                updateDatagridStudents();
            }
            else
            {
                updateDatagridTeachers();
            }


        }

        private void students_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
