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
    public partial class FormInventorySate : Form
    {
        public FormInventorySate()
        {
            InitializeComponent();
        }

        private void panelAdditem_Paint(object sender, PaintEventArgs e)
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
            this .Hide();
            MemberPurchasing memberPurchasing = new MemberPurchasing();
            memberPurchasing.Show();
        }

        private void purchasing_Click(object sender, EventArgs e)
        {
            this.Hide ();
            FormPurchasing formPurchasing = new FormPurchasing ();
            formPurchasing.Show();
        }

        private void dataGridViewInventorystate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void datagridinventory()
        {
            ClassConnection classConnection = new ClassConnection();
            SqlConnection sqlConnection = classConnection.GetConnection();
            sqlConnection.Open();
            string sql = "SELECT     Item.name AS ItemName,  Item.Quantity,    Supplier.Name AS SupplierName FROM    Item  INNER JOIN     Supplier ON Item.Supplier_Id = Supplier.Supplier_Id;";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewInventorystate.DataSource = dt;
            sqlConnection.Close();
        }
        private void membergrid()
        {
            ClassConnection classConnection = new ClassConnection();
            SqlConnection sqlConnection = classConnection.GetConnection();
            sqlConnection.Open();
            string sql = "SELECT     Buyer.Name AS MemberName,   Member.MemberId FROM     Member INNER JOIN     Buyer ON Member.Buyer_Id = Buyer.Buyer_Id ";
            SqlDataAdapter adapter = new SqlDataAdapter(sql,sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewMember.DataSource = dt;
            sqlConnection.Close();
        }

        private void FormInventorySate_Load(object sender, EventArgs e)
        {
            datagridinventory();
            membergrid();
        }
    }
}
