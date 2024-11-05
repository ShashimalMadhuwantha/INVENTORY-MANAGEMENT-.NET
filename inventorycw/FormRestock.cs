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
    public partial class FormRestock : Form
    {
        public FormRestock()
        {
            InitializeComponent();
        }

        private void dashBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDashboard formDashboard = new FormDashboard();
            formDashboard.Show();
        }

        private void aDDSUPPLIERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddSupplier supplier = new FormAddSupplier();
            supplier.Show();
        }

        private void FormRestock_Load(object sender, EventArgs e)
        {
            Bindcombobox();
            Loaditemgrid();
        }

        private void aDDMEMBERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddMember formAddMember = new FormAddMember();
            formAddMember.Show();
        }

        private void pURCHASINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddItem formAddItem = new FormAddItem();    
            formAddItem.Show();
        }

        private void mEMBERPURCHASINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPurchasing formPurchasing = new FormPurchasing();
            formPurchasing.Show();
        }

        private void iNVENTORYSTATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInventorySate formInventorySate = new FormInventorySate();
            formInventorySate.Show();
        }

        private void buttonRestock_Click(object sender, EventArgs e)
        {
            try
            {
                ClassConnection classConnection = new ClassConnection();
                SqlConnection sqlConnection = classConnection.GetConnection();
                sqlConnection.Open();
                int quantity = Convert.ToInt32(textboxQuantity.Text);
                string get = "Select Quantity from Item where Item_Id='" + comboBoxItemname.SelectedValue.ToString() + "'";
                SqlCommand sqlCommand1 = new SqlCommand(get, sqlConnection);
                object result = sqlCommand1.ExecuteScalar();
                int cquantity = Convert.ToInt32(result);
                int newquantity = quantity + cquantity;
                string restock = " UPDATE Item SET Quantity= '" + newquantity + "' WHERE Item_Id='" + comboBoxItemname.SelectedValue.ToString() + "'";
                SqlCommand sqlCommand = new SqlCommand(restock, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Restocked Successfully");
                Loaditemgrid();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        ClassConnection classConnection = new ClassConnection();    
        private void Bindcombobox()
        {
            ClassConnection classConnection = new ClassConnection();
            SqlConnection sqlConnection = classConnection.GetConnection();
            sqlConnection.Open();
            string sql = "Select Item_Id,name from Item";
           
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            comboBoxItemname.DataSource = dt;
            comboBoxItemname.ValueMember = "Item_Id";
            comboBoxItemname.DisplayMember = "name";
            comboBoxItemname.SelectedIndex = -1;
            comboBoxItemname.Text = "Select a Item";
            sqlConnection.Close();  
        }

        private void Loaditemgrid()
        {
            ClassConnection classConnection = new ClassConnection();
            SqlConnection sqlConnection = classConnection.GetConnection();
            sqlConnection.Open();
            string sql = "Select * from Item";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewItemupdate.DataSource = dt;
            sqlConnection.Close() ;
        }

        private void comboBoxItemname_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxItemname.SelectedIndex == -1)
            {

                e.Cancel = true;
                errorProvider1.SetError(comboBoxItemname, "Please select a Item.");
            }
            else
            {

                errorProvider1.SetError(comboBoxItemname, "");
            }
        }

        private void textboxQuantity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textboxQuantity.Text))
            {

                e.Cancel = true;
                errorProvider2.SetError(textboxQuantity, "Quantity cannot be empty.");
            }
            else if (!int.TryParse(textboxQuantity.Text, out int Quantity))
            {
                e.Cancel = true;
                errorProvider2.SetError(textboxQuantity, "Quantity must be a valid number.");
            }
            else
            {

                errorProvider2.SetError(textboxQuantity, "");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            comboBoxItemname.SelectedIndex = -1;
            textboxQuantity.Clear();
        }

        private void comboBoxItemname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
