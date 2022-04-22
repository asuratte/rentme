using RentMe.Controller;
using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RentMe.View
{
    /// <summary>
    /// Represents the view rental history form of the RentMe Application.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ViewRentalHistoryForm : Form
    {
        private readonly RentalTransactionController theRentalTransactionController;
        private readonly ReturnTransactionController theReturnTransactionController;

        public int MemberID { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewRentalHistoryForm"/> class.
        /// </summary>
        public ViewRentalHistoryForm()
        {
            InitializeComponent();
            this.theRentalTransactionController = new RentalTransactionController();
            this.theReturnTransactionController = new ReturnTransactionController();
        }

        private void DisplayRentalTransactionHistory()
        {
            rentalTransactionBindingSource.Clear();
            try
            {
                List<RentalTransaction> theRentalTransactionList = this.theRentalTransactionController.GetAllRentalTransactionsByMemberID(this.MemberID);
                foreach (RentalTransaction theRentalTransaction in theRentalTransactionList)
                {
                    rentalTransactionBindingSource.Add(theRentalTransaction);
                }
            }
            catch (Exception)
            {
                this.ShowErrorMessage("There was an issue retrieving the member's rental transaction history.");
            }
        }

        private void DisplayReturnTransactionHistory()
        {
            returnTransactionBindingSource.Clear();
            try
            {
                List<ReturnTransaction> theReturnTransactionList = this.theReturnTransactionController.GetAllReturnTransactionsByMemberID(this.MemberID);
                foreach (ReturnTransaction theReturnTransaction in theReturnTransactionList)
                {
                    returnTransactionBindingSource.Add(theReturnTransaction);
                }
            }
            catch (Exception)
            {
                this.ShowErrorMessage("There was an issue retrieving the member's return transaction history.");
            }
            
        }

        private void OnViewRentalHistoryFormLoad(object sender, EventArgs e)
        {
            this.errorMessageLabel.Text = "";
            this.DisplayRentalTransactionHistory();
            this.DisplayReturnTransactionHistory();
            if (rentalTransactionDataGridView.Rows.Count < 1 && returnTransactionDataGridView.Rows.Count < 1)
            {
                this.errorMessageLabel.Text = "This member has not made any rental or return transactions.";
                this.errorMessageLabel.ForeColor = Color.Black;
            }
        }

        private void ShowErrorMessage(string message)
        {
            this.errorMessageLabel.Text = message;
            this.errorMessageLabel.ForeColor = Color.Red;
        }

        private void CloseButtonOnClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void RentalTransactionDataGridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                int i = e.RowIndex;
                RentalTransaction selectedRentalTransaction = (RentalTransaction)rentalTransactionBindingSource[i];
                using (ViewTransactionDetailsForm theViewTransactionDetailsForm = new ViewTransactionDetailsForm())
                {
                    theViewTransactionDetailsForm.ResetForm();
                    theViewTransactionDetailsForm.TheRentalTransaction = selectedRentalTransaction;
                    DialogResult result = theViewTransactionDetailsForm.ShowDialog();
                }
            }
        }

        private void ReturnTransactionDataGridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                int i = e.RowIndex;
                ReturnTransaction selectedReturnTransaction = (ReturnTransaction)returnTransactionBindingSource[i];
                using (ViewTransactionDetailsForm theViewTransactionDetailsForm = new ViewTransactionDetailsForm())
                {
                    theViewTransactionDetailsForm.ResetForm();
                    theViewTransactionDetailsForm.TheReturnTransaction = selectedReturnTransaction;
                    DialogResult result = theViewTransactionDetailsForm.ShowDialog();
                }
            }
        }
    }
}
