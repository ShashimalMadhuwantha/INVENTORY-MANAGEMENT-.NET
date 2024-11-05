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

namespace inventorycw
{
    public partial class FormRemoveMembers : Form
    {
        string buyerId = "";
        public FormRemoveMembers()
        {
            InitializeComponent();
            LoadAdmindetails();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try {

                ClassConnection classConnection = new ClassConnection();
                SqlConnection sqlConnection = classConnection.GetConnection();
                sqlConnection.Open();
                string sql = "Select NIC, Valid_time, MemberId from Member Where MemberId='" + textBoxMemberId.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    buyerId = dt.Rows[0]["MemberId"].ToString(); // Assign the buyer ID
                }
                else
                {
                    MessageBox.Show("Member not found.");
                    buyerId = ""; // Reset the buyer ID if no member is found
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
           
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            ClassConnection classConnection = new ClassConnection();
            SqlConnection sqlConnection = classConnection.GetConnection();
            sqlConnection.Open();
            string sql = "Delete Member where MemberId='"+textBoxMemberId.Text+"'";
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            LoadAdmindetails();
            MessageBox.Show("Member Removed");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadAdmindetails()
        {
            ClassConnection classConnection = new ClassConnection();
            SqlConnection sqlConnection = classConnection.GetConnection();
            sqlConnection.Open();
            string sql = "Select * from Member";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewMemberdetails.DataSource = dt;
            sqlConnection.Close();
        }

        private void textBoxMemberId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMemberId_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxMemberId.Text))
            {

                e.Cancel = true;
                errorProvider1.SetError(textBoxMemberId, "MemberId cannot be empty.");
            }
            else
            {

                errorProvider1.SetError(textBoxMemberId, "");
            }
        }

        private void dashBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDashboard formDashboard = new FormDashboard();
            formDashboard.Show();
        }

        private void iNVENTORYSTATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInventorySate formInventorySate = new FormInventorySate();
            formInventorySate.Show();
        }

        private void panelMemberpurchasing_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
