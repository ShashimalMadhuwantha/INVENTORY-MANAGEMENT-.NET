using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace inventorycw
{
    public partial class FormDashboard : Form
    {
      
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddItem formAddItem = new FormAddItem();
            formAddItem.Show();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void buttonAddsupplier_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddSupplier formAddSupplier = new FormAddSupplier();
            formAddSupplier.Show();
        }

        private void buttonAddmembers_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddMember formAddMember = new FormAddMember();  
            formAddMember.Show();
        }

        private void buttonPurchasing_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPurchasing formPurchasing = new FormPurchasing();
            formPurchasing.Show();
        }

        private void buttonMemberPurchase_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberPurchasing formMemberPurchase = new MemberPurchasing();
            formMemberPurchase.Show();
        }

        private void buttonInventoryState_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInventorySate formInventoryState = new FormInventorySate();
            formInventoryState.Show();
        }

        private void buttonAboutus_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRestock formRestock = new FormRestock();
            formRestock.Show();
        }
        private void LoadAdmindetails()
        {
            ClassConnection classConnection = new ClassConnection();
            SqlConnection sqlConnection = classConnection.GetConnection();
            sqlConnection.Open();
            string sql = "Select Admin_Id,Username,Password,Name from Admin";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewAdmindetails.DataSource = dt;
            sqlConnection.Close();  
        }
        private void dataGridViewAdmindetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            LoadAdmindetails();


        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            try
            {

                ClassConnection classConnection = new ClassConnection();
                SqlConnection sqlConnection = classConnection.GetConnection();
                sqlConnection.Open();


                string select = "SELECT * FROM Admin WHERE Username = '" + textBoxusername.Text + "' AND Password = '" + textBoxcurrentpassword.Text + "'";


                SqlCommand cmdobj = new SqlCommand(select, sqlConnection);




                SqlDataReader reader = cmdobj.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Close();
                    string query = "UPDATE Admin SET Password ='"+textBoxnewpassword.Text+"'";
                    SqlCommand cmd = new SqlCommand(query,sqlConnection );
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Password Changed");
                    LoadAdmindetails();

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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxcurrentpassword.Text = "";
            textBoxnewpassword.Text = "";
            textBoxusername.Text = "";
        }

        private void textBoxusername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxusername.Text))
            {
                
                e.Cancel = true;
                errorProvider1.SetError(textBoxusername, "Username cannot be empty.");
            }
            else
            {
        
                errorProvider1.SetError(textBoxusername, "");
            }
        }

        private void textBoxcurrentpassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxcurrentpassword.Text))
            {

                e.Cancel = true;
                errorProvider2.SetError(textBoxcurrentpassword, "Current Password cannot be empty.");
            }
            else
            {

                errorProvider2.SetError(textBoxcurrentpassword, "");
            }
        }

        private void textBoxnewpassword_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxnewpassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxnewpassword.Text))
            {

                e.Cancel = true;
                errorProvider3.SetError(textBoxnewpassword, "New Password cannot be empty.");
            }
            else
            {

                errorProvider3.SetError(textBoxnewpassword, "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRemoveMembers formRemoveMembers = new FormRemoveMembers();
            formRemoveMembers.Show();
        }

        private void buttonViewPurchasehistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPurchseHistory formPurchseHistory = new FormPurchseHistory();
            formPurchseHistory.Show();
        }
    }
}
