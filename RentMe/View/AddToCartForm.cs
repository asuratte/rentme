using RentMe.Model;
using System;
using System.Windows.Forms;

namespace RentMe.View
{
    public partial class AddToCartForm : Form
    {
        private Furniture theFurniture;

        public Furniture TheFurniture
        {
            get { return this.theFurniture; }
            set
            {
                this.theFurniture = value ?? throw new Exception("Furniture not provided");
            }
        }

        public int QuantityToAdd { get; set; }

        public int QuantityAvailable { get; set; }

        public AddToCartForm()
        {
            InitializeComponent();
        }

        private void AddToCartFormOnLoad(object sender, EventArgs e)
        {
            this.furnitureQuantityNumericUpDown.Maximum = this.QuantityAvailable;
            this.furnitureIDValueLabel.Text = this.theFurniture.FurnitureID;
            this.furnitureNameValueLabel.Text = this.theFurniture.Name;
        }

        private void AddToCartButtonClick(object sender, EventArgs e)
        {
            this.QuantityToAdd = Convert.ToInt32(this.furnitureQuantityNumericUpDown.Value);
            this.DialogResult = DialogResult.OK;
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
