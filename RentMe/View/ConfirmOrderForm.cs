using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RentMe.View
{
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
