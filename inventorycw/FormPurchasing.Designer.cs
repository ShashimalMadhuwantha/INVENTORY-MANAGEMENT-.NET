namespace inventorycw
{
    partial class FormPurchasing
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
            this.panelPurchasing = new System.Windows.Forms.Panel();
            this.labelAdditem = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDSUPPLIERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDMEMBERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Additem = new System.Windows.Forms.ToolStripMenuItem();
            this.mEMBERPURCHASINGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNVENTORYSTATEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelBuyername = new System.Windows.Forms.Label();
            this.textBoxBuyername = new System.Windows.Forms.TextBox();
            this.labelItemName = new System.Windows.Forms.Label();
            this.labelItemQuantity = new System.Windows.Forms.Label();
            this.labelTotalbill = new System.Windows.Forms.Label();
            this.buttonAddAnotheritem = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxItemquantity = new System.Windows.Forms.TextBox();
            this.textBoxtotalbill = new System.Windows.Forms.TextBox();
            this.comboBoxItemname = new System.Windows.Forms.ComboBox();
            this.buttonAddBuyer = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelPurchasing.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPurchasing
            // 
            this.panelPurchasing.BackColor = System.Drawing.Color.SeaGreen;
            this.panelPurchasing.Controls.Add(this.labelAdditem);
            this.panelPurchasing.Controls.Add(this.menuStrip1);
            this.panelPurchasing.Location = new System.Drawing.Point(2, 12);
            this.panelPurchasing.Name = "panelPurchasing";
            this.panelPurchasing.Size = new System.Drawing.Size(873, 96);
            this.panelPurchasing.TabIndex = 1;
            // 
            // labelAdditem
            // 
            this.labelAdditem.AutoSize = true;
            this.labelAdditem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAdditem.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdditem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAdditem.Location = new System.Drawing.Point(326, 43);
            this.labelAdditem.Name = "labelAdditem";
            this.labelAdditem.Size = new System.Drawing.Size(226, 37);
            this.labelAdditem.TabIndex = 0;
            this.labelAdditem.Text = "PURCHASING";
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
            this.mEMBERPURCHASINGToolStripMenuItem,
            this.iNVENTORYSTATEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 27);
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
            // mEMBERPURCHASINGToolStripMenuItem
            // 
            this.mEMBERPURCHASINGToolStripMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.mEMBERPURCHASINGToolStripMenuItem.Name = "mEMBERPURCHASINGToolStripMenuItem";
            this.mEMBERPURCHASINGToolStripMenuItem.Size = new System.Drawing.Size(204, 23);
            this.mEMBERPURCHASINGToolStripMenuItem.Text = "MEMBER PURCHASING";
            this.mEMBERPURCHASINGToolStripMenuItem.Click += new System.EventHandler(this.mEMBERPURCHASINGToolStripMenuItem_Click);
            // 
            // iNVENTORYSTATEToolStripMenuItem
            // 
            this.iNVENTORYSTATEToolStripMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.iNVENTORYSTATEToolStripMenuItem.Name = "iNVENTORYSTATEToolStripMenuItem";
            this.iNVENTORYSTATEToolStripMenuItem.Size = new System.Drawing.Size(163, 23);
            this.iNVENTORYSTATEToolStripMenuItem.Text = "INVENTORY STATE";
            this.iNVENTORYSTATEToolStripMenuItem.Click += new System.EventHandler(this.iNVENTORYSTATEToolStripMenuItem_Click);
            // 
            // labelBuyername
            // 
            this.labelBuyername.AutoSize = true;
            this.labelBuyername.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelBuyername.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuyername.ForeColor = System.Drawing.Color.Black;
            this.labelBuyername.Location = new System.Drawing.Point(64, 152);
            this.labelBuyername.Name = "labelBuyername";
            this.labelBuyername.Size = new System.Drawing.Size(169, 25);
            this.labelBuyername.TabIndex = 2;
            this.labelBuyername.Text = "BUYER NAME";
            // 
            // textBoxBuyername
            // 
            this.textBoxBuyername.Location = new System.Drawing.Point(360, 152);
            this.textBoxBuyername.Multiline = true;
            this.textBoxBuyername.Name = "textBoxBuyername";
            this.textBoxBuyername.Size = new System.Drawing.Size(256, 25);
            this.textBoxBuyername.TabIndex = 7;
            this.textBoxBuyername.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxBuyername_Validating);
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelItemName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemName.ForeColor = System.Drawing.Color.Black;
            this.labelItemName.Location = new System.Drawing.Point(64, 221);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(151, 25);
            this.labelItemName.TabIndex = 8;
            this.labelItemName.Text = "ITEM NAME";
            // 
            // labelItemQuantity
            // 
            this.labelItemQuantity.AutoSize = true;
            this.labelItemQuantity.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelItemQuantity.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemQuantity.ForeColor = System.Drawing.Color.Black;
            this.labelItemQuantity.Location = new System.Drawing.Point(64, 287);
            this.labelItemQuantity.Name = "labelItemQuantity";
            this.labelItemQuantity.Size = new System.Drawing.Size(202, 25);
            this.labelItemQuantity.TabIndex = 9;
            this.labelItemQuantity.Text = "ITEM QUANTITY";
            // 
            // labelTotalbill
            // 
            this.labelTotalbill.AutoSize = true;
            this.labelTotalbill.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelTotalbill.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalbill.ForeColor = System.Drawing.Color.Black;
            this.labelTotalbill.Location = new System.Drawing.Point(64, 359);
            this.labelTotalbill.Name = "labelTotalbill";
            this.labelTotalbill.Size = new System.Drawing.Size(149, 25);
            this.labelTotalbill.TabIndex = 10;
            this.labelTotalbill.Text = "TOTAL BILL";
            // 
            // buttonAddAnotheritem
            // 
            this.buttonAddAnotheritem.BackColor = System.Drawing.Color.DarkGray;
            this.buttonAddAnotheritem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddAnotheritem.Location = new System.Drawing.Point(154, 465);
            this.buttonAddAnotheritem.Name = "buttonAddAnotheritem";
            this.buttonAddAnotheritem.Size = new System.Drawing.Size(250, 43);
            this.buttonAddAnotheritem.TabIndex = 12;
            this.buttonAddAnotheritem.Text = "ADD ANOTHER ITEM";
            this.buttonAddAnotheritem.UseVisualStyleBackColor = false;
            this.buttonAddAnotheritem.Click += new System.EventHandler(this.buttonAddAnotheritem_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.DarkGray;
            this.buttonClear.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(504, 465);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(131, 43);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxItemquantity
            // 
            this.textBoxItemquantity.Location = new System.Drawing.Point(360, 287);
            this.textBoxItemquantity.Multiline = true;
            this.textBoxItemquantity.Name = "textBoxItemquantity";
            this.textBoxItemquantity.Size = new System.Drawing.Size(256, 25);
            this.textBoxItemquantity.TabIndex = 16;
            this.textBoxItemquantity.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxItemquantity_Validating);
            // 
            // textBoxtotalbill
            // 
            this.textBoxtotalbill.Location = new System.Drawing.Point(360, 359);
            this.textBoxtotalbill.Multiline = true;
            this.textBoxtotalbill.Name = "textBoxtotalbill";
            this.textBoxtotalbill.Size = new System.Drawing.Size(256, 25);
            this.textBoxtotalbill.TabIndex = 17;
            // 
            // comboBoxItemname
            // 
            this.comboBoxItemname.FormattingEnabled = true;
            this.comboBoxItemname.Location = new System.Drawing.Point(360, 221);
            this.comboBoxItemname.Name = "comboBoxItemname";
            this.comboBoxItemname.Size = new System.Drawing.Size(253, 24);
            this.comboBoxItemname.TabIndex = 26;
            this.comboBoxItemname.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxItemname_Validating);
            // 
            // buttonAddBuyer
            // 
            this.buttonAddBuyer.Location = new System.Drawing.Point(637, 147);
            this.buttonAddBuyer.Name = "buttonAddBuyer";
            this.buttonAddBuyer.Size = new System.Drawing.Size(119, 36);
            this.buttonAddBuyer.TabIndex = 27;
            this.buttonAddBuyer.Text = "ADD BUYER";
            this.buttonAddBuyer.UseVisualStyleBackColor = true;
            this.buttonAddBuyer.Click += new System.EventHandler(this.buttonAddBuyer_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // FormPurchasing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(877, 553);
            this.Controls.Add(this.buttonAddBuyer);
            this.Controls.Add(this.comboBoxItemname);
            this.Controls.Add(this.textBoxtotalbill);
            this.Controls.Add(this.textBoxItemquantity);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAddAnotheritem);
            this.Controls.Add(this.labelTotalbill);
            this.Controls.Add(this.labelItemQuantity);
            this.Controls.Add(this.labelItemName);
            this.Controls.Add(this.textBoxBuyername);
            this.Controls.Add(this.labelBuyername);
            this.Controls.Add(this.panelPurchasing);
            this.Name = "FormPurchasing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchasing";
            this.Load += new System.EventHandler(this.FormPurchasing_Load);
            this.panelPurchasing.ResumeLayout(false);
            this.panelPurchasing.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPurchasing;
        private System.Windows.Forms.Label labelAdditem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDSUPPLIERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDMEMBERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Additem;
        private System.Windows.Forms.ToolStripMenuItem mEMBERPURCHASINGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNVENTORYSTATEToolStripMenuItem;
        private System.Windows.Forms.Label labelBuyername;
        private System.Windows.Forms.TextBox textBoxBuyername;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.Label labelItemQuantity;
        private System.Windows.Forms.Label labelTotalbill;
        private System.Windows.Forms.Button buttonAddAnotheritem;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxItemquantity;
        private System.Windows.Forms.TextBox textBoxtotalbill;
        private System.Windows.Forms.ComboBox comboBoxItemname;
        private System.Windows.Forms.Button buttonAddBuyer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}