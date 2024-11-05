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
    public partial class FormPurchseHistory : Form
    {
        public FormPurchseHistory()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadPurchasedetails(string buyerName)
        {
            try
            {
                ClassConnection classConnection = new ClassConnection();
                SqlConnection sqlConnection = classConnection.GetConnection();
                sqlConnection.Open();

                string sql = @"
                SELECT 
                    p.PlistId, 
                    b.Name as BuyerName, 
                    i.name as ItemName, 
                    p.Quantity, 
                    p.Total
                FROM 
                    PurchasedItem p
                INNER JOIN 
                    Buyer b ON p.Buyer_Id = b.Buyer_Id
                INNER JOIN 
                    Item i ON p.Item_Id = i.Item_Id
                WHERE 
                    b.Name = @BuyerName";

                SqlCommand command = new SqlCommand(sql, sqlConnection);
                command.Parameters.AddWithValue("@BuyerName", buyerName);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridViewMemberdetails.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("There is no purchase history for this buyer.");
                    dataGridViewMemberdetails.DataSource = null;
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string buyerName = textBoxMemberId.Text.Trim();
            if (!string.IsNullOrEmpty(buyerName))
            {
                LoadPurchasedetails(buyerName);
            }
            else
            {
                MessageBox.Show("Please enter a buyer name.");
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
    }
}
