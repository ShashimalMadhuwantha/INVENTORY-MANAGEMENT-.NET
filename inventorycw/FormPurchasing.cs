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
    public partial class FormPurchasing : Form
    {
      
        string newBuyerId = "";
        int bill = 0;
        string newItemlistId = "";

        public FormPurchasing()
        {
            InitializeComponent();
        }

        private void FormPurchasing_Load(object sender, EventArgs e)
        {
            bindcombo();
        }

        private void bindcombo()
        {
            ClassConnection classConnection = new ClassConnection();
            SqlConnection sqlConnection = classConnection.GetConnection();
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT Item_Id, Name FROM Item where Quantity>0", sqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboBoxItemname.DataSource = dt;
                comboBoxItemname.ValueMember = "Item_Id";
                comboBoxItemname.DisplayMember = "Name";
                comboBoxItemname.SelectedIndex = -1;
                comboBoxItemname.Text = "Select an item";
            
        }

        private void dashBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDashboard formDashboard = new FormDashboard();
            formDashboard.ShowDialog();
        }

        private void aDDSUPPLIERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddSupplier formAddSupplier = new FormAddSupplier();
            formAddSupplier.ShowDialog();
        }

        private void aDDMEMBERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddMember formAddMember = new FormAddMember();
            formAddMember.ShowDialog();
        }

        private void pURCHASINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddItem formAddItem = new FormAddItem();
            formAddItem.ShowDialog();
        }

        private void mEMBERPURCHASINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberPurchasing memberPurchasing = new MemberPurchasing();
            memberPurchasing.ShowDialog();
        }

        private void iNVENTORYSTATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInventorySate formInventorySate = new FormInventorySate();
            formInventorySate.ShowDialog();
        }

        private void buttonAddAnotheritem_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxItemname.SelectedValue == null)
                {
                    MessageBox.Show("Please select an item.");
                    return;
                }

                newItemlistId = "L0001";
                string maxItemlistId = null;
                int quantity = Convert.ToInt32(textBoxItemquantity.Text);
                ClassConnection classConnection = new ClassConnection();
                SqlConnection sqlConnection = classConnection.GetConnection();
                sqlConnection.Open();
                using (SqlConnection conn =sqlConnection )
                {
                  

                    string checkQuantity = "SELECT Quantity FROM Item WHERE Item_Id = @Item_Id";
                    SqlCommand checkQuantityCmd = new SqlCommand(checkQuantity, conn);
                    checkQuantityCmd.Parameters.AddWithValue("@Item_Id", comboBoxItemname.SelectedValue);
                    int availableQuantity = Convert.ToInt32(checkQuantityCmd.ExecuteScalar());

                    if (availableQuantity < quantity)
                    {
                        MessageBox.Show("Not enough quantity available.");
                        return;
                    }

                    string updateQuantity = "UPDATE Item SET Quantity = Quantity - @Quantity WHERE Item_Id = @Item_Id";
                    SqlCommand updateQuantityCmd = new SqlCommand(updateQuantity, conn);
                    updateQuantityCmd.Parameters.AddWithValue("@Quantity", quantity);
                    updateQuantityCmd.Parameters.AddWithValue("@Item_Id", comboBoxItemname.SelectedValue);
                    updateQuantityCmd.ExecuteNonQuery();

                    string sql = "SELECT MAX(PlistId) FROM PurchasedItem";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    object result1 = cmd.ExecuteScalar();
                    if (result1 != DBNull.Value && result1 != null)
                    {
                        maxItemlistId = (string)result1;
                        int currentMaxId = int.Parse(maxItemlistId.Substring(1));
                        newItemlistId = "L" + (currentMaxId + 1).ToString("D4");
                    }

                    string insert = "INSERT INTO PurchasedItem (PlistId, Buyer_Id, Item_Id, Quantity, Total) VALUES (@PlistId, @Buyer_Id, @Item_Id, @Quantity, @Total)";
                    SqlCommand insertCmd = new SqlCommand(insert, conn);

                    insertCmd.Parameters.AddWithValue("@PlistId", newItemlistId);
                    insertCmd.Parameters.AddWithValue("@Buyer_Id", newBuyerId);
                    insertCmd.Parameters.AddWithValue("@Item_Id", comboBoxItemname.SelectedValue);
                    insertCmd.Parameters.AddWithValue("@Quantity", quantity);
                    insertCmd.Parameters.AddWithValue("@Total", DBNull.Value);

                    insertCmd.ExecuteNonQuery();

                    string ip = "SELECT Price FROM Item WHERE Item_Id = @Item_Id";
                    SqlCommand sqlCommand1 = new SqlCommand(ip, conn);
                    sqlCommand1.Parameters.AddWithValue("@Item_Id", comboBoxItemname.SelectedValue);
                    object result = sqlCommand1.ExecuteScalar();
                    int price = Convert.ToInt32(result);
                    int itemTotal = price * quantity;
                    bill += itemTotal; // Update bill with item total
                  

                        string sql1= "UPDATE PurchasedItem SET Total = @Total WHERE PlistId = @PlistId";
                        SqlCommand sqlCmd = new SqlCommand(sql1,conn);
                        sqlCmd.Parameters.AddWithValue("@Total", itemTotal);
                        sqlCmd.Parameters.AddWithValue("@PlistId", newItemlistId);
                        sqlCmd.ExecuteNonQuery();
                        textBoxtotalbill.Text = bill.ToString();
                     
                    
                    MessageBox.Show("Item added to the purchased list. Total: " + itemTotal);

                    textBoxItemquantity.Text = "";
                    textBoxtotalbill.Text = bill.ToString(); 
                    comboBoxItemname.SelectedIndex = -1;
                    comboBoxItemname.Text = "Select an item";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonAddBuyer_Click(object sender, EventArgs e)
        {
            try
            {
                ClassConnection classConnection = new ClassConnection();
                SqlConnection sqlConnection = classConnection.GetConnection();
                sqlConnection.Open();
                newBuyerId = "B0001";
                string maxBuyerId = null;

                using (SqlConnection conn = sqlConnection)
                {
                 
                    string sql = "SELECT MAX(Buyer_Id) FROM Buyer";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        maxBuyerId = (string)result;
                        int currentMaxId = int.Parse(maxBuyerId.Substring(1));
                        newBuyerId = "B" + (currentMaxId + 1).ToString("D4");
                    }

                    string insert = "INSERT INTO Buyer (Buyer_Id, Name) VALUES (@Buyer_Id, @Name)";
                    SqlCommand command = new SqlCommand(insert, conn);
                    command.Parameters.AddWithValue("@Buyer_Id", newBuyerId);
                    command.Parameters.AddWithValue("@Name", textBoxBuyername.Text);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Successfully saved the Buyer");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBoxBuyername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxBuyername.Text))
            {

                e.Cancel = true;
                errorProvider1.SetError(textBoxBuyername, "Buyer name cannot be empty.");
            }
            else
            {

                errorProvider1.SetError(textBoxBuyername, "");
            }
    }

        private void textBoxItemquantity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxItemquantity.Text))
            {

                e.Cancel = true;
                errorProvider3.SetError(textBoxItemquantity, "Quantity cannot be empty.");
            }
            else if (!int.TryParse(textBoxItemquantity.Text, out int Quantity))
            {
                e.Cancel = true;
                errorProvider3.SetError(textBoxItemquantity, "Quantity must be a valid number.");
            }
            else
            {

                errorProvider3.SetError(textBoxItemquantity, "");
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxtotalbill.Clear();
            textBoxBuyername.Clear();
            textBoxItemquantity.Clear();
            comboBoxItemname.SelectedIndex = -1;
        }
    }
   
}