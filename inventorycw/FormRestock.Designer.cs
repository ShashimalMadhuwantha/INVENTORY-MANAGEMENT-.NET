namespace inventorycw
{
    partial class FormRestock
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
            this.panelMemberpurchasing = new System.Windows.Forms.Panel();
            this.labelRestocking = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDSUPPLIERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDMEMBERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Additem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchasing = new System.Windows.Forms.ToolStripMenuItem();
            this.iNVENTORYSTATEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelITEMname = new System.Windows.Forms.Label();
            this.labelQUantity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRestock = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textboxQuantity = new System.Windows.Forms.TextBox();
            this.comboBoxItemname = new System.Windows.Forms.ComboBox();
            this.dataGridViewItemupdate = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelMemberpurchasing.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemupdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMemberpurchasing
            // 
            this.panelMemberpurchasing.BackColor = System.Drawing.Color.SeaGreen;
            this.panelMemberpurchasing.Controls.Add(this.labelRestocking);
            this.panelMemberpurchasing.Controls.Add(this.menuStrip1);
            this.panelMemberpurchasing.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMemberpurchasing.Location = new System.Drawing.Point(0, 0);
            this.panelMemberpurchasing.Name = "panelMemberpurchasing";
            this.panelMemberpurchasing.Size = new System.Drawing.Size(877, 96);
            this.panelMemberpurchasing.TabIndex = 3;
            // 
            // labelRestocking
            // 
            this.labelRestocking.AutoSize = true;
            this.labelRestocking.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRestocking.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRestocking.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRestocking.Location = new System.Drawing.Point(321, 43);
            this.labelRestocking.Name = "labelRestocking";
            this.labelRestocking.Size = new System.Drawing.Size(225, 37);
            this.labelRestocking.TabIndex = 0;
            this.labelRestocking.Text = "RESTOCKING";
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
            this.Additem,
            this.purchasing,
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
            // Additem
            // 
            this.Additem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Additem.Name = "Additem";
            this.Additem.Size = new System.Drawing.Size(101, 23);
            this.Additem.Text = "ADD ITEM";
            this.Additem.Click += new System.EventHandler(this.pURCHASINGToolStripMenuItem_Click);
            // 
            // purchasing
            // 
            this.purchasing.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.purchasing.Name = "purchasing";
            this.purchasing.Size = new System.Drawing.Size(128, 23);
            this.purchasing.Text = "PURCHASING";
            this.purchasing.Click += new System.EventHandler(this.mEMBERPURCHASINGToolStripMenuItem_Click);
            // 
            // iNVENTORYSTATEToolStripMenuItem
            // 
            this.iNVENTORYSTATEToolStripMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.iNVENTORYSTATEToolStripMenuItem.Name = "iNVENTORYSTATEToolStripMenuItem";
            this.iNVENTORYSTATEToolStripMenuItem.Size = new System.Drawing.Size(163, 23);
            this.iNVENTORYSTATEToolStripMenuItem.Text = "INVENTORY STATE";
            this.iNVENTORYSTATEToolStripMenuItem.Click += new System.EventHandler(this.iNVENTORYSTATEToolStripMenuItem_Click);
            // 
            // labelITEMname
            // 
            this.labelITEMname.AutoSize = true;
            this.labelITEMname.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelITEMname.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelITEMname.ForeColor = System.Drawing.Color.Black;
            this.labelITEMname.Location = new System.Drawing.Point(64, 146);
            this.labelITEMname.Name = "labelITEMname";
            this.labelITEMname.Size = new System.Drawing.Size(151, 25);
            this.labelITEMname.TabIndex = 4;
            this.labelITEMname.Text = "ITEM NAME";
            // 
            // labelQUantity
            // 
            this.labelQUantity.AutoSize = true;
            this.labelQUantity.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelQUantity.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQUantity.ForeColor = System.Drawing.Color.Black;
            this.labelQUantity.Location = new System.Drawing.Point(64, 227);
            this.labelQUantity.Name = "labelQUantity";
            this.labelQUantity.Size = new System.Drawing.Size(100, 25);
            this.labelQUantity.TabIndex = 5;
            this.labelQUantity.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(64, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 6;
            // 
            // buttonRestock
            // 
            this.buttonRestock.BackColor = System.Drawing.Color.DarkGray;
            this.buttonRestock.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestock.Location = new System.Drawing.Point(49, 305);
            this.buttonRestock.Name = "buttonRestock";
            this.buttonRestock.Size = new System.Drawing.Size(156, 43);
            this.buttonRestock.TabIndex = 14;
            this.buttonRestock.Text = "RESTOCK";
            this.buttonRestock.UseVisualStyleBackColor = false;
            this.buttonRestock.Click += new System.EventHandler(this.buttonRestock_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.DarkGray;
            this.buttonClear.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(276, 305);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(131, 43);
            this.buttonClear.TabIndex = 15;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textboxQuantity
            // 
            this.textboxQuantity.ForeColor = System.Drawing.Color.Black;
            this.textboxQuantity.Location = new System.Drawing.Point(234, 228);
            this.textboxQuantity.Multiline = true;
            this.textboxQuantity.Name = "textboxQuantity";
            this.textboxQuantity.Size = new System.Drawing.Size(256, 25);
            this.textboxQuantity.TabIndex = 16;
            this.textboxQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.textboxQuantity_Validating);
            // 
            // comboBoxItemname
            // 
            this.comboBoxItemname.FormattingEnabled = true;
            this.comboBoxItemname.Location = new System.Drawing.Point(234, 146);
            this.comboBoxItemname.Name = "comboBoxItemname";
            this.comboBoxItemname.Size = new System.Drawing.Size(256, 24);
            this.comboBoxItemname.TabIndex = 18;
            this.comboBoxItemname.SelectedIndexChanged += new System.EventHandler(this.comboBoxItemname_SelectedIndexChanged);
            this.comboBoxItemname.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxItemname_Validating);
            // 
            // dataGridViewItemupdate
            // 
            this.dataGridViewItemupdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItemupdate.Location = new System.Drawing.Point(38, 377);
            this.dataGridViewItemupdate.Name = "dataGridViewItemupdate";
            this.dataGridViewItemupdate.RowHeadersWidth = 51;
            this.dataGridViewItemupdate.RowTemplate.Height = 24;
            this.dataGridViewItemupdate.Size = new System.Drawing.Size(823, 164);
            this.dataGridViewItemupdate.TabIndex = 19;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // FormRestock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(877, 553);
            this.Controls.Add(this.dataGridViewItemupdate);
            this.Controls.Add(this.comboBoxItemname);
            this.Controls.Add(this.textboxQuantity);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRestock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelQUantity);
            this.Controls.Add(this.labelITEMname);
            this.Controls.Add(this.panelMemberpurchasing);
            this.Name = "FormRestock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRestock";
            this.Load += new System.EventHandler(this.FormRestock_Load);
            this.panelMemberpurchasing.ResumeLayout(false);
            this.panelMemberpurchasing.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemupdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMemberpurchasing;
        private System.Windows.Forms.Label labelRestocking;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDSUPPLIERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDMEMBERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Additem;
        private System.Windows.Forms.ToolStripMenuItem purchasing;
        private System.Windows.Forms.ToolStripMenuItem iNVENTORYSTATEToolStripMenuItem;
        private System.Windows.Forms.Label labelITEMname;
        private System.Windows.Forms.Label labelQUantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRestock;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textboxQuantity;
        private System.Windows.Forms.ComboBox comboBoxItemname;
        private System.Windows.Forms.DataGridView dataGridViewItemupdate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}