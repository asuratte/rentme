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
        private Dictionary<Furniture, int> theFurnitureList;
        private Member theMember;
        private DateTime returnDate; 

        public ViewCartForm()
        {
            InitializeComponent();
            this.returnDate = DateTime.Today.AddDays(1);
        }

        public Dictionary<Furniture, int> TheFurnitureList
        {
            get { return this.theFurnitureList; }
            set
            {
                if (value == null || value.Count == 0)
                {
                    throw new Exception("Furniture list not provided");
                }
                this.theFurnitureList = value;
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

        private void CancelButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void DisplayQuantityByFurniture(Furniture theFurniture)
        {
            int rowIndex = -1;
            foreach (DataGridViewRow row in this.furnitureDataGridView.Rows)
            {
                if (row.Cells[1].Value.ToString().Equals(theFurniture.FurnitureID))
                {
                    rowIndex = row.Index;
                    this.furnitureDataGridView.Rows[row.Index].Cells[0].Value = this.theFurnitureList[theFurniture];
                    break;
                }
            }
        }

        private void CalculateSubtotalByFurniture(Furniture theFurniture)
        {
            int rowIndex = -1;
            foreach (DataGridViewRow row in this.furnitureDataGridView.Rows)
            {
                if (row.Cells[1].Value.ToString().Equals(theFurniture.FurnitureID))
                {
                    rowIndex = row.Index;
                    int quantity = Convert.ToInt32(this.furnitureDataGridView.Rows[row.Index].Cells[0].Value);
                    int numberOfDays = (this.returnDateTimePicker.Value.Date - DateTime.Today).Days;
                    decimal rentalRate = Convert.ToDecimal(this.furnitureDataGridView.Rows[row.Index].Cells[6].Value);
                    decimal subtotal = quantity * rentalRate * numberOfDays;
                    this.furnitureDataGridView.Rows[row.Index].Cells[8].Value = subtotal;
                    break;
                }
            }
        }

        private decimal CalculateRentalTotal()
        {
            decimal rentalTotal = 0;
            foreach (DataGridViewRow row in this.furnitureDataGridView.Rows)
            {
                rentalTotal += Convert.ToDecimal(row.Cells[8].Value);
            }
            return rentalTotal;
        }

        private void RefreshViewCartForm()
        {
            this.errorMessageLabel.Text = "";
            furnitureBindingSource.Clear();
            foreach (Furniture theFurniture in theFurnitureList.Keys.ToList())
            {
                furnitureBindingSource.Add(theFurniture);
                this.DisplayQuantityByFurniture(theFurniture);
                this.CalculateSubtotalByFurniture(theFurniture);
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

        private void FurnitureDataGridViewCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //Check if valid int (and quantity available), try catch error 
                //Update dictionary
                //refresh viewcartform
                //if quantity 0 remove item
                //reset error message on enter
            }
        }

        private void FurnitureDataGridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                int i = e.RowIndex;
                Furniture theFurniture = (Furniture)furnitureBindingSource[i];
                this.theFurnitureList.Remove(theFurniture);
                this.RefreshViewCartForm();
            }
        }

        
    }
}
