using RentMe.Model;
using System;
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
        }

        private void OnReturnItemFormLoad(object sender, EventArgs e)
        {
            this.furnitureIDValue.Text = this.itemToReturn.FurnitureID;
            this.returnDateValue.Text = DateTime.Now.ToShortDateString();
            this.rentalTransactionIDValue.Text = this.itemToReturn.TransactionID.ToString();
            this.rentalTransactionIDValue.Text = this.itemToReturn.Quantity.ToString();
        }
    }
}
