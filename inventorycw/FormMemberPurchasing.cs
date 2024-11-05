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
    public partial class MemberPurchasing : Form
    {
      
        string newItemlistId = "";
        int tot;
        int bill = 0;
        string buyerId = ""; // Class-level variable to store buyer ID

        public MemberPurchasing()
        {
            InitializeComponent();
        }

        private void MemberPurchasing_Load(object sender, EventArgs e)
        {
            Bindcombobox();

        }

        private void labelItemname_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxItemname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDashboard formDashboard = new FormDashboard();
            formDashboard.Show();
        }

        private void pURCHASINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddItem addItem = new FormAddItem();
            addItem.Show();
        }

        private void aDDSUPPLIERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddSupplier supplier = new FormAddSupplier();
            supplier.Show();
        }

        private void aDDMEMBERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddMember member = new FormAddMember();
            member.Show();
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
            FormInventorySate inventorySate = new FormInventorySate();
            inventorySate.Show();
        }

        private void Bindcombobox()
        {
            ClassConnection classConnection = new ClassConnection();
            SqlConnection sqlConnection = classConnection.GetConnection();
            sqlConnection.Open();
            string sql = "Select Item_Id,name from Item where Quantity>0";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            comboBoxItemname.DataSource = dt;
            comboBoxItemname.ValueMember = "Item_Id";
            comboBoxItemname.DisplayMember = "name";
            comboBoxItemname.SelectedIndex = -1;
            comboBoxItemname.Text = "Select an Item";
            sqlConnection.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ClassConnection classConnection = new ClassConnection();
            SqlConnection sqlConnection = classConnection.GetConnection();
            sqlConnection.Open();
            string sql = "Select NIC, Valid_time, MemberId from Member Where MemberId='" + textBoxMemberId.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql,sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewMemberdetails.DataSource = dt;

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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ClassConnection classConnection = new ClassConnection();
                SqlConnection sqlConnection = classConnection.GetConnection();
                sqlConnection.Open();
                if (comboBoxItemname.SelectedValue == null)
                {
                    MessageBox.Show("Please select an item.");
                    return;
                }

                if (string.IsNullOrEmpty(buyerId))
                {
                    MessageBox.Show("Please search and select a member first.");
                    return;
                }

                 newItemlistId = "L0001";
                string maxItemlistId = null;
                int quantity = Convert.ToInt32(textBoxtemquantity.Text);
                using (SqlConnection conn = sqlConnection)
                {
                 

                    string checkQuantity = "SELECT Quantity FROM Item WHERE Item_Id = @Item_Id";
                    SqlCommand checkQuantityCmd = new SqlCommand(checkQuantity, sqlConnection);
                    checkQuantityCmd.Parameters.AddWithValue("@Item_Id", comboBoxItemname.SelectedValue);
                    int availableQuantity = Convert.ToInt32(checkQuantityCmd.ExecuteScalar());

                    if (availableQuantity < quantity)
                    {
                        MessageBox.Show("Not enough quantity available.");
                        return;
                    }

                    string updateQuantity = "UPDATE Item SET Quantity = Quantity - @Quantity WHERE Item_Id = @Item_Id";
                    SqlCommand updateQuantityCmd = new SqlCommand(updateQuantity, sqlConnection);
                    updateQuantityCmd.Parameters.AddWithValue("@Quantity", quantity);
                    updateQuantityCmd.Parameters.AddWithValue("@Item_Id", comboBoxItemname.SelectedValue);
                    updateQuantityCmd.ExecuteNonQuery();

                    string sql = "SELECT MAX(PlistId) FROM PurchasedItem";
                    SqlCommand cmd = new SqlCommand(sql, sqlConnection);

                    object result1 = cmd.ExecuteScalar();
                    if (result1 != DBNull.Value && result1 != null)
                    {
                        maxItemlistId = (string)result1;
                        int currentMaxId = int.Parse(maxItemlistId.Substring(1));
                        newItemlistId = "L" + (currentMaxId + 1).ToString("D4");
                    }

                    string sql1 = "SELECT Buyer_Id FROM Member WHERE MemberId = @MemberId";
                    SqlCommand command = new SqlCommand(sql1, sqlConnection);
                    command.Parameters.AddWithValue("@MemberId", textBoxMemberId.Text);
                    object result = command.ExecuteScalar();

                    string insert = "INSERT INTO PurchasedItem (PlistId, Buyer_Id, Item_Id, Quantity, Total) VALUES (@PlistId, @Buyer_Id, @Item_Id, @Quantity, NULL)";
                    SqlCommand insertCmd = new SqlCommand(insert, sqlConnection);
                    insertCmd.Parameters.AddWithValue("@PlistId", newItemlistId);
                    insertCmd.Parameters.AddWithValue("@Buyer_Id", result.ToString());
                    insertCmd.Parameters.AddWithValue("@Item_Id", comboBoxItemname.SelectedValue.ToString());
                    insertCmd.Parameters.AddWithValue("@Quantity", textBoxtemquantity.Text);

                    insertCmd.ExecuteNonQuery();

                    string ip = "SELECT Price FROM Item WHERE Item_Id = @Item_Id";
                    SqlCommand sqlCommand1 = new SqlCommand(ip, sqlConnection);
                    sqlCommand1.Parameters.AddWithValue("@Item_Id", comboBoxItemname.SelectedValue);
                    object priceResult = sqlCommand1.ExecuteScalar();
                    int price = Convert.ToInt32(priceResult);
                    tot = price * quantity;
                    bill += tot;
                    string sq= "UPDATE PurchasedItem SET Total = @Total WHERE PlistId = @PlistId";
                    SqlCommand sqlCmd = new SqlCommand(sq,sqlConnection);
                    sqlCmd.Parameters.AddWithValue("@Total", tot);
                    sqlCmd.Parameters.AddWithValue("@PlistId", newItemlistId.ToString());
                    sqlCmd.ExecuteNonQuery();
                 
                  
                    MessageBox.Show("Item added to the purchased list. Total: " + tot);

                    textBoxtemquantity.Text = "";
                    textBoxtotalbill.Text = "";
                    comboBoxItemname.SelectedIndex = -1;
                    comboBoxItemname.Text = "Select an item";
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panelMemberpurchasing_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if(!radioButtonyes.Checked && !radioButtonNo.Checked)
            {
                MessageBox.Show("Select offer amount show");
            }
            else
            {
                int offer = bill * 10 / 100;
                if (radioButtonyes.Checked)
                {

                    textBoxtotaloffer.Text = offer.ToString();



                }
                bill = bill - offer;
                textBoxtotalbill.Text = bill.ToString();
            }
           
           
        }

        private void textBoxMemberId_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxMemberId.Text))
            {

                e.Cancel = true;
                errorProvider1.SetError(textBoxMemberId, "Member ID cannot be empty.");
            }
            else
            {

                errorProvider1.SetError(textBoxMemberId, "");
            }
        }

        private void comboBoxItemname_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxItemname.SelectedIndex == -1)
            {

                e.Cancel = true;
                errorProvider2.SetError(comboBoxItemname, "Please select a Item.");
            }
            else
            {

                errorProvider2.SetError(comboBoxItemname, "");
            }
        }

        private void textBoxtemquantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxtemquantity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxtemquantity.Text))
            {

                e.Cancel = true;
                errorProvider3.SetError(textBoxtemquantity, "Item quantity cannot be empty.");
            }
            else if (!int.TryParse(textBoxtemquantity.Text, out int Quantity))
            {
                e.Cancel = true;
                errorProvider3.SetError(textBoxtemquantity, "Quantity must be a valid number.");
            }
            else
            {

                errorProvider3.SetError(textBoxtemquantity, "");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxMemberId.Clear();
            textBoxtemquantity.Clear();
            comboBoxItemname.SelectedIndex = -1;
            textBoxtotalbill.Clear();
            textBoxtotaloffer.Clear();

        }
    }
}
