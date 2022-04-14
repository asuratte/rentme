using RentMe.Model;
using System;
using System.Windows.Forms;

namespace RentMe.View
{
    public partial class EditCartForm : Form
    {
        private RentalItem theRentalItem;

        public RentalItem TheRentalItem
        {
            get { return this.theRentalItem; }
            set
            {
                this.theRentalItem = value ?? throw new Exception("Furniture not provided");
            }
        }

        public int QuantityInStock { get; set; }

        public EditCartForm()
        {
            InitializeComponent();
        }

        private void EditCartFormOnLoad(object sender, EventArgs e)
        {
            this.furnitureQuantityNumericUpDown.Maximum = QuantityInStock;
            this.furnitureNameValueLabel.Text = this.theRentalItem.FurnitureName;
            this.furnitureQuantityNumericUpDown.Value = this.theRentalItem.Quantity;
        }

        private void UpdateCartButtonClick(object sender, EventArgs e)
        {
            this.theRentalItem.Quantity = Convert.ToInt32(this.furnitureQuantityNumericUpDown.Value);
            this.DialogResult = DialogResult.OK;
        }

        private void RemoveItemButtonClick(object sender, EventArgs e)
        {
            this.theRentalItem.Quantity = 0;
            this.DialogResult = DialogResult.OK;
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
