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
    public partial class AddToCartForm : Form
    {
        private Furniture theFurniture;

        public Furniture TheFurniture
        {
            get { return this.theFurniture; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Furniture not provided");
                }
                this.theFurniture = value;
                this.furnitureIDValueLabel.Text = this.theFurniture.FurnitureID;
                this.furnitureNameValueLabel.Text = this.theFurniture.Name;
            }
        }

        public int QuantityToAdd { get; set; }
        public int QuantityAvailable { get; set; }

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
            this.QuantityToAdd = Convert.ToInt32(this.furnitureQuantityNumericUpDown.Value);
            this.DialogResult = DialogResult.OK;
        }

        private void AddToCartFormOnLoad(object sender, EventArgs e)
        {
            this.furnitureQuantityNumericUpDown.Maximum = this.QuantityAvailable;
        }
    }
}
