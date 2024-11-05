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
    public partial class FormAddMember : Form
    {
      
        
        string newBuyerId = "B1";
        string maxBuyerId = null;
        public FormAddMember()
        {
            InitializeComponent();
        }

        private void FormAddMember_Load(object sender, EventArgs e)
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
            FormAddSupplier formAddSupplier = new FormAddSupplier();    
            formAddSupplier.Show();
        }

        private void aDDMEMBERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddItem formAddItem = new FormAddItem();
            formAddItem.Show();
        }

        private void pURCHASINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPurchasing formPurchasing = new FormPurchasing();
            formPurchasing.Show();
        }

        private void mEMBERPURCHASINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this .Hide();
            MemberPurchasing memberPurchasing = new MemberPurchasing();
            memberPurchasing.Show();
        }

        private void iNVENTORYSTATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide ();
            FormInventorySate formInventorySate = new FormInventorySate();
            formInventorySate.Show();
        }
       

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ClassConnection classConnection = new ClassConnection();
                SqlConnection sqlConnection = classConnection.GetConnection();
                sqlConnection.Open();
             
                string newBuyerId = "B0001";
                string maxBuyerId = null;

               

                    string sql = "SELECT MAX(Buyer_Id) FROM Buyer";
                    SqlCommand cmd = new SqlCommand(sql, sqlConnection);

                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        maxBuyerId = (string)result;
                        int currentMaxId = int.Parse(maxBuyerId.Substring(1));
                        newBuyerId = "B" + (currentMaxId + 1).ToString("D4"); // Formats the ID with leading zeros to ensure consistent length
                    }
                

                string insert = "Insert into Buyer(Buyer_Id,Name)"+"values('"+newBuyerId+"','"+textBoxMembername.Text+"')";
                SqlCommand command = new SqlCommand(insert, sqlConnection);
                command.ExecuteNonQuery();
                string sql1 = "Insert into Member(Buyer_Id,NIC,Valid_time,MemberId)"+"values('"+newBuyerId+"','"+textBoxNIC.Text+"','"+textBoxValidtime.Text+"','"+textBoxMemberId.Text+"')";
                SqlCommand command1 = new SqlCommand(sql1, sqlConnection);
                command1.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Successfully saved the Member");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBoxMembername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxMembername.Text))
            {
                
                e.Cancel = true;
                errorProvider1.SetError(textBoxMembername, "Membername cannot be empty.");
            }
            else
            {
                
                errorProvider1.SetError(textBoxMembername, "");
            }
        }

        private void textBoxNIC_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNIC.Text))
            {
              
                e.Cancel = true;
                errorProvider2.SetError(textBoxNIC, "NIC cannot be empty.");
            }
            else
            {
               
                errorProvider2.SetError(textBoxNIC, "");
            }
        }

        private void textBoxValidtime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxValidtime.Text))
            {
             
                e.Cancel = true;
                errorProvider3.SetError(textBoxValidtime, "Validtime cannot be empty.");
            }
            else
            {
               
                errorProvider3.SetError(textBoxValidtime, "");
            }
        }

        private void textBoxMemberId_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxMemberId.Text))
            {
              
                e.Cancel = true;
                errorProvider4.SetError(textBoxMemberId, "Member_Id cannot be empty.");
            }
            else
            {
              
                errorProvider4.SetError(textBoxMemberId, "");
            }
        }

        private void buttonCLear_Click(object sender, EventArgs e)
        {
            textBoxMemberId.Text = "";
            textBoxMembername.Text = "";
            textBoxNIC.Text = "";
            textBoxValidtime.Text = "";
            

        }
    }
}
