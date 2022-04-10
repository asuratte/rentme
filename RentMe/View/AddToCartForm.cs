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
    public partial class AddToCartForm : Form
    {
        private string furnitureID;
        private string furnitureName;

        public string FurnitureID
        {
            get { return this.furnitureID; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Furniture ID not provided");
                }
                this.furnitureID = value;
                this.furnitureIDValueLabel.Text = this.furnitureID;
            }
        }

        public string FurnitureName
        {
            get { return this.furnitureName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name not provided");
                }
                this.furnitureName = value;
                this.furnitureNameValueLabel.Text = this.furnitureName;
            }
        }

        public int Quantity { get; set; }

        public AddToCartForm()
        {
            InitializeComponent();
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AddToCartButtonClick(object sender, EventArgs e)
        {
            this.Quantity = Convert.ToInt32(this.furnitureQuantityNumericUpDown.Value);
            this.DialogResult = DialogResult.OK;
        }
    }
}
