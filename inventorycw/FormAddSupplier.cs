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
    public partial class FormAddSupplier : Form
    {
        public FormAddSupplier()
        {
            InitializeComponent();
            comboBoxCity.SelectedIndex = 0;
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
           FormAddItem formAddItem = new FormAddItem();
            formAddItem.Show();
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

        private void FormAddSupplier_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ClassConnection classConnection = new ClassConnection();
                SqlConnection sqlConnection = classConnection.GetConnection();
                sqlConnection.Open();
                string newSupplierId = "S0001";
                string maxSupplierId = null;
                string sql = "SELECT MAX(Supplier_Id) FROM Supplier";                                           // get max supplier id sql query
                SqlCommand cmd = new SqlCommand(sql,sqlConnection);

                object result = cmd.ExecuteScalar();                                                             // get max id
                if (result != DBNull.Value)
                {
                    maxSupplierId = (string)result;   //sid +1
                    int currentMaxId = int.Parse(maxSupplierId.Substring(1));
                    newSupplierId = "S" + (currentMaxId + 1).ToString("D4");
                }

                string insert = "Insert into Supplier(Supplier_Id,Admin_Id,Name,NIC,Contact,City)" + "values('" + newSupplierId + "','A001','" + textBoxSuppliername.Text + "','" + textBoxNIC.Text + "','" + textBoxContactNumber.Text + "','" + comboBoxCity.SelectedItem.ToString() + "')";
                SqlCommand command = new SqlCommand(insert, sqlConnection);
                command.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Successfully saved the Supplier");
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxContactNumber.Text = "";
            textBoxNIC.Text = "";
            textBoxSuppliername.Text = "";
            comboBoxCity.SelectedIndex = 0;
        }

        private void textBoxSuppliername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSuppliername.Text))
            {
               
                e.Cancel = true;
                errorProvider1.SetError(textBoxSuppliername, "Supplier name cannot be empty.");
            }
            else
            {
               
                errorProvider1.SetError(textBoxSuppliername, "");
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

        private void textBoxContactNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxContactNumber.Text))
            {
              
                e.Cancel = true;
                errorProvider3.SetError(textBoxContactNumber, "Contact number cannot be empty.");
            }
            else
            {
              
                errorProvider3.SetError(textBoxContactNumber, "");
            }
        }

        private void comboBoxCity_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxCity.SelectedIndex == 0)
            {
              
                e.Cancel = true;
                errorProvider4.SetError(comboBoxCity, "Please select a category.");
            }
            else
            {
           
                errorProvider4.SetError(comboBoxCity, "");
            }
        }
    }
}
