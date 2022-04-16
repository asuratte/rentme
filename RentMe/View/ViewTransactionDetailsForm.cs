using RentMe.Model;
using System;
using System.Windows.Forms;

namespace RentMe.View
{
    /// <summary>
    /// Represents the transaction details form of the RentMe Application
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ViewTransactionDetailsForm : Form
    {
        private RentalTransaction theRentalTransaction;
        private ReturnTransaction theReturnTransaction;

        public RentalTransaction TheRentalTransaction
        {
            get { return this.theRentalTransaction; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Rental Transaction not provided.");
                }
                this.theRentalTransaction = value;
            }
        }

        public ReturnTransaction TheReturnTransaction
        {
            get { return this.theReturnTransaction; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Return Transaction not provided.");
                }
                this.theReturnTransaction = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewTransactionDetailsForm"/> class.
        /// </summary>
        public ViewTransactionDetailsForm()
        {
            InitializeComponent();
        }

        private void CloseButtonOnClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
