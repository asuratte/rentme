using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RentMe.View
{
    /// <summary>
    /// Represents the order summary form of the RentMe Application
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class OrderSummaryForm : Form
    {
        private Member theMember;
        private Employee theEmployee;
        private RentalTransaction theRentalTransaction;
        private List<RentalItem> theRentalItems;

        public Member TheMember
        {
            get { return this.theMember; }
            set
            {
                this.theMember = value ?? throw new Exception("Member not provided.");
            }
        }

        public Employee TheEmployee
        {
            get { return this.theEmployee; }
            set
            {
                this.theEmployee = value ?? throw new Exception("Employee not provided.");
            }
        }

        public RentalTransaction TheRentalTransaction
        {
            get { return this.theRentalTransaction; }
            set
            {
                this.theRentalTransaction = value ?? throw new Exception("Rental transaction not provided.");
            }
        }

        public List<RentalItem> TheRentalItems
        {
            get { return this.theRentalItems; }
            set
            {
                this.theRentalItems = value ?? throw new Exception("Rental Items not provided.");
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderSummaryForm"/> class.
        /// </summary>
        public OrderSummaryForm()
        {
            InitializeComponent();
        }

        private void OnOrderSummaryFormLoad(object sender, EventArgs e)
        {
            this.dateValueLabel.Text = "Date: " + this.theRentalTransaction.RentalDate.ToShortDateString();
            this.memberNameValueLabel.Text = "Member: " + this.TheMember.FirstName + " " + this.TheMember.LastName;
            this.employeeNameValueLabel.Text = "Helped By: " + this.theEmployee.FirstName + " " + this.theEmployee.LastName;
            this.transactionNumberLabel.Text = "Transaction #" + this.theRentalTransaction.TransactionID + " completed.";
            this.dueDateValueLabel.Text = "Due Date: " + this.theRentalTransaction.DueDate.ToShortDateString();
            this.totalValueLabel.Text = "Total: $" + this.theRentalTransaction.TotalValue.ToString();
            rentalItemBindingSource.Clear();
            foreach (RentalItem theRentalItem in theRentalItems)
            {
                rentalItemBindingSource.Add(theRentalItem);
            }
            this.CalculateSubtotals();
        }

        private void CalculateSubtotals()
        {
            foreach (DataGridViewRow row in this.rentalItemDataGridView.Rows)
            {
                int quantity = Convert.ToInt32(this.rentalItemDataGridView.Rows[row.Index].Cells[3].Value);
                int numberOfDays = (this.theRentalTransaction.DueDate.Date - DateTime.Today).Days;
                decimal rentalRate = Convert.ToDecimal(this.rentalItemDataGridView.Rows[row.Index].Cells[4].Value);
                decimal subtotal = quantity * rentalRate * numberOfDays;
                this.rentalItemDataGridView.Rows[row.Index].Cells[8].Value = subtotal;
            }
        }
    }
}
