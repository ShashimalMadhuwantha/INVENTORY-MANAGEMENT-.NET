namespace inventorycw
{
    partial class FormRemoveMembers
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.dataGridViewMemberdetails = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelMemberdshow = new System.Windows.Forms.Label();
            this.textBoxMemberId = new System.Windows.Forms.TextBox();
            this.labelMemberId = new System.Windows.Forms.Label();
            this.panelMemberpurchasing = new System.Windows.Forms.Panel();
            this.labelRemoveMembers = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNVENTORYSTATEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMemberdetails)).BeginInit();
            this.panelMemberpurchasing.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.buttonRemove);
            this.panel1.Controls.Add(this.dataGridViewMemberdetails);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.labelMemberdshow);
            this.panel1.Controls.Add(this.textBoxMemberId);
            this.panel1.Controls.Add(this.labelMemberId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 459);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(548, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(305, 174);
            this.dataGridView1.TabIndex = 31;
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.DarkGray;
            this.buttonRemove.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.Location = new System.Drawing.Point(254, 98);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(131, 43);
            this.buttonRemove.TabIndex = 30;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // dataGridViewMemberdetails
            // 
            this.dataGridViewMemberdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMemberdetails.Location = new System.Drawing.Point(112, 273);
            this.dataGridViewMemberdetails.Name = "dataGridViewMemberdetails";
            this.dataGridViewMemberdetails.RowHeadersWidth = 51;
            this.dataGridViewMemberdetails.RowTemplate.Height = 24;
            this.dataGridViewMemberdetails.Size = new System.Drawing.Size(655, 174);
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
            this.labelMemberdshow.Location = new System.Drawing.Point(307, 245);
            this.labelMemberdshow.Name = "labelMemberdshow";
            this.labelMemberdshow.Size = new System.Drawing.Size(225, 25);
            this.labelMemberdshow.TabIndex = 17;
            this.labelMemberdshow.Text = "MEMBER DETAILS";
            // 
            // textBoxMemberId
            // 
            this.textBoxMemberId.Location = new System.Drawing.Point(254, 42);
            this.textBoxMemberId.Multiline = true;
            this.textBoxMemberId.Name = "textBoxMemberId";
            this.textBoxMemberId.Size = new System.Drawing.Size(256, 25);
            this.textBoxMemberId.TabIndex = 12;
            this.textBoxMemberId.TextChanged += new System.EventHandler(this.textBoxMemberId_TextChanged);
            this.textBoxMemberId.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxMemberId_Validating);
            // 
            // labelMemberId
            // 
            this.labelMemberId.AutoSize = true;
            this.labelMemberId.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelMemberId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMemberId.ForeColor = System.Drawing.Color.Black;
            this.labelMemberId.Location = new System.Drawing.Point(28, 40);
            this.labelMemberId.Name = "labelMemberId";
            this.labelMemberId.Size = new System.Drawing.Size(125, 23);
            this.labelMemberId.TabIndex = 4;
            this.labelMemberId.Text = "MEMBER ID";
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
            this.panelMemberpurchasing.TabIndex = 4;
            this.panelMemberpurchasing.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMemberpurchasing_Paint);
            // 
            // labelRemoveMembers
            // 
            this.labelRemoveMembers.AutoSize = true;
            this.labelRemoveMembers.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRemoveMembers.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemoveMembers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRemoveMembers.Location = new System.Drawing.Point(259, 41);
            this.labelRemoveMembers.Name = "labelRemoveMembers";
            this.labelRemoveMembers.Size = new System.Drawing.Size(346, 37);
            this.labelRemoveMembers.TabIndex = 0;
            this.labelRemoveMembers.Text = "REMOVE MEMBERS";
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormRemoveMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMemberpurchasing);
            this.Name = "FormRemoveMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRemoveMembers";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMemberdetails)).EndInit();
            this.panelMemberpurchasing.ResumeLayout(false);
            this.panelMemberpurchasing.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewMemberdetails;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelMemberdshow;
        private System.Windows.Forms.TextBox textBoxMemberId;
        private System.Windows.Forms.Label labelMemberId;
        private System.Windows.Forms.Panel panelMemberpurchasing;
        private System.Windows.Forms.Label labelRemoveMembers;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNVENTORYSTATEToolStripMenuItem;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}