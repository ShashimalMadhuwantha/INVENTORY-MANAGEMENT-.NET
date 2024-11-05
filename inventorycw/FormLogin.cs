using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace inventorycw
{
    public partial class FormLOGIN : Form
    {
        public FormLOGIN()
        {
            InitializeComponent();
        }

        private void FormLOGIN_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                
                ClassConnection classConnection = new ClassConnection();
                SqlConnection sqlConnection = classConnection.GetConnection();
                sqlConnection.Open();

                string sql = "SELECT * FROM Admin WHERE Username = '" + textBoxUsername.Text + "' AND Password = '" + textBoxPassword.Text + "'";


                SqlCommand cmdobj = new SqlCommand(sql, sqlConnection);
                
                   

                    
                    SqlDataReader reader = cmdobj.ExecuteReader();
                    
                        if (reader.HasRows)
                        {
                           
                            this.Hide();
                            FormDashboard formDashboard = new FormDashboard();
                            formDashboard.Show();
                        }
                        else
                        {
                      
                            MessageBox.Show("Incorrect username or password.");
                        }
                sqlConnection.Close();    
                
            }
            catch (Exception ex)
            {
              
                MessageBox.Show("An error occurred: " + ex.Message);
            }





        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void textBoxUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text))
            {

                e.Cancel = true;
                errorProvider1.SetError(textBoxUsername, "Username cannot be empty.");
            }
            else
            {

                errorProvider1.SetError(textBoxUsername, "");
            }
        }

        private void textBoxPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {

                e.Cancel = true;
                errorProvider2.SetError(textBoxPassword, "Password cannot be empty.");
            }
            else
            {

                errorProvider2.SetError(textBoxPassword, "");
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
