namespace inventorycw
{
    partial class FormPurchseHistory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewMemberdetails = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelMemberdshow = new System.Windows.Forms.Label();
            this.textBoxMemberId = new System.Windows.Forms.TextBox();
            this.labelBuyerName = new System.Windows.Forms.Label();
            this.panelMemberpurchasing = new System.Windows.Forms.Panel();
            this.labelRemoveMembers = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNVENTORYSTATEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMemberdetails)).BeginInit();
            this.panelMemberpurchasing.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.dataGridViewMemberdetails);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.labelMemberdshow);
            this.panel1.Controls.Add(this.textBoxMemberId);
            this.panel1.Controls.Add(this.labelBuyerName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 459);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridViewMemberdetails
            // 
            this.dataGridViewMemberdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMemberdetails.Location = new System.Drawing.Point(67, 122);
            this.dataGridViewMemberdetails.Name = "dataGridViewMemberdetails";
            this.dataGridViewMemberdetails.RowHeadersWidth = 51;
            this.dataGridViewMemberdetails.RowTemplate.Height = 24;
            this.dataGridViewMemberdetails.Size = new System.Drawing.Size(768, 325);
            this.dataGridViewMemberdetails.TabIndex = 29;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DarkGray;
            this.buttonSearch.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(528, 30);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(131, 43);
            this.buttonSearch.TabIndex = 22;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelMemberdshow
            // 
            this.labelMemberdshow.AutoSize = true;
            this.labelMemberdshow.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelMemberdshow.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMemberdshow.ForeColor = System.Drawing.Color.Black;
            this.labelMemberdshow.Location = new System.Drawing.Point(331, 94);
            this.labelMemberdshow.Name = "labelMemberdshow";
            this.labelMemberdshow.Size = new System.Drawing.Size(179, 25);
            this.labelMemberdshow.TabIndex = 17;
            this.labelMemberdshow.Text = "Purchase Details";
            // 
            // textBoxMemberId
            // 
            this.textBoxMemberId.Location = new System.Drawing.Point(254, 42);
            this.textBoxMemberId.Multiline = true;
            this.textBoxMemberId.Name = "textBoxMemberId";
            this.textBoxMemberId.Size = new System.Drawing.Size(256, 25);
            this.textBoxMemberId.TabIndex = 12;
            // 
            // labelBuyerName
            // 
            this.labelBuyerName.AutoSize = true;
            this.labelBuyerName.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelBuyerName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuyerName.ForeColor = System.Drawing.Color.Black;
            this.labelBuyerName.Location = new System.Drawing.Point(63, 42);
            this.labelBuyerName.Name = "labelBuyerName";
            this.labelBuyerName.Size = new System.Drawing.Size(115, 23);
            this.labelBuyerName.TabIndex = 4;
            this.labelBuyerName.Text = "Buyer Name";
            // 
            // panelMemberpurchasing
            // 
            this.panelMemberpurchasing.BackColor = System.Drawing.Color.SeaGreen;
            this.panelMemberpurchasing.Controls.Add(this.labelRemoveMembers);
            this.panelMemberpurchasing.Controls.Add(this.menuStrip1);
            this.panelMemberpurchasing.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMemberpurchasing.Location = new System.Drawing.Point(0, 0);
            this.panelMemberpurchasing.Name = "panelMemberpurchasing";
            this.panelMemberpurchasing.Size = new System.Drawing.Size(877, 94);
            this.panelMemberpurchasing.TabIndex = 6;
            // 
            // labelRemoveMembers
            // 
            this.labelRemoveMembers.AutoSize = true;
            this.labelRemoveMembers.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRemoveMembers.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemoveMembers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRemoveMembers.Location = new System.Drawing.Point(293, 43);
            this.labelRemoveMembers.Name = "labelRemoveMembers";
            this.labelRemoveMembers.Size = new System.Drawing.Size(261, 37);
            this.labelRemoveMembers.TabIndex = 0;
            this.labelRemoveMembers.Text = "Purchase History";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashBoardToolStripMenuItem,
            this.iNVENTORYSTATEToolStripMenuItem});
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
            // iNVENTORYSTATEToolStripMenuItem
            // 
            this.iNVENTORYSTATEToolStripMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.iNVENTORYSTATEToolStripMenuItem.Name = "iNVENTORYSTATEToolStripMenuItem";
            this.iNVENTORYSTATEToolStripMenuItem.Size = new System.Drawing.Size(163, 23);
            this.iNVENTORYSTATEToolStripMenuItem.Text = "INVENTORY STATE";
            this.iNVENTORYSTATEToolStripMenuItem.Click += new System.EventHandler(this.iNVENTORYSTATEToolStripMenuItem_Click);
            // 
            // FormPurchseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMemberpurchasing);
            this.Name = "FormPurchseHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPurchseHistory";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMemberdetails)).EndInit();
            this.panelMemberpurchasing.ResumeLayout(false);
            this.panelMemberpurchasing.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewMemberdetails;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelMemberdshow;
        private System.Windows.Forms.TextBox textBoxMemberId;
        private System.Windows.Forms.Label labelBuyerName;
        private System.Windows.Forms.Panel panelMemberpurchasing;
        private System.Windows.Forms.Label labelRemoveMembers;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNVENTORYSTATEToolStripMenuItem;
    }
}