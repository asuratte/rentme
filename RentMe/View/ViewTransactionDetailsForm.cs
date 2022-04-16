using RentMe.Controller;
using RentMe.Model;
using System;
using System.Collections.Generic;
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
        private readonly RentalItemController theRentalItemController;
        private readonly ReturnItemController theReturnItemController;

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
            this.theRentalItemController = new RentalItemController();
            this.theReturnItemController = new ReturnItemController();
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
            transactionDetailsDataGridView.Rows.Clear();
            transactionDetailsDataGridView.Refresh();
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
                    decimal transactionTotal = 0;
                    List<RentalItem> theRentalItems = this.theRentalItemController.GetRentalItemsByTransactionID(this.TheRentalTransaction.TransactionID);
                    for (int i = 0; i < theRentalItems.Count; i++)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(transactionDetailsDataGridView);
                        row.Cells[0].Value = theRentalItems[i].Quantity;
                        row.Cells[1].Value = theRentalItems[i].FurnitureID;
                        row.Cells[2].Value = theRentalItems[i].FurnitureName;
                        row.Cells[3].Value = theRentalItems[i].RentalRate;
                        transactionDetailsDataGridView.Rows.Add(row);
                        int numberOfDays = (theRentalItems[i].DueDate.Date - theRentalItems[i].RentalDate.Date).Days;
                        decimal subtotal = theRentalItems[i].Quantity * theRentalItems[i].RentalRate * numberOfDays;
                        transactionTotal += subtotal;
                    }
                    this.totalValue.Text = "$" + transactionTotal.ToString();
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
                    decimal transactionTotal = 0;
                    List<ReturnItem> theReturnItems = this.theReturnItemController.GetReturnItemsByTransactionID(this.TheReturnTransaction.TransactionID);
                    for (int i = 0; i < theReturnItems.Count; i++)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(transactionDetailsDataGridView);
                        row.Cells[0].Value = theReturnItems[i].Quantity;
                        row.Cells[1].Value = theReturnItems[i].FurnitureID;
                        row.Cells[2].Value = theReturnItems[i].FurnitureName;
                        row.Cells[3].Value = theReturnItems[i].RentalRate;
                        transactionDetailsDataGridView.Rows.Add(row);
                        int numberOfDays = (theReturnItems[i].DueDate.Date - theReturnItems[i].ReturnDate.Date).Days;
                        decimal subtotal = theReturnItems[i].Quantity * theReturnItems[i].RentalRate * numberOfDays;
                        transactionTotal += subtotal;
                    }
                    this.totalValue.Text = "$" + transactionTotal.ToString();
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
