﻿using RentMe.Controller;
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
        private readonly EmployeeController theEmployeeController;

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
            this.theEmployeeController = new EmployeeController();
        }

        private void CloseButtonOnClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Resets the form.
        /// </summary>
        public void ResetForm()
        {
            this.employeeNameValue.Text = "";
            this.dateValue.Text = "";
            this.totalValue.Text = "";
            this.transactionNumberValue.Text = "";
            this.errorMessageLabel.Text = "";
            this.theRentalTransaction = null;
            this.theReturnTransaction = null;
        }

        private void ViewTransactionDetailsFormOnLoad(object sender, EventArgs e)
        {
            if (this.theRentalTransaction != null)
            {
                try
                {
                    this.employeeNameValue.Text = this.theEmployeeController.GetEmployeeFirstAndLastNameByID(this.TheRentalTransaction.EmployeeID);
                    this.dateValue.Text = this.TheRentalTransaction.RentalDate.ToShortDateString();
                    this.transactionNumberValue.Text = this.TheRentalTransaction.TransactionID.ToString();
                }
                catch (Exception)
                {
                    this.errorMessageLabel.Text = "There was an issue loading rental transaction details.";
                }
            }
            else if (this.theReturnTransaction != null)
            {
                try
                {
                    this.employeeNameValue.Text = this.theEmployeeController.GetEmployeeFirstAndLastNameByID(this.TheReturnTransaction.EmployeeID);
                    this.dateValue.Text = this.TheReturnTransaction.ReturnDate.ToShortDateString();
                    this.transactionNumberValue.Text = this.TheReturnTransaction.TransactionID.ToString();
                }
                catch (Exception)
                {
                    this.errorMessageLabel.Text = "There was an issue loading return transaction details.";
                }
            }
            else
            {
                this.errorMessageLabel.Text = "There was an issue loading transaction details.";
            }
        }
    }
}
