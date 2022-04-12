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
                    decimal amountPaid = 0;
                    decimal rentalRate = this.theFurnitureController.GetRentalRateByFurnitureID(this.itemToReturn.FurnitureID);
                    
                    if (rentalRate == -1)
                    {
                        this.errorMessageLabel.Text = "There was an issue getting the rental rate.";
                    }
                    else
                    {
                        int numberOfDaysRented = Convert.ToInt32((DateTime.Now - this.itemToReturn.RentalDate).TotalDays);
                        int plannedNumberOfDaysRented = Convert.ToInt32((this.itemToReturn.DueDate - this.itemToReturn.RentalDate).TotalDays);
                        int numberOfDaysOverdue = Convert.ToInt32((DateTime.Now - this.itemToReturn.DueDate.AddDays(1)).TotalDays);
                        amountPaid = Decimal.Multiply(plannedNumberOfDaysRented, rentalRate);
                        this.SetReturnedItem();
                        if (numberOfDaysRented == plannedNumberOfDaysRented)
                        {
                            itemTotal = 0;
                            this.theReturnedItem.ItemTotal = itemTotal;
                        }
                        else if (numberOfDaysRented < plannedNumberOfDaysRented)
                        {
                            itemTotal = Decimal.Multiply(Convert.ToDecimal(plannedNumberOfDaysRented - numberOfDaysRented), rentalRate);
                            this.theReturnedItem.ItemTotal = itemTotal;
                        }
                        else if (numberOfDaysOverdue > 0)
                        {
                            itemTotal = Decimal.Multiply(Convert.ToDecimal(numberOfDaysOverdue), rentalRate);
                            this.theReturnedItem.ItemTotal = itemTotal * -1;
                        }
                    }
                    this.DisplayItemTotal(itemTotal, amountPaid);
                    this.returnItemButton.Enabled = true;
                }
                catch (Exception)
                {
                    this.errorMessageLabel.Text = "There was an issue calculating the total.";
                    this.errorMessageLabel.ForeColor = Color.Red;
                }
            }
            else
            {
                this.errorMessageLabel.Text = "Invalid quantity. Please adjust quantity to an amount less than or equal to the number of outstanding items and try again.";
                this.errorMessageLabel.ForeColor = Color.Red;
            }
        }

        private void DisplayItemTotal(decimal itemTotal, decimal amountPaid)
        {
            string itemTotalDisplay = "";
            if (itemTotal > amountPaid)
            {
                itemTotalDisplay = "-$" + itemTotal.ToString();
            }
            else if (itemTotal < amountPaid)
            {
                itemTotalDisplay = "+$" + itemTotal.ToString();
            }
            else
            {
                itemTotalDisplay = "$" + itemTotal.ToString();
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
            if (Convert.ToInt32(this.quantityTextBox.Text) <= itemToReturn.Quantity)
            {
                isValid = true;
            }
            return isValid;
        }
    }
}
