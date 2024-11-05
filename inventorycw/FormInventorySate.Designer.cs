namespace inventorycw
{
    partial class FormInventorySate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelInventorystate = new System.Windows.Forms.Panel();
            this.labelAdditem = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDSUPPLIERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDMEMBERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pURCHASINGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mEMBERPURCHASINGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchasing = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewInventorystate = new System.Windows.Forms.DataGridView();
            this.dataGridViewMember = new System.Windows.Forms.DataGridView();
            this.labelItemdetails = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelInventorystate.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventorystate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMember)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInventorystate
            // 
            this.panelInventorystate.BackColor = System.Drawing.Color.SeaGreen;
            this.panelInventorystate.Controls.Add(this.labelAdditem);
            this.panelInventorystate.Controls.Add(this.menuStrip1);
            this.panelInventorystate.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInventorystate.Location = new System.Drawing.Point(0, 0);
            this.panelInventorystate.Name = "panelInventorystate";
            this.panelInventorystate.Size = new System.Drawing.Size(877, 96);
            this.panelInventorystate.TabIndex = 3;
            this.panelInventorystate.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAdditem_Paint);
            // 
            // labelAdditem
            // 
            this.labelAdditem.AutoSize = true;
            this.labelAdditem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAdditem.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdditem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAdditem.Location = new System.Drawing.Point(301, 42);
            this.labelAdditem.Name = "labelAdditem";
            this.labelAdditem.Size = new System.Drawing.Size(327, 37);
            this.labelAdditem.TabIndex = 0;
            this.labelAdditem.Text = "INVENTORY STATE";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashBoardToolStripMenuItem,
            this.aDDSUPPLIERToolStripMenuItem,
            this.aDDMEMBERToolStripMenuItem,
            this.pURCHASINGToolStripMenuItem,
            this.mEMBERPURCHASINGToolStripMenuItem,
            this.purchasing});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(877, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashBoardToolStripMenuItem
            // 
            this.dashBoardToolStripMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.dashBoardToolStripMenuItem.Name = "dashBoardToolStripMenuItem";
            this.dashBoardToolStripMenuItem.Size = new System.Drawing.Size(98, 23);
            this.dashBoardToolStripMenuItem.Text = "DashBoard";
            this.dashBoardToolStripMenuItem.Click += new System.EventHandler(this.dashBoardToolStripMenuItem_Click);
            // 
            // aDDSUPPLIERToolStripMenuItem
            // 
            this.aDDSUPPLIERToolStripMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.aDDSUPPLIERToolStripMenuItem.Name = "aDDSUPPLIERToolStripMenuItem";
            this.aDDSUPPLIERToolStripMenuItem.Size = new System.Drawing.Size(139, 23);
            this.aDDSUPPLIERToolStripMenuItem.Text = "ADD SUPPLIER";
            this.aDDSUPPLIERToolStripMenuItem.Click += new System.EventHandler(this.aDDSUPPLIERToolStripMenuItem_Click);
            // 
            // aDDMEMBERToolStripMenuItem
            // 
            this.aDDMEMBERToolStripMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.aDDMEMBERToolStripMenuItem.Name = "aDDMEMBERToolStripMenuItem";
            this.aDDMEMBERToolStripMenuItem.Size = new System.Drawing.Size(134, 23);
            this.aDDMEMBERToolStripMenuItem.Text = "ADD MEMBER";
            this.aDDMEMBERToolStripMenuItem.Click += new System.EventHandler(this.aDDMEMBERToolStripMenuItem_Click);
            // 
            // pURCHASINGToolStripMenuItem
            // 
            this.pURCHASINGToolStripMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pURCHASINGToolStripMenuItem.Name = "pURCHASINGToolStripMenuItem";
            this.pURCHASINGToolStripMenuItem.Size = new System.Drawing.Size(101, 23);
            this.pURCHASINGToolStripMenuItem.Text = "ADD ITEM";
            this.pURCHASINGToolStripMenuItem.Click += new System.EventHandler(this.pURCHASINGToolStripMenuItem_Click);
            // 
            // mEMBERPURCHASINGToolStripMenuItem
            // 
            this.mEMBERPURCHASINGToolStripMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.mEMBERPURCHASINGToolStripMenuItem.Name = "mEMBERPURCHASINGToolStripMenuItem";
            this.mEMBERPURCHASINGToolStripMenuItem.Size = new System.Drawing.Size(204, 23);
            this.mEMBERPURCHASINGToolStripMenuItem.Text = "MEMBER PURCHASING";
            this.mEMBERPURCHASINGToolStripMenuItem.Click += new System.EventHandler(this.mEMBERPURCHASINGToolStripMenuItem_Click);
            // 
            // purchasing
            // 
            this.purchasing.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.purchasing.Name = "purchasing";
            this.purchasing.Size = new System.Drawing.Size(128, 23);
            this.purchasing.Text = "PURCHASING";
            this.purchasing.Click += new System.EventHandler(this.purchasing_Click);
            // 
            // dataGridViewInventorystate
            // 
            this.dataGridViewInventorystate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventorystate.Location = new System.Drawing.Point(31, 165);
            this.dataGridViewInventorystate.Name = "dataGridViewInventorystate";
            this.dataGridViewInventorystate.RowHeadersWidth = 51;
            this.dataGridViewInventorystate.RowTemplate.Height = 24;
            this.dataGridViewInventorystate.Size = new System.Drawing.Size(457, 356);
            this.dataGridViewInventorystate.TabIndex = 4;
            this.dataGridViewInventorystate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInventorystate_CellContentClick);
            // 
            // dataGridViewMember
            // 
            this.dataGridViewMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMember.Location = new System.Drawing.Point(535, 165);
            this.dataGridViewMember.Name = "dataGridViewMember";
            this.dataGridViewMember.RowHeadersWidth = 51;
            this.dataGridViewMember.RowTemplate.Height = 24;
            this.dataGridViewMember.Size = new System.Drawing.Size(307, 356);
            this.dataGridViewMember.TabIndex = 5;
            // 
            // labelItemdetails
            // 
            this.labelItemdetails.AutoSize = true;
            this.labelItemdetails.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemdetails.Location = new System.Drawing.Point(193, 119);
            this.labelItemdetails.Name = "labelItemdetails";
            this.labelItemdetails.Size = new System.Drawing.Size(132, 25);
            this.labelItemdetails.TabIndex = 6;
            this.labelItemdetails.Text = "Item Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(630, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Member Details";
            // 
            // FormInventorySate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(877, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelItemdetails);
            this.Controls.Add(this.dataGridViewMember);
            this.Controls.Add(this.dataGridViewInventorystate);
            this.Controls.Add(this.panelInventorystate);
            this.Name = "FormInventorySate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Sate";
            this.Load += new System.EventHandler(this.FormInventorySate_Load);
            this.panelInventorystate.ResumeLayout(false);
            this.panelInventorystate.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventorystate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelInventorystate;
        private System.Windows.Forms.Label labelAdditem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDSUPPLIERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDMEMBERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pURCHASINGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mEMBERPURCHASINGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchasing;
        private System.Windows.Forms.DataGridView dataGridViewInventorystate;
        private System.Windows.Forms.DataGridView dataGridViewMember;
        private System.Windows.Forms.Label labelItemdetails;
        private System.Windows.Forms.Label label1;
    }
}