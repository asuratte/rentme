using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RentMe.View
{
    public partial class ConfirmOrderForm : Form
    {
        private List<RentalItem> theRentalItemList;
        private DateTime theReturnDate;
        private decimal theRentalTotal;

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

        public DateTime TheReturnDate
        {
            get { return this.theReturnDate; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Return date not provided");
                }
                this.theReturnDate = value;
                this.dueDateValueLabel.Text = this.theReturnDate.Date.ToShortDateString();
            }
        }

        public decimal TheRentalTotal
        {
            get { return this.theRentalTotal; }
            set
            {
                this.theRentalTotal = value;
                this.totalValueLabel.Text = "$" + this.theRentalTotal.ToString();
            }
        }

        public ConfirmOrderForm()
        {
            InitializeComponent();
        }

        private void OnConfirmOrderFormLoad(object sender, EventArgs e)
        {
            this.DisplayOrder();
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
    }
}
