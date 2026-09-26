using System.Text.RegularExpressions;

namespace Inventory
{
    public partial class FrmAddProduct : Form
    {
        private string _ProductName, _Category, _MfgDate, _ExpDate, _Description;
        private int _Quantity;
        private double _SellPrice;

        private BindingSource showProductList;

        public class NumberFormatException : Exception
        {
            public NumberFormatException(string varName) : base(varName) { }
        }

        public class StringFormatException : Exception
        {
            public StringFormatException(string varName) : base(varName) { }
        }

        public class CurrencyFormatException : Exception
        {
            public CurrencyFormatException(string varName) : base(varName) { }
        }

        public FrmAddProduct()
        {
            InitializeComponent();
            showProductList = new BindingSource();
        }

        private void FrmAddProduct_Load(object sender, EventArgs e)
        {
            string[] ListOfProductCategory = { "Beverages", "Bread/Bakery", "Canned/Jarred Goods",
                "Dairy", "Frozen Goods", "Meat", "Personal Care", "Other" };

            foreach (string category in ListOfProductCategory)
            {
                cbCategory.Items.Add(category);
            }
        }

        private string Product_Name(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new StringFormatException("Product name cannot be empty.");

            return name;
        }

        private int Quantity(string qty)
        {
            int result;
            if (!int.TryParse(qty, out result) || result < 0)
                throw new NumberFormatException("Quantity must be a valid non-negative whole number.");

            return result;
        }

        private double SellingPrice(string price)
        {
            double result;
            if (!double.TryParse(price, out result) || result < 0)
                throw new CurrencyFormatException("Sell price must be a valid non-negative amount.");

            return result;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _ProductName = Product_Name(txtProductName.Text);
                _Category = cbCategory.Text;
                _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
                _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
                _Description = richTxtDescription.Text;
                _Quantity = Quantity(txtQuantity.Text);
                _SellPrice = SellingPrice(txtSellPrice.Text);

                showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate,
                    _ExpDate, _SellPrice, _Quantity, _Description));

                gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridViewProductList.DataSource = showProductList;
            }
            catch (StringFormatException sfe)
            {
                MessageBox.Show("Product Error: " + sfe.Message, "Error");
            }
            catch (NumberFormatException nfe)
            {
                MessageBox.Show("Quantity Error: " + nfe.Message, "Error");
            }
            catch (CurrencyFormatException cfe)
            {
                MessageBox.Show("Sell Price Error: " + cfe.Message, "Error");
            }
            finally
            {
                Console.WriteLine("Add Product attempt finished.");
            }
        }
    }
}
