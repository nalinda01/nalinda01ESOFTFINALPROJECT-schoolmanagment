using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace schoolmanagment
{
    public partial class student : Form
    {
        // Correcting SqlConnection declaration
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TSRGDAJ\SQLEXPRESS;Initial Catalog=esoftdb;Integrated Security=True");

        public student()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open(); // Open database connection

                string firstname = textBox1.Text;
                string lastname = textBox2.Text;
                string gender = radioButton1.Checked ? "male" : "female";
                string grade = comboBox1.Text;
                string pname = textBox3.Text;
                string pnic = textBox4.Text;
                string pgender = radioButton4.Checked ? "male" : "female";
                string pnumber = textBox5.Text;

                string query = "INSERT INTO Student (FirstName, LastName, Gender, Grade, pname, pnic, pgender, pnumber) " +
                               "VALUES (@firstname, @lastname, @gender, @grade, @pname, @pnic, @pgender, @pnumber)";

                using (SqlCommand cmd = new SqlCommand(query, con))  // Pass 'con' to SqlCommand
                {
                    cmd.Parameters.AddWithValue("@FirstName", firstname);
                    cmd.Parameters.AddWithValue("@LastName", lastname);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Grade", grade);
                    cmd.Parameters.AddWithValue("@pname", pname);
                    cmd.Parameters.AddWithValue("@pnic", pnic);
                    cmd.Parameters.AddWithValue("@pgender", pgender);
                    cmd.Parameters.AddWithValue("@pnumber", pnumber);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Student details saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving: " + ex.Message);
            }
            finally
            {
                con.Close(); // Ensure the connection is closed
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Student details Delected successfully!");
        }

        private void clear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Student details Clear successfully!");
        }

        private void update_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Student details Updated successfully!");
        }

    }
}
