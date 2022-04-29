using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RentMe.View
{
    /// <summary>
    /// Represents the confirm order form of the RentMe Application
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ConfirmOrderForm : Form
    {
        private List<RentalItem> theRentalItemList;

        public List<RentalItem> TheRentalItemList
        {
            get { return this.theRentalItemList; }
            set
            {
                if (value == null || value.Count == 0)
                {
                    throw new Exception("Rental item list not provided");
                }
                this.theRentalItemList = value;
            }
        }

        public DateTime TheDueDate { get; set; }

        public decimal TheRentalTotal { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfirmOrderForm"/> class.
        /// </summary>
        public ConfirmOrderForm()
        {
            InitializeComponent();
        }

        private void OnConfirmOrderFormLoad(object sender, EventArgs e)
        {
            this.DisplayOrder();
            this.dueDateValueLabel.Text = this.TheDueDate.Date.ToShortDateString();
            this.totalValueLabel.Text = "$" + this.TheRentalTotal.ToString();
        }

        private void DisplayOrder()
        {
            rentalItemBindingSource.Clear();
            foreach (RentalItem theRentalItem in theRentalItemList)
            {
                rentalItemBindingSource.Add(theRentalItem);
            }
            this.CalculateSubtotals();
        }

        private void CalculateSubtotals()
        {
            foreach (DataGridViewRow row in this.rentalItemDataGridView.Rows)
            {
                int quantity = Convert.ToInt32(this.rentalItemDataGridView.Rows[row.Index].Cells[4].Value);
                int numberOfDays = (this.TheDueDate.Date - DateTime.Today).Days;
                decimal rentalRate = Convert.ToDecimal(this.rentalItemDataGridView.Rows[row.Index].Cells[3].Value);
                decimal subtotal = quantity * rentalRate * numberOfDays;
                this.rentalItemDataGridView.Rows[row.Index].Cells[5].Value = subtotal;
            }
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void SubmitButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

    }
}
