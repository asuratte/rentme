﻿using RentMe.Controller;
using RentMe.Model;
using RentMe.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RentMe.UserControls
{
    /// <summary>
    /// Represents the rent furniture user interface
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class ReturnFurnitureUserControl : UserControl
    {
        private readonly RentalItemController theRentalItemController;
        private readonly MemberController theMemberController;
        private ReturnItemForm theReturnItemForm;
        private decimal theTotalAmount;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnFurnitureUserControl"/> class.
        /// </summary>
        public ReturnFurnitureUserControl()
        {
            InitializeComponent();
            this.theRentalItemController = new RentalItemController();
            this.theMemberController = new MemberController();
            this.theReturnItemForm = new ReturnItemForm();
        }

        private void MemberSearchButtonClick(object sender, System.EventArgs e)
        {
            if (this.memberIDTextBox.Text != null && this.memberIDTextBox.Text != "")
            {
                try
                {
                    int memberID = Convert.ToInt32(this.memberIDTextBox.Text);
                    this.ResetForm();
                    Member theMember = this.theMemberController.GetMemberByID(memberID);
                    if (theMember != null)
                    {
                        List<RentalItem> outstandingRentalItemsList = this.theRentalItemController.GetActiveRentalItemsByMemberID(memberID);
                        rentalItemBindingSource.Clear();
                        if (outstandingRentalItemsList.Count > 0)
                        {
                            this.DataGridViewHeaderLabel.Text = "Items currently rented to " + theMember.FirstName + " " + theMember.LastName + ":";
                            foreach (RentalItem theRentalItem in outstandingRentalItemsList)
                            {
                                rentalItemBindingSource.Add(theRentalItem);
                            }
                        }
                        else
                        {
                            this.errorMessageLabel.Text = "Member currently has no oustanding rentals.";
                        }
                    }
                    else
                    {
                        this.ShowErrorMessage("No member with that ID found.");
                    }
                }
                catch (Exception)
                {
                    this.ShowErrorMessage("There was an issue getting member rental information.");
                }
            }
            else
            {
                this.ShowErrorMessage("Please enter a member ID before clicking Search.");
            }
        }

        private void ReturnsDataGridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                int i = e.RowIndex;
                RentalItem theRentalItem = (RentalItem)rentalItemBindingSource[i];
                this.theReturnItemForm.ResetForm();
                this.theReturnItemForm.ItemToReturn = theRentalItem;
                this.theReturnItemForm.ShowDialog();
                if (this.theReturnItemForm.DialogResult == DialogResult.OK)
                {
                    ListViewItem itemToAdd = new ListViewItem();
                    itemToAdd.Text = this.theReturnItemForm.TheReturnedItem.FurnitureID + " x " + theReturnItemForm.TheReturnedItem.Quantity;
                    itemToAdd.Tag = this.theReturnItemForm.TheReturnedItem;
                    this.returnedItemsListView.Items.Add(itemToAdd);
                    this.UpdateTotalAmount();
                    this.DisplayTotalAmount();
                    this.completeReturnTransactionButton.Enabled = true;
                    this.rentalItemDataGridView.Rows.RemoveAt(i);
                }
            }
        }

        private void UpdateTotalAmount()
        {
            if (this.theReturnItemForm.TheReturnedItem.ItemTotal > 0)
            {
                this.theTotalAmount += this.theReturnItemForm.TheReturnedItem.ItemTotal;
            }
            else if (this.theReturnItemForm.TheReturnedItem.ItemTotal < 0)
            {
                this.theTotalAmount += this.theReturnItemForm.TheReturnedItem.ItemTotal;
            }
        }

        private void DisplayTotalAmount()
        {
            if (this.theTotalAmount < 0)
            {
                this.transactionTotalAmountTextBox.Text = "-$" + (this.theTotalAmount * -1).ToString();
            }
            else if (this.theTotalAmount > 0)
            {
                this.transactionTotalAmountTextBox.Text = "+$" + this.theTotalAmount.ToString();
            }
            else
            {
                this.transactionTotalAmountTextBox.Text = "$" + this.theTotalAmount.ToString();
            }
        }

        /// <summary>
        /// Resets the form.
        /// </summary>
        public void ResetForm()
        {
            this.rentalItemBindingSource.Clear();
            this.errorMessageLabel.Text = "";
            this.memberIDTextBox.Text = "";
            this.completeReturnTransactionButton.Enabled = false;
            this.returnedItemsListView.Items.Clear();
            this.DataGridViewHeaderLabel.Text = "";
            this.transactionTotalAmountTextBox.Text = "";
            this.theTotalAmount = 0;
        }

        private void ShowErrorMessage(string message)
        {
            this.errorMessageLabel.Text = message;
            this.errorMessageLabel.ForeColor = Color.Red;
        }

        private void OnTextEntered(object sender, EventArgs e)
        {
            this.errorMessageLabel.Text = "";
            this.errorMessageLabel.ForeColor = default(Color);
        }

        private void OnClearFormButtonClick(object sender, EventArgs e)
        {
            this.ResetForm();
        }
    }
}
