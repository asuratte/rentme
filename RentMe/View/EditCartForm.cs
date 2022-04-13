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
    public partial class EditCartForm : Form
    {
        private RentalItem theRentalItem;
        private FurnitureController theFurnitureController;

        public RentalItem TheRentalItem
        {
            get { return this.theRentalItem; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Furniture not provided");
                }
                this.theRentalItem = value;
                this.furnitureNameValueLabel.Text = this.theRentalItem.FurnitureName;
                this.furnitureQuantityNumericUpDown.Value = this.theRentalItem.Quantity;
            }
        }

        public int TotalQuantity;

        public EditCartForm()
        {
            InitializeComponent();
            this.theFurnitureController = new FurnitureController();
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void UpdateCartButtonClick(object sender, EventArgs e)
        {
            int newQuantity = Convert.ToInt32(this.furnitureQuantityNumericUpDown.Value);
            this.theRentalItem.Quantity = newQuantity;
            this.DialogResult = DialogResult.OK;
        }

        private void RemoveItemButtonClick(object sender, EventArgs e)
        {
            this.theRentalItem.Quantity = 0;
            this.DialogResult = DialogResult.OK;
        }

    }
}
