using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB_3
{
    public partial class Form1 : Form
    {
        Student mystudent = new Student();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = mystudent.Getdatadisplay();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBDataSet1.student_data' table. You can move, or remove it, as needed.
           // this.student_dataTableAdapter.Fill(this.studentDBDataSet1.student_data);

        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            mystudent.s_id = id_text.Text;
            mystudent.s_name = nametext.Text;
            mystudent.age = age_numericUpDown1.Value.ToString();
            mystudent.ph_no = contact_no_text.Text;
            mystudent.gender = gender_comboBox1.SelectedItem.ToString();
            if (mystudent.insertstudentdetails(mystudent))
            {
                MessageBox.Show("Insertion Successfull");
                dataGridView1.DataSource = mystudent.Getdatadisplay();
                clearthecontrols();
            }
            else
                MessageBox.Show("Insertion Unsuccessfull");
        }

        private void clearthecontrols()
        {
            id_text.Text = "";
            nametext.Text = "";
            age_numericUpDown1.Value = 18;
            contact_no_text.Text = "";
            gender_comboBox1.SelectedValue = "";
            searchtext.Text = "";
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            mystudent.s_id = id_text.Text;
            if (mystudent.deletestudentdetails(mystudent))
            {
                MessageBox.Show(" Row Deleted successfully");
                dataGridView1.DataSource = mystudent.Getdatadisplay();
                clearthecontrols();
            }
            else
                MessageBox.Show("Deletion is unsuccessfull");
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            mystudent.s_id = id_text.Text;
            mystudent.s_name = nametext.Text;
            mystudent.age = age_numericUpDown1.Value.ToString();
            mystudent.ph_no = contact_no_text.Text;
            mystudent.gender = gender_comboBox1.SelectedItem.ToString();
            if (mystudent.updatestudentdetails(mystudent))
            {
                MessageBox.Show("Updation Successfull");
                dataGridView1.DataSource = mystudent.Getdatadisplay();
                clearthecontrols();
            }
            else
                MessageBox.Show("Updation Denied");
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            mystudent.s_id = searchtext.Text;
            if(mystudent.searchdatabase(mystudent))
            {
                MessageBox.Show("Id is found");
                dataGridView1.DataSource = mystudent.Getdatadisplay();
                clearthecontrols();
            }
            else
                MessageBox.Show("Sorry,Id is not found");

        }
    }
    class Student
    {
        private string constring = DB_3.Properties.Settings.Default.StudentDBConnectionString;
        public string s_id;
        public string s_name;
        public string age;
        public string ph_no;
        public string gender;
        public string id;
        private const string selectquery = "select * from student_data";
        private const string selectquery2 = "select * from student_data where s_id=@s_id";
        private const string insertquery= "insert into student_data values(@s_id,@s_name,@age,@ph_no,@gender)";
        private const string deletequery = "delete from student_data where s_id=@s_id";
        private const string updatequery = "update student_data set s_name=@s_name,age=@age,ph_no=@ph_no,gender=@gender where s_id=@s_id";
        //Methods
        public DataTable Getdatadisplay()
        {
            var datatable = new DataTable();
            SqlConnection connection = new SqlConnection(constring);
            connection.Open();
            SqlCommand command = new SqlCommand(selectquery, connection);
            SqlDataAdapter myadapter = new SqlDataAdapter(command);
            myadapter.Fill(datatable);
            return datatable;
        }

        public bool insertstudentdetails(Student mystudent)
        {
            int rows;
            SqlConnection c = new SqlConnection(constring);
            c.Open();
            SqlCommand com = new SqlCommand(insertquery, c);
            com.Parameters.AddWithValue("s_id", mystudent.s_id);
            com.Parameters.AddWithValue("s_name", mystudent.s_name);
            com.Parameters.AddWithValue("age", mystudent.age);
            com.Parameters.AddWithValue("ph_no", mystudent.ph_no);
            com.Parameters.AddWithValue("gender", mystudent.gender);
            rows = com.ExecuteNonQuery();
            c.Close();
            if (rows > 0)
                return true;
            else
                return false;
        }
        public bool deletestudentdetails(Student mystudent)
        {
            int rows;
            SqlConnection c = new SqlConnection(constring);
            c.Open();
            SqlCommand com = new SqlCommand(deletequery, c);
            com.Parameters.AddWithValue("id", mystudent.id);
            rows = com.ExecuteNonQuery();
            c.Close();
            if (rows > 0)
                return true;
            else
                return false;

        }
        public bool updatestudentdetails(Student mystudent)
        {
            int rows;
            SqlConnection c = new SqlConnection(constring);
            c.Open();
            SqlCommand com = new SqlCommand(updatequery, c);
            com.Parameters.AddWithValue("s_id", mystudent.s_id);
            com.Parameters.AddWithValue("s_name", mystudent.s_name);
            com.Parameters.AddWithValue("age", mystudent.age);
            com.Parameters.AddWithValue("ph_no", mystudent.ph_no);
            com.Parameters.AddWithValue("gender", mystudent.gender);
            rows = com.ExecuteNonQuery();
            c.Close();
            if (rows > 0)
                return true;
            else
                return false;
        }
        public bool searchdatabase(Student mystudent)
        {
            SqlConnection c = new SqlConnection(constring);
            c.Open();
            SqlCommand com = new SqlCommand(selectquery2, c);
            com.Parameters.AddWithValue("s_id", mystudent.s_id);
            SqlDataReader r = com.ExecuteReader();
            if (r.Read())
            {
                return true;
            }
            else
                return false;
        }
    }
}
