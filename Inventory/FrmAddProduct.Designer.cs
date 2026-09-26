namespace Inventory
{
    partial class FrmAddProduct
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            cbCategory = new ComboBox();
            gridViewProductList = new DataGridView();
            btnAddProduct = new Button();
            richTxtDescription = new RichTextBox();
            dtPickerExpDate = new DateTimePicker();
            dtPickerMfgDate = new DateTimePicker();
            txtSellPrice = new TextBox();
            txtQuantity = new TextBox();
            txtProductName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            lblProduct = new Label();
            label3 = new Label();
            label8 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 0;
            label1.Text = "ADD PRODUCT";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(cbCategory);
            panel1.Controls.Add(gridViewProductList);
            panel1.Controls.Add(btnAddProduct);
            panel1.Controls.Add(richTxtDescription);
            panel1.Controls.Add(dtPickerExpDate);
            panel1.Controls.Add(dtPickerMfgDate);
            panel1.Controls.Add(txtSellPrice);
            panel1.Controls.Add(txtQuantity);
            panel1.Controls.Add(txtProductName);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblProduct);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 511);
            panel1.TabIndex = 1;
            // 
            // cbCategory
            // 
            cbCategory.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(123, 100);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(270, 29);
            cbCategory.TabIndex = 7;
            // 
            // gridViewProductList
            // 
            gridViewProductList.BackgroundColor = Color.White;
            gridViewProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewProductList.Location = new Point(12, 334);
            gridViewProductList.Name = "gridViewProductList";
            gridViewProductList.Size = new Size(660, 165);
            gridViewProductList.TabIndex = 6;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.Green;
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.Font = new Font("Cascadia Code", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Location = new Point(553, 297);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(119, 31);
            btnAddProduct.TabIndex = 5;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // richTxtDescription
            // 
            richTxtDescription.Location = new Point(415, 91);
            richTxtDescription.Name = "richTxtDescription";
            richTxtDescription.Size = new Size(257, 200);
            richTxtDescription.TabIndex = 4;
            richTxtDescription.Text = "";
            // 
            // dtPickerExpDate
            // 
            dtPickerExpDate.CalendarFont = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtPickerExpDate.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtPickerExpDate.Location = new Point(123, 188);
            dtPickerExpDate.Name = "dtPickerExpDate";
            dtPickerExpDate.Size = new Size(270, 23);
            dtPickerExpDate.TabIndex = 3;
            dtPickerExpDate.Value = new DateTime(2026, 9, 25, 18, 18, 34, 0);
            // 
            // dtPickerMfgDate
            // 
            dtPickerMfgDate.CalendarFont = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtPickerMfgDate.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtPickerMfgDate.Location = new Point(123, 147);
            dtPickerMfgDate.Name = "dtPickerMfgDate";
            dtPickerMfgDate.Size = new Size(270, 23);
            dtPickerMfgDate.TabIndex = 3;
            dtPickerMfgDate.Value = new DateTime(2026, 9, 25, 18, 18, 28, 0);
            // 
            // txtSellPrice
            // 
            txtSellPrice.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSellPrice.Location = new Point(123, 267);
            txtSellPrice.Name = "txtSellPrice";
            txtSellPrice.Size = new Size(270, 26);
            txtSellPrice.TabIndex = 2;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(123, 226);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(270, 26);
            txtQuantity.TabIndex = 2;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductName.Location = new Point(123, 59);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(270, 26);
            txtProductName.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 270);
            label7.Name = "label7";
            label7.Size = new Size(109, 21);
            label7.TabIndex = 0;
            label7.Text = "Sell Price:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 229);
            label6.Name = "label6";
            label6.Size = new Size(46, 21);
            label6.TabIndex = 0;
            label6.Text = "Qty:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 188);
            label5.Name = "label5";
            label5.Size = new Size(91, 21);
            label5.TabIndex = 0;
            label5.Text = "Exp. Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 147);
            label4.Name = "label4";
            label4.Size = new Size(109, 21);
            label4.TabIndex = 0;
            label4.Text = "Mfg. Date: ";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProduct.Location = new Point(12, 62);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(82, 21);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Product:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 103);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 0;
            label3.Text = "Category:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(415, 62);
            label8.Name = "label8";
            label8.Size = new Size(118, 21);
            label8.TabIndex = 0;
            label8.Text = "Description:";
            // 
            // label2
            // 
            label2.BackColor = Color.Black;
            label2.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 313);
            label2.Name = "label2";
            label2.Size = new Size(536, 1);
            label2.TabIndex = 0;
            label2.Text = "Product: ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGreen;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(684, 49);
            panel2.TabIndex = 1;
            // 
            // FrmAddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 511);
            Controls.Add(panel1);
            Name = "FrmAddProduct";
            Text = "Inventory";
            Load += FrmAddProduct_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtSellPrice;
        private TextBox txtQuantity;
        private TextBox txtProductName;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label8;
        private Label label2;
        private Button btnAddProduct;
        private RichTextBox richTxtDescription;
        private DateTimePicker dtPickerExpDate;
        private DateTimePicker dtPickerMfgDate;
        private DataGridView gridViewProductList;
        private Label lblProduct;
        private ComboBox cbCategory;
    }
}
