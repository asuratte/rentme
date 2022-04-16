using RentMe.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RentMe.View
{
    /// <summary>
    /// Represents the edit cart form of the RentMe Application
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
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

        /// <summary>
        /// Initializes a new instance of the <see cref="EditCartForm"/> class.
        /// </summary>
        public EditCartForm()
        {
            InitializeComponent();
        }

        private void EditCartFormOnLoad(object sender, EventArgs e)
        {
            this.furnitureNameValueLabel.Text = this.theRentalItem.FurnitureName;
            this.furnitureQuantityNumericUpDown.Value = this.theRentalItem.Quantity;
            this.errorMessageLabel.Text = "";
        }

        private void UpdateCartButtonClick(object sender, EventArgs e)
        {
            if (this.ValidateItemQuantity())
            {
                this.theRentalItem.Quantity = Convert.ToInt32(this.furnitureQuantityNumericUpDown.Value);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.ShowErrorMessage("Invalid quantity. Only " + this.QuantityInStock + " item(s) available.");
            }
        }

        private bool ValidateItemQuantity()
        {
            return this.furnitureQuantityNumericUpDown.Value <= this.QuantityInStock;
        }

        private void FurnitureQuantityNumericUpDownEnter(object sender, EventArgs e)
        {
            this.furnitureQuantityNumericUpDown.Select(0, this.furnitureQuantityNumericUpDown.Text.Length);
            this.errorMessageLabel.Text = "";
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

        private void ShowErrorMessage(string message)
        {
            this.errorMessageLabel.Text = message;
            this.errorMessageLabel.ForeColor = Color.Red;
        }
    }
}
