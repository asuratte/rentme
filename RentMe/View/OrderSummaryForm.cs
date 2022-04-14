using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RentMe.View
{
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
        public OrderSummaryForm()
        {
            InitializeComponent();
        }

        private void OnOrderSummaryFormLoad(object sender, EventArgs e)
        {
            this.dateValueLabel.Text = this.theRentalTransaction.RentalDate.ToShortDateString();
            this.memberNameValueLabel.Text = this.TheMember.FirstName + " " + this.TheMember.LastName;
            this.employeeNameValueLabel.Text = this.theEmployee.FirstName + " " + this.theEmployee.LastName;
            this.transactionNumberLabel.Text = "Transaction #" + this.theRentalTransaction.TransactionID + " completed.";
            this.totalValueLabel.Text = "$ " + this.theRentalTransaction.TotalValue.ToString();
            rentalItemBindingSource.Clear();
            foreach (RentalItem theRentalItem in theRentalItems)
            {
                rentalItemBindingSource.Add(theRentalItem);
            }
        }
    }
}
