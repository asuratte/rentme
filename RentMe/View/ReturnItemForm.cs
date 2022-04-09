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
            catch (Exception ex)
            {
                this.errorMessageLabel.Text = "There was an issue calculating the total." + ex.Message;
                this.errorMessageLabel.ForeColor = Color.Red;
            }
        }
    }
}
