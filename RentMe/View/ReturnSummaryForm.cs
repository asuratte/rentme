using RentMe.Model;
using System;
using System.Windows.Forms;

namespace RentMe.View
{
    /// <summary>
    /// Represents the return summary form of the RentMe Application
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ReturnSummaryForm : Form
    {
        private Member theMember;
        private Employee theEmployee;
        private ReturnTransaction theReturnTransaction;
        private ListView theReturnedItems;

        public Member TheMember
        {
            get { return this.theMember; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Member not provided.");
                }
                this.theMember = value;
            }
        }

        public Employee TheEmployee
        {
            get { return this.theEmployee; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Employee not provided.");
                }
                this.theEmployee = value;
            }
        }

        public ReturnTransaction TheReturnTransaction
        {
            get { return this.theReturnTransaction; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Return transaction not provided.");
                }
                this.theReturnTransaction = value;
            }
        }

        public ListView TheReturnedItems
        {
            get { return this.theReturnedItems; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Returned Items not provided.");
                }
                this.theReturnedItems = value;
            }
        }

        /// <summary>
        /// Initialize the Return Summary form
        /// </summary>
        public ReturnSummaryForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Resets the form.
        /// </summary>
        public void ResetForm()
        {
            this.memberNameValue.Text = "";
            this.employeeNameValue.Text = "";
            this.dateValue.Text = "";
            this.totalValue.Text = "";
        }

        private void OnReturnSummaryFormLoad(object sender, EventArgs e)
        {
            this.dateValue.Text = this.theReturnTransaction.ReturnDate.ToShortDateString();
            this.memberNameValue.Text = this.TheMember.FirstName + " " + this.TheMember.LastName;
            this.employeeNameValue.Text = this.theEmployee.FirstName + " " + this.theEmployee.LastName;
            this.transactionNumberLabel.Text = "Transaction #" + this.theReturnTransaction.TransactionID + " completed.";
            this.DisplayTotalAmount();
            returnItemBindingSource.Clear();
            for (int i = 0; i < theReturnedItems.Items.Count; i++)
            {
                returnItemBindingSource.Add(theReturnedItems.Items[i].Tag);
            }
        }

        private void DisplayTotalAmount()
        {
            if (this.theReturnTransaction.TotalAmount < 0)
            {
                this.totalValue.Text = "-$" + (this.theReturnTransaction.TotalAmount * -1).ToString();
            }
            else if (this.theReturnTransaction.TotalAmount > 0)
            {
                this.totalValue.Text = "+$" + this.theReturnTransaction.TotalAmount.ToString();
            }
            else
            {
                this.totalValue.Text = "$" + this.theReturnTransaction.TotalAmount.ToString();
            }
        }
    }
}
