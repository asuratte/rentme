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
        private int quantityReturned;
        private decimal itemTotal;
        private bool refundDue;

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

        public int QuantityReturned
        {
            get { return this.quantityReturned; }
        }

        public decimal ItemTotal
        {
            get { return this.itemTotal; }
        }

        public bool RefundDue
        {
            get { return this.refundDue; }
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
                    string itemTotalDisplay = "";
                    if (rentalRate == -1)
                    {
                        this.errorMessageLabel.Text = "There was an issue getting the rental rate.";
                    }
                    else
                    {
                        double numberOfDaysRented = Math.Round((DateTime.Now - this.itemToReturn.RentalDate).TotalDays);
                        double plannedNumberOfDaysRented = Math.Round((this.itemToReturn.DueDate - this.itemToReturn.RentalDate).TotalDays);
                        double numberOfDaysOverdue = Math.Round((DateTime.Now - this.itemToReturn.DueDate).TotalDays);
                        amountPaid = Decimal.Multiply(Convert.ToDecimal(plannedNumberOfDaysRented), rentalRate);
                        if (numberOfDaysRented == plannedNumberOfDaysRented)
                        {
                            itemTotal = 0;
                        }
                        else if (numberOfDaysRented < plannedNumberOfDaysRented)
                        {
                            itemTotal = Decimal.Multiply(Convert.ToDecimal(plannedNumberOfDaysRented - numberOfDaysRented), rentalRate);
                        }
                        else if (numberOfDaysOverdue > 0)
                        {
                            itemTotal = Decimal.Multiply(Convert.ToDecimal(numberOfDaysOverdue + plannedNumberOfDaysRented), rentalRate);
                        }
                    }
                    if (itemTotal > amountPaid)
                    {
                        itemTotalDisplay = "-$" + itemTotal.ToString();
                        this.refundDue = false;
                    }
                    else if (itemTotal < amountPaid)
                    {
                        itemTotalDisplay = "+$" + itemTotal.ToString();
                        this.refundDue = true;
                    }
                    else
                    {
                        itemTotalDisplay = "$" + itemTotal.ToString();
                        this.refundDue = false;
                    }
                    this.itemTotalTextBox.Text = itemTotalDisplay;
                    this.itemTotal = itemTotal;
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

        private void OnReturnItemButtonClick(object sender, EventArgs e)
        {
            this.quantityReturned = Convert.ToInt32(this.quantityTextBox.Text);
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
            this.quantityReturned = 0;
            this.itemTotal = 0;
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
