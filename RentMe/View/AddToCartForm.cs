using RentMe.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RentMe.View
{
    /// <summary>
    /// Represents the add to cart form of the RentMe Application
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
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

        /// <summary>
        /// Initializes a new instance of the <see cref="AddToCartForm"/> class.
        /// </summary>
        public AddToCartForm()
        {
            InitializeComponent();
        }

        private void AddToCartFormOnLoad(object sender, EventArgs e)
        {
            this.errorMessageLabel.Text = "";
            this.furnitureQuantityNumericUpDown.Value = 1;
            this.furnitureIDValueLabel.Text = this.theFurniture.FurnitureID;
            this.furnitureNameValueLabel.Text = this.theFurniture.Name;
        }

        private void AddToCartButtonClick(object sender, EventArgs e)
        {
            if (this.ValidateItemQuantity())
            {
                this.QuantityToAdd = Convert.ToInt32(this.furnitureQuantityNumericUpDown.Value);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.ShowErrorMessage("Invalid quantity. Only " + this.QuantityAvailable + " item(s) available.");
            }
        }

        private bool ValidateItemQuantity()
        {
            return this.furnitureQuantityNumericUpDown.Value <= this.QuantityAvailable;
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FurnitureQuantityNumericUpDownEnter(object sender, EventArgs e)
        {
            this.furnitureQuantityNumericUpDown.Select(0, this.furnitureQuantityNumericUpDown.Text.Length);
            this.errorMessageLabel.Text = "";
        }

        private void ShowErrorMessage(string message)
        {
            this.errorMessageLabel.Text = message;
            this.errorMessageLabel.ForeColor = Color.Red;
        }
    }
}
