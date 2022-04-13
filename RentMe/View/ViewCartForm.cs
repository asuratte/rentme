﻿using RentMe.Controller;
using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RentMe.View
{
    public partial class ViewCartForm : Form
    {
        private List<RentalItem> theRentalItemList;
        private Member theMember;
        private DateTime theReturnDate;
        private readonly FurnitureController theFurnitureController;

        public ViewCartForm()
        {
            InitializeComponent();
            this.theFurnitureController = new FurnitureController();
            this.theReturnDate = DateTime.Today.AddDays(1);
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
                this.theMember = value ?? throw new Exception("Member name not provided");
                this.memberNameValueLabel.Text = this.theMember.FirstName + " " + this.theMember.LastName;
            }
        }

        private void OnViewCartFormShown(object sender, EventArgs e)
        {
            this.errorMessageLabel.Text = "";
            this.returnDateTimePicker.Value = this.theReturnDate;
            this.RefreshCart();
        }

        private void RefreshCart()
        {
            rentalItemBindingSource.Clear();
            foreach (RentalItem theRentalItem in theRentalItemList)
            {
                rentalItemBindingSource.Add(theRentalItem);
            }
            this.CalculateSubtotals();
            this.CalculateRentalTotal();
            this.errorMessageLabel.Text = "";
        }

        private void CalculateSubtotals()
        {
            foreach (DataGridViewRow row in this.rentalItemDataGridView.Rows)
            {
                int quantity = Convert.ToInt32(this.rentalItemDataGridView.Rows[row.Index].Cells[1].Value);
                int numberOfDays = (this.returnDateTimePicker.Value.Date - DateTime.Today).Days;
                decimal rentalRate = Convert.ToDecimal(this.rentalItemDataGridView.Rows[row.Index].Cells[4].Value);
                decimal subtotal = quantity * rentalRate * numberOfDays;
                this.rentalItemDataGridView.Rows[row.Index].Cells[8].Value = subtotal;
            }
        }

        private void CalculateRentalTotal()
        {
            decimal rentalTotal = 0;
            foreach (DataGridViewRow row in this.rentalItemDataGridView.Rows)
            {
                rentalTotal += Convert.ToDecimal(row.Cells[8].Value);
            }
            this.rentalTotalTextBox.Text = "$" + rentalTotal.ToString();
        }

        private void OnReturnDateTimePickerValueChanged(object sender, EventArgs e)
        {
            if (this.returnDateTimePicker.Value.Date <= DateTime.Today)
            {
                this.returnDateTimePicker.Value = this.theReturnDate;
                this.ShowErrorMessage("The return date must be after today's date.");
            }
            else
            {
                this.theReturnDate = this.returnDateTimePicker.Value;
                this.RefreshCart();
            }
        }

        private void RentalItemDataGridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                int i = e.RowIndex;
                RentalItem theRentalItem = (RentalItem)rentalItemBindingSource[i];
                using (EditCartForm theEditCartForm = new EditCartForm())
                {
                    try
                    {
                        theEditCartForm.TheRentalItem = theRentalItem;
                        theEditCartForm.QuantityInStock = this.theFurnitureController.GetFurnitureQuantityByID(theRentalItem.FurnitureID);
                        DialogResult result = theEditCartForm.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            RentalItem itemToUpdate = this.theRentalItemList.Find(item => item.FurnitureID == theRentalItem.FurnitureID);
                            if (theEditCartForm.TheRentalItem.Quantity > 0)
                            {
                                itemToUpdate.Quantity = theEditCartForm.TheRentalItem.Quantity;
                            }
                            else
                            {
                                this.theRentalItemList.Remove(itemToUpdate);
                            }
                            this.RefreshCart();
                            this.errorMessageLabel.Text = "Cart successfully updated.";
                            this.errorMessageLabel.ForeColor = Color.Green;
                        }
                    }
                    catch (Exception)
                    {
                        this.ShowErrorMessage("There was an issue retrieving the total quantity in stock. Editing unavailable.");
                    }
                }
            }
        }

        private void ShowErrorMessage(string message)
        {
            this.errorMessageLabel.Text = message;
            this.errorMessageLabel.ForeColor = Color.Red;
        }

        private void CloseButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
