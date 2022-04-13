using RentMe.Controller;
using RentMe.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentMe.View
{
    public partial class ViewCartForm : Form
    {
        private List<RentalItem> theRentalItemList;
        private Member theMember;
        private DateTime returnDate;
        private FurnitureController theFurnitureController;

        public ViewCartForm()
        {
            InitializeComponent();
            this.theFurnitureController = new FurnitureController();
            this.returnDate = DateTime.Today.AddDays(1);
        }

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

        public Member TheMember
        {
            get { return this.theMember; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Member name not provided");
                }
                this.theMember = value;
            }
        }

        private void OnViewCartFormShown(object sender, EventArgs e)
        {
            this.memberNameLabel.Text = this.theMember.FirstName + " " + this.theMember.LastName;
            this.errorMessageLabel.Text = "";
            this.returnDateTimePicker.Value = this.returnDate;
            this.RefreshViewCartForm();
        }

        private void CalculateSubtotalByRentalItem(RentalItem theRentalItem)
        {
            foreach (DataGridViewRow row in this.rentalItemDataGridView.Rows)
            {
                if (row.Cells[2].Value.ToString().Equals(theRentalItem.FurnitureID))
                {
                    int quantity = Convert.ToInt32(this.rentalItemDataGridView.Rows[row.Index].Cells[1].Value);
                    int numberOfDays = (this.returnDateTimePicker.Value.Date - DateTime.Today).Days;
                    decimal rentalRate = Convert.ToDecimal(this.rentalItemDataGridView.Rows[row.Index].Cells[4].Value);
                    decimal subtotal = quantity * rentalRate * numberOfDays;
                    this.rentalItemDataGridView.Rows[row.Index].Cells[8].Value = subtotal;
                    break;
                }
            }
        }

        private decimal CalculateRentalTotal()
        {
            decimal rentalTotal = 0;
            foreach (DataGridViewRow row in this.rentalItemDataGridView.Rows)
            {
                rentalTotal += Convert.ToDecimal(row.Cells[8].Value);
            }
            return rentalTotal;
        }

        private void RefreshViewCartForm()
        {
            this.errorMessageLabel.Text = "";
            rentalItemBindingSource.Clear();
            foreach (RentalItem theRentalItem in theRentalItemList)
            {
                rentalItemBindingSource.Add(theRentalItem);
                this.CalculateSubtotalByRentalItem(theRentalItem);
            }
            this.rentalTotalTextBox.Text = "$" + this.CalculateRentalTotal().ToString();
        }

        private void ReturnDateTimePickerOnValueChanged(object sender, EventArgs e)
        {
            if (this.returnDateTimePicker.Value.Date <= DateTime.Today)
            {
                this.returnDateTimePicker.Value = this.returnDate;
                this.ShowErrorMessage("The return date must be after today's date.");
            }
            else
            {
                this.returnDate = this.returnDateTimePicker.Value;
                this.RefreshViewCartForm();
            }
        }

        private void ShowErrorMessage(string message)
        {
            this.errorMessageLabel.Text = message;
            this.errorMessageLabel.ForeColor = Color.Red;
        }


        private void RentalItemDataGridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                int i = e.RowIndex;
                RentalItem theRentalItem = (RentalItem)rentalItemBindingSource[i];
                RentalItem itemToRemove = this.theRentalItemList.Find(item => item.FurnitureID.Equals(theRentalItem.FurnitureID));
                this.theRentalItemList.Remove(itemToRemove);
                this.RefreshViewCartForm();
            }
        }

        private void CloseButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void RentalItemDataGridViewDataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null)
            {
                this.ShowErrorMessage("Invalid quantity. Please enter an integer value greater than 0.");
                this.rentalItemDataGridView.RefreshEdit();
                this.rentalItemDataGridView.EndEdit();
            }
        }

        private void RentalItemDataGridViewCellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                try
                {
                    int newQuantity = Convert.ToInt32(e.FormattedValue.ToString());
                    RentalItem currentRentalItem = (RentalItem)this.rentalItemBindingSource[e.RowIndex];
                    int totalQuantity = this.theFurnitureController.GetFurnitureQuantityByID(currentRentalItem.FurnitureID);

                    if (newQuantity <= 0)
                    {
                        this.ShowErrorMessage("Invalid quantity. Please enter a value greater than 0.");
                        this.rentalItemDataGridView.RefreshEdit();
                    }
                    else if (newQuantity > totalQuantity)
                    {
                        this.ShowErrorMessage("There are only " + totalQuantity + " " + currentRentalItem.FurnitureName + " items in stock.");
                        this.rentalItemDataGridView.RefreshEdit();
                    }
                    else
                    {
                        this.RefreshViewCartForm();
                        this.rentalItemDataGridView.CurrentCell = this.rentalItemDataGridView.Rows[e.RowIndex].Cells[1];
                    }


                }
                catch
                {

                }
            }
        }

}
