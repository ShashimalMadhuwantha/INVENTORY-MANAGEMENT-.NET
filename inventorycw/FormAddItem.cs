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
    public partial class FormAddItem : Form
    {
       
        public FormAddItem()
        {
            InitializeComponent();
            comboBoxItemtype.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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

        private void aDDMEMBERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this .Hide();   
            FormAddMember formAddMember = new FormAddMember();
            formAddMember.Show();
        }

        private void pURCHASINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide ();
            FormPurchasing formPurchasing = new FormPurchasing();
            formPurchasing.Show();
        }

        private void mEMBERPURCHASINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberPurchasing memberPurchasing = new MemberPurchasing();
            memberPurchasing.Show();
        }

        private void iNVENTORYSTATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInventorySate formInventorySate = new FormInventorySate();
            formInventorySate.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try {
                ClassConnection classConnection = new ClassConnection();
                SqlConnection sqlConnection = classConnection.GetConnection();
                sqlConnection.Open();
                string newItemId = "I0001";
                string maxItemId = null;
                string sql = "SELECT MAX(Item_Id) FROM Item";                      // get max item id sql query
                SqlCommand cmd = new SqlCommand(sql,sqlConnection);                //get max id

                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    maxItemId = (string)result;              
                    int currentMaxId = int.Parse(maxItemId.Substring(1));
                    newItemId = "I" + (currentMaxId + 1).ToString("D4");
                }
                string insert = "Insert into Item(Item_Id,name,Quantity,Supplier_Id,Admin_Id,type,price)" + "values('" + newItemId + "','" + textBoxItemname.Text + "','" + textBoxquantity.Text + "','" + comboBoxSupplier.SelectedValue.ToString() + "','A001','" + comboBoxItemtype.SelectedItem.ToString() + "','" + textBoxPrice.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(insert,sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Item Added");

            }
            catch (Exception ex)
            {
                throw ex;
            }



        }

        private void Bindcombobox()
        {
            ClassConnection classConnection = new ClassConnection();
            SqlConnection sqlConnection = classConnection.GetConnection();
            sqlConnection.Open();
            string sql = "Select Supplier_Id,Name from Supplier";
            SqlCommand cmd = new SqlCommand(sql,sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            comboBoxSupplier.DataSource = dt;
            comboBoxSupplier.ValueMember = "Supplier_Id";
            comboBoxSupplier.DisplayMember= "Name";
            comboBoxSupplier.SelectedIndex = -1;
            comboBoxSupplier.Text = "Select a Supplier";
            sqlConnection.Close();
        }

        private void FormAddItem_Load(object sender, EventArgs e)
        {
             Bindcombobox();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxItemname.Text = "";
            textBoxPrice.Text = "";
            textBoxquantity.Text = "";
            comboBoxItemtype.SelectedIndex = 0;
            comboBoxSupplier.SelectedIndex = -1;
        }

        private void textBoxItemname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxItemname_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxItemname.Text==String.Empty)
            {
                
                e.Cancel = true;
                errorProvider1.SetError(textBoxItemname, "Item name cannot be empty.");
            }
            else
            {
                e.Cancel = false;
                
                errorProvider1.SetError(textBoxItemname, "");
            }
        }

        private void textBoxquantity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxquantity.Text))
            {

                e.Cancel = true;
                errorProvider2.SetError(textBoxquantity, "Quantity cannot be empty.");
            }
              else if (!int.TryParse(textBoxquantity.Text, out int Quantity))
            {
                e.Cancel = true;
                errorProvider2.SetError(textBoxquantity, "Quantity must be a valid number.");
            }
            else
            {
                e.Cancel= false;
                errorProvider2.SetError(textBoxquantity, "");
            }
        }

        private void comboBoxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSupplier_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxSupplier.SelectedIndex == -1)
            {
                
                e.Cancel = true;
                errorProvider3.SetError(comboBoxSupplier, "Please select a category.");
            }
            else
            {
                
                errorProvider3.SetError(comboBoxSupplier, "");
            }
        }

        private void comboBoxItemtype_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxItemtype.SelectedIndex == 0)
            {

                e.Cancel = true;
                errorProvider4.SetError(comboBoxItemtype, "Please select a category.");
            }
            else
            {

                errorProvider4.SetError(comboBoxItemtype, "");
            }
        }

        private void comboBoxItemtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPrice.Text))
            {

                e.Cancel = true;
                errorProvider5.SetError(textBoxPrice, "Price cannot be empty.");
            }
            else if (!float.TryParse(textBoxPrice.Text, out float price))
            {
                e.Cancel = true;
                errorProvider5.SetError(textBoxPrice, "Price must be a valid number.");
            }
            else
            {

                errorProvider5.SetError(textBoxPrice, "");
            }
        }
    }
}
