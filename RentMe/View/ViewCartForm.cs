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

        public ViewCartForm()
        {
            InitializeComponent();
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

        private void OnViewCartFormLoad(object sender, EventArgs e)
        {
            this.memberNameLabel.Text = this.theMember.FirstName + " " + this.theMember.LastName;
            this.furnitureDataGridView.Rows.Clear();
            this.RefreshDataGridView();
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
                    decimal quantity = Convert.ToDecimal(this.furnitureDataGridView.Rows[row.Index].Cells[0].Value);
                    decimal rentalRate = Convert.ToDecimal(this.furnitureDataGridView.Rows[row.Index].Cells[6].Value);
                    decimal subtotal = decimal.Multiply(quantity, theFurniture.RentalRate);
                    this.furnitureDataGridView.Rows[row.Index].Cells[8].Value = subtotal;
                    break;
                }
            }
        }

        private void RefreshDataGridView()
        {
            furnitureBindingSource.Clear();
            foreach (Furniture theFurniture in theFurnitureList.Keys.ToList())
            {
                furnitureBindingSource.Add(theFurniture);
                this.DisplayQuantityByFurniture(theFurniture);
                this.CalculateSubtotalByFurniture(theFurniture);
            }
        }
    }
}
