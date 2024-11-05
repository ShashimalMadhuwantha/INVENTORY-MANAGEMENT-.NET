namespace inventorycw
{
    partial class FormAddItem
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
            this.panelAdditem = new System.Windows.Forms.Panel();
            this.labelAdditem = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDSUPPLIERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDMEMBERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pURCHASINGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mEMBERPURCHASINGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNVENTORYSTATEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelItemname = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelSupplierName = new System.Windows.Forms.Label();
            this.labelItemtype = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxItemname = new System.Windows.Forms.TextBox();
            this.textBoxquantity = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.comboBoxItemtype = new System.Windows.Forms.ComboBox();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelAdditem.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAdditem
            // 
            this.panelAdditem.BackColor = System.Drawing.Color.SeaGreen;
            this.panelAdditem.Controls.Add(this.labelAdditem);
            this.panelAdditem.Controls.Add(this.menuStrip1);
            this.panelAdditem.Location = new System.Drawing.Point(4, 1);
            this.panelAdditem.Name = "panelAdditem";
            this.panelAdditem.Size = new System.Drawing.Size(873, 93);
            this.panelAdditem.TabIndex = 0;
            // 
            // labelAdditem
            // 
            this.labelAdditem.AutoSize = true;
            this.labelAdditem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAdditem.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdditem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAdditem.Location = new System.Drawing.Point(333, 42);
            this.labelAdditem.Name = "labelAdditem";
            this.labelAdditem.Size = new System.Drawing.Size(185, 37);
            this.labelAdditem.TabIndex = 0;
            this.labelAdditem.Text = "ADD ITEM";
            this.labelAdditem.Click += new System.EventHandler(this.label1_Click);
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
            this.iNVENTORYSTATEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashBoardToolStripMenuItem
            // 
            this.dashBoardToolStripMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.dashBoardToolStripMenuItem.Name = "dashBoardToolStripMenuItem";
            this.dashBoardToolStripMenuItem.Size = new System.Drawing.Size(98, 26);
            this.dashBoardToolStripMenuItem.Text = "DashBoard";
            this.dashBoardToolStripMenuItem.Click += new System.EventHandler(this.dashBoardToolStripMenuItem_Click);
            // 
            // aDDSUPPLIERToolStripMenuItem
            // 
            this.aDDSUPPLIERToolStripMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.aDDSUPPLIERToolStripMenuItem.Name = "aDDSUPPLIERToolStripMenuItem";
            this.aDDSUPPLIERToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.aDDSUPPLIERToolStripMenuItem.Text = "ADD SUPPLIER";
            this.aDDSUPPLIERToolStripMenuItem.Click += new System.EventHandler(this.aDDSUPPLIERToolStripMenuItem_Click);
            // 
            // aDDMEMBERToolStripMenuItem
            // 
            this.aDDMEMBERToolStripMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.aDDMEMBERToolStripMenuItem.Name = "aDDMEMBERToolStripMenuItem";
            this.aDDMEMBERToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.aDDMEMBERToolStripMenuItem.Text = "ADD MEMBER";
            this.aDDMEMBERToolStripMenuItem.Click += new System.EventHandler(this.aDDMEMBERToolStripMenuItem_Click);
            // 
            // pURCHASINGToolStripMenuItem
            // 
            this.pURCHASINGToolStripMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pURCHASINGToolStripMenuItem.Name = "pURCHASINGToolStripMenuItem";
            this.pURCHASINGToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.pURCHASINGToolStripMenuItem.Text = "PURCHASING";
            this.pURCHASINGToolStripMenuItem.Click += new System.EventHandler(this.pURCHASINGToolStripMenuItem_Click);
            // 
            // mEMBERPURCHASINGToolStripMenuItem
            // 
            this.mEMBERPURCHASINGToolStripMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.mEMBERPURCHASINGToolStripMenuItem.Name = "mEMBERPURCHASINGToolStripMenuItem";
            this.mEMBERPURCHASINGToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.mEMBERPURCHASINGToolStripMenuItem.Text = "MEMBER PURCHASING";
            this.mEMBERPURCHASINGToolStripMenuItem.Click += new System.EventHandler(this.mEMBERPURCHASINGToolStripMenuItem_Click);
            // 
            // iNVENTORYSTATEToolStripMenuItem
            // 
            this.iNVENTORYSTATEToolStripMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.iNVENTORYSTATEToolStripMenuItem.Name = "iNVENTORYSTATEToolStripMenuItem";
            this.iNVENTORYSTATEToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.iNVENTORYSTATEToolStripMenuItem.Text = "INVENTORY STATE";
            this.iNVENTORYSTATEToolStripMenuItem.Click += new System.EventHandler(this.iNVENTORYSTATEToolStripMenuItem_Click);
            // 
            // labelItemname
            // 
            this.labelItemname.AutoSize = true;
            this.labelItemname.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelItemname.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemname.ForeColor = System.Drawing.Color.Black;
            this.labelItemname.Location = new System.Drawing.Point(54, 139);
            this.labelItemname.Name = "labelItemname";
            this.labelItemname.Size = new System.Drawing.Size(151, 25);
            this.labelItemname.TabIndex = 1;
            this.labelItemname.Text = "ITEM NAME";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelQuantity.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.ForeColor = System.Drawing.Color.Black;
            this.labelQuantity.Location = new System.Drawing.Point(54, 192);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(134, 25);
            this.labelQuantity.TabIndex = 2;
            this.labelQuantity.Text = "QUANTITY";
            // 
            // labelSupplierName
            // 
            this.labelSupplierName.AutoSize = true;
            this.labelSupplierName.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelSupplierName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupplierName.ForeColor = System.Drawing.Color.Black;
            this.labelSupplierName.Location = new System.Drawing.Point(54, 247);
            this.labelSupplierName.Name = "labelSupplierName";
            this.labelSupplierName.Size = new System.Drawing.Size(205, 25);
            this.labelSupplierName.TabIndex = 3;
            this.labelSupplierName.Text = "SUPPLIER NAME";
            // 
            // labelItemtype
            // 
            this.labelItemtype.AutoSize = true;
            this.labelItemtype.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelItemtype.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemtype.ForeColor = System.Drawing.Color.Black;
            this.labelItemtype.Location = new System.Drawing.Point(54, 310);
            this.labelItemtype.Name = "labelItemtype";
            this.labelItemtype.Size = new System.Drawing.Size(140, 25);
            this.labelItemtype.TabIndex = 4;
            this.labelItemtype.Text = "ITEM TYPE";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelPrice.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.Black;
            this.labelPrice.Location = new System.Drawing.Point(54, 363);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(85, 25);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.Text = "PRICE";
            // 
            // textBoxItemname
            // 
            this.textBoxItemname.Location = new System.Drawing.Point(279, 139);
            this.textBoxItemname.Multiline = true;
            this.textBoxItemname.Name = "textBoxItemname";
            this.textBoxItemname.Size = new System.Drawing.Size(256, 25);
            this.textBoxItemname.TabIndex = 6;
            this.textBoxItemname.TextChanged += new System.EventHandler(this.textBoxItemname_TextChanged);
            this.textBoxItemname.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxItemname_Validating);
            // 
            // textBoxquantity
            // 
            this.textBoxquantity.Location = new System.Drawing.Point(279, 196);
            this.textBoxquantity.Multiline = true;
            this.textBoxquantity.Name = "textBoxquantity";
            this.textBoxquantity.Size = new System.Drawing.Size(256, 25);
            this.textBoxquantity.TabIndex = 7;
            this.textBoxquantity.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBoxquantity.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxquantity_Validating);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(279, 363);
            this.textBoxPrice.Multiline = true;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(256, 25);
            this.textBoxPrice.TabIndex = 10;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            this.textBoxPrice.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPrice_Validating);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(84, 456);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(131, 43);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.DarkGray;
            this.buttonClear.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(321, 456);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(131, 43);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // comboBoxItemtype
            // 
            this.comboBoxItemtype.FormattingEnabled = true;
            this.comboBoxItemtype.Items.AddRange(new object[] {
            "select item type",
            "Furniture",
            "Electrical"});
            this.comboBoxItemtype.Location = new System.Drawing.Point(279, 310);
            this.comboBoxItemtype.Name = "comboBoxItemtype";
            this.comboBoxItemtype.Size = new System.Drawing.Size(256, 24);
            this.comboBoxItemtype.TabIndex = 13;
            this.comboBoxItemtype.SelectedIndexChanged += new System.EventHandler(this.comboBoxItemtype_SelectedIndexChanged);
            this.comboBoxItemtype.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxItemtype_Validating);
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Location = new System.Drawing.Point(279, 248);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(256, 24);
            this.comboBoxSupplier.TabIndex = 14;
            this.comboBoxSupplier.SelectedIndexChanged += new System.EventHandler(this.comboBoxSupplier_SelectedIndexChanged);
            this.comboBoxSupplier.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxSupplier_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // FormAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(877, 553);
            this.Controls.Add(this.comboBoxSupplier);
            this.Controls.Add(this.comboBoxItemtype);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxquantity);
            this.Controls.Add(this.textBoxItemname);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelItemtype);
            this.Controls.Add(this.labelSupplierName);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelItemname);
            this.Controls.Add(this.panelAdditem);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Item";
            this.Load += new System.EventHandler(this.FormAddItem_Load);
            this.panelAdditem.ResumeLayout(false);
            this.panelAdditem.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAdditem;
        private System.Windows.Forms.Label labelAdditem;
        private System.Windows.Forms.Label labelItemname;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelSupplierName;
        private System.Windows.Forms.Label labelItemtype;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxItemname;
        private System.Windows.Forms.TextBox textBoxquantity;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ToolStripMenuItem dashBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDSUPPLIERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDMEMBERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pURCHASINGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mEMBERPURCHASINGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNVENTORYSTATEToolStripMenuItem;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ComboBox comboBoxItemtype;
        private System.Windows.Forms.ComboBox comboBoxSupplier;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider5;
    }
}