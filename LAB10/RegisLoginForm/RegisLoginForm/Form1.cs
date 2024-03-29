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

namespace RegisLoginForm
{
    public partial class Form1 : Form
    {
        static SqlConnection con = null;
        static SqlCommand cmd = null;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void OpenConnection()
        {
            string ConString = @"Data Source=SATHVIKKOTA\SQLEXPRESS;Initial Catalog=student_db;Integrated Security=True";
            con = new SqlConnection(ConString);
            con.Open();
        }

        private void CloseConnection()
        {
            if (con != null && con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }



        private void regbutton_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel3.Visible = true;
            panel2.Visible = false;
        }

        

        private void loginbutton_Click(object sender, EventArgs e)
        {
            panel3.Visible=true;
            panel1.Visible = false;
            panel2.Visible = true;
        }



        private void regsubmit_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            try
            {
                OpenConnection();
                cmd = new SqlCommand("INSERT INTO student VALUES(@Param1, @Param2, @Param3)", con);
                cmd.Parameters.AddWithValue("@Param1", textBox1.Text);
                cmd.Parameters.AddWithValue("@Param2", textBox2.Text);
                cmd.Parameters.AddWithValue("@Param3", textBox3.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data inserted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection(); 
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            CloseConnection();
        }

        private void regreset_Click(object sender, EventArgs e)
        {
                            
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox8.Text))
            {
                MessageBox.Show("Please enter both email and password/sid.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                OpenConnection();
                cmd = new SqlCommand("SELECT * FROM student WHERE semail = @Email AND sid = @SID", con);
                cmd.Parameters.AddWithValue("@Email", textBox5.Text);
                cmd.Parameters.AddWithValue("@SID", textBox8.Text);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // User found, you can access user data if needed
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // User not found
                        MessageBox.Show("Invalid email or password/sid.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox8.Clear();
        }
    }
}
