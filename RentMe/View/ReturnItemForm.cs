using RentMe.Controller;
using RentMe.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RentMe.View
{
    /// <summary>
    /// Represents the return item form of the RentMe Application
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ReturnItemForm : Form
    {
        private RentalItem itemToReturn;
        private FurnitureController theFurnitureController;
        private ReturnItem theReturnedItem;

        public RentalItem ItemToReturn
        {
            get { return this.itemToReturn; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Item to return not provided.");
                }
                this.itemToReturn = value;
            }
        }

        public ReturnItem TheReturnedItem
        {
            get { return this.theReturnedItem; }
        }

        /// <summary>
        /// Initialize the Return Item form
        /// </summary>
        public ReturnItemForm()
        {
            InitializeComponent();
            this.theFurnitureController = new FurnitureController();
        }

        private void OnReturnItemFormLoad(object sender, EventArgs e)
        {
            this.furnitureIDValue.Text = this.itemToReturn.FurnitureID;
            this.returnDateValue.Text = DateTime.Now.ToShortDateString();
            this.rentalTransactionIDValue.Text = this.itemToReturn.TransactionID.ToString();
            this.quantityTextBox.Text = this.itemToReturn.Quantity.ToString();
        }

        private void CancelButtonOnClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void SetReturnedItem()
        {
            this.theReturnedItem = new ReturnItem();
            this.theReturnedItem.RentalTransactionID = this.itemToReturn.TransactionID;
            this.theReturnedItem.FurnitureID = this.itemToReturn.FurnitureID;
            this.TheReturnedItem.FurnitureName = this.ItemToReturn.FurnitureName;
            this.theReturnedItem.Quantity = Convert.ToInt32(this.quantityTextBox.Text);
        }

        private void CalculateCostButtonClick(object sender, EventArgs e)
        {
            this.errorMessageLabel.Text = "";
            this.itemTotalTextBox.Text = "";
            if (this.ValidateItemQuantity())
            {
                try
                {
                    decimal itemTotal = 0;
                    decimal rentalRate = this.theFurnitureController.GetRentalRateByFurnitureID(this.itemToReturn.FurnitureID);
                    
                    if (rentalRate == -1)
                    {
                        this.errorMessageLabel.Text = "There was an issue getting the rental rate.";
                    }
                    else
                    {
                        this.SetReturnedItem();
                        itemTotal = (this.itemToReturn.DueDate.Date - DateTime.Today).Days * rentalRate * this.TheReturnedItem.Quantity;
                        this.theReturnedItem.ItemTotal = itemTotal;
                        this.DisplayItemTotal(itemTotal);
                        this.returnItemButton.Enabled = true;
                    }
                }
                catch (Exception)
                {
                    this.errorMessageLabel.Text = "There was an issue calculating the total.";
                    this.errorMessageLabel.ForeColor = Color.Red;
                }
            }
            else
            {
                this.errorMessageLabel.Text = "Invalid quantity. Please adjust quantity to a whole number less than or equal to the number of outstanding items and try again.";
                this.errorMessageLabel.ForeColor = Color.Red;
            }
        }

        private void DisplayItemTotal(decimal itemTotal)
        {
            string itemTotalDisplay = "";
            if (itemTotal < 0)
            {
                itemTotalDisplay = "-$" + (-1 * itemTotal).ToString();
                this.theReturnedItem.ItemTotalDisplay = itemTotalDisplay;
                this.errorMessageLabel.Text = "Fine assessed for late return.";
                this.errorMessageLabel.ForeColor = Color.Red;
            }
            else if (itemTotal > 0)
            {
                itemTotalDisplay = "+$" + itemTotal.ToString();
                this.theReturnedItem.ItemTotalDisplay = itemTotalDisplay;
                this.errorMessageLabel.Text = "Refund due.";
                this.errorMessageLabel.ForeColor = Color.Green;
            }
            else
            {
                itemTotalDisplay = "$" + itemTotal.ToString();
                this.theReturnedItem.ItemTotalDisplay = itemTotalDisplay;
                this.errorMessageLabel.Text = "Paid in full.";
                this.errorMessageLabel.ForeColor = Color.Black;
            }
            this.itemTotalTextBox.Text = itemTotalDisplay;
        }

        private void OnReturnItemButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Resets the form.
        /// </summary>
        public void ResetForm()
        {
            this.errorMessageLabel.Text = "";
            this.returnItemButton.Enabled = false;
            this.quantityTextBox.Text = "";
            this.furnitureIDValue.Text = "";
            this.rentalTransactionIDValue.Text = "";
            this.returnDateValue.Text = "";
            this.itemTotalTextBox.Text = "";
            this.theReturnedItem = null;
            this.itemToReturn = null;
        }

        private void OnQuantityChanged(object sender, EventArgs e)
        {
            this.returnItemButton.Enabled = false;
        }

        private bool ValidateItemQuantity()
        {
            bool isValid = false;
            try
            {
                if (Convert.ToInt32(this.quantityTextBox.Text) <= itemToReturn.Quantity && Convert.ToInt32(this.quantityTextBox.Text) != 0)
                {
                    isValid = true;
                }
            }
            catch (Exception)
            {
                this.errorMessageLabel.Text = "Please enter a valid quantity as a whole number.";
            }
            return isValid;
        }
    }
}
