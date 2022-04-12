using RentMe.Controller;
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
    public partial class RentFurnitureUserControl : UserControl
    {
        private readonly FurnitureCategoryController theFurnitureCategoryController;
        private readonly FurnitureStyleController theFurnitureStyleController;
        private readonly FurnitureController theFurnitureController;
        private readonly MemberController theMemberController;
        private ViewCartForm theViewCartForm;
        private Member theMember;
        private Dictionary<Furniture, int> theCart;

        /// <summary>
        /// Initializes a new instance of the <see cref="RentFurnitureUserControl"/> class.
        /// </summary>
        public RentFurnitureUserControl()
        {
            InitializeComponent();
            this.theFurnitureCategoryController = new FurnitureCategoryController();
            this.theFurnitureStyleController = new FurnitureStyleController();
            this.theFurnitureController = new FurnitureController();
            this.theMemberController = new MemberController();
            this.theViewCartForm = new ViewCartForm();
            this.theMember = null;
            this.theCart = new Dictionary<Furniture, int>();
        }

        private void LoadComboBoxes()
        {
            try
            {
                List<FurnitureCategory> categoryList = this.theFurnitureCategoryController.GetAllFurnitureCategories();
                categoryList.Insert(0, new FurnitureCategory() { 
                    CategoryName = ""
                });
                this.categoryComboBox.DataSource = categoryList;
                this.categoryComboBox.DisplayMember = "CategoryName";
                this.categoryComboBox.ValueMember = "CategoryName";

                List<FurnitureStyle> styleList = this.theFurnitureStyleController.GetAllFurnitureStyles();
                styleList.Insert(0, new FurnitureStyle()
                {
                    StyleName = ""
                });
                this.styleComboBox.DataSource = styleList;
                this.styleComboBox.DisplayMember = "StyleName";
                this.styleComboBox.ValueMember = "StyleName";
            }
            catch (Exception)
            {
                this.ShowErrorMessage("There was a problem getting the list of furniture categories or styles.");
            }
        }

        private void ShowErrorMessage(string message)
        {
            this.errorMessageLabel.Text = message;
            this.errorMessageLabel.ForeColor = Color.Red;
        }

        private void FurnitureSearchButtonClick(object sender, EventArgs e)
        {
            furnitureBindingSource.Clear();
            this.errorMessageLabel.Text = "";
            if (!string.IsNullOrEmpty(this.furnitureIDSearchTextBox.Text))
            {
                try
                {
                    string furnitureID = this.furnitureIDSearchTextBox.Text;
                    Furniture furnitureItem = this.theFurnitureController.GetFurnitureByID(furnitureID);
                    if (furnitureItem != null)
                    {
                        furnitureBindingSource.Add(furnitureItem);
                        this.ClearSearchFormInputs();
                    }
                    else
                    {
                        this.ShowErrorMessage("Cannot find furniture with specified ID.");
                    }
                }
                catch (Exception)
                {
                    this.ShowErrorMessage("There was an issue retrieving furniture information by ID.");
                }
            }
            else if (!string.IsNullOrEmpty(this.categoryComboBox.SelectedValue.ToString()) || !string.IsNullOrEmpty(this.styleComboBox.SelectedValue.ToString()))
            {
                try
                {
                    string category = this.categoryComboBox.SelectedValue.ToString();
                    string style = this.styleComboBox.SelectedValue.ToString();
                    List<Furniture> theFurnitureList = this.theFurnitureController.GetFurnitureByCategoryAndStyle(category, style);
                    if (theFurnitureList.Count > 0)
                    {
                        foreach (Furniture furnitureItem in theFurnitureList)
                        {
                            furnitureBindingSource.Add(furnitureItem);
                            this.ClearSearchFormInputs();
                        }
                    }
                    else
                    {
                        this.ShowErrorMessage("Cannot find furniture with specified category or style.");
                    }
                }
                catch (Exception)
                {
                    this.ShowErrorMessage("There was an issue retrieving furniture information by category or style.");
                }
            }
            else
            {
                this.ShowErrorMessage("Please select either a Category or Style, or enter a Furniture ID before clicking Search.");
            }
        }

        private void ClearSearchFormInputs()
        {
            this.furnitureIDSearchTextBox.Text = "";
            this.categoryComboBox.SelectedIndex = 0;
            this.styleComboBox.SelectedIndex = 0;
        }

        private void OnSearchValueChanged(object sender, EventArgs e)
        {
            this.errorMessageLabel.Text = "";
            this.errorMessageLabel.ForeColor = default(Color);
        }

        /// <summary>
        /// Resets the form.
        /// </summary>
        public void ResetForm()
        {
            this.furnitureBindingSource.Clear();
            this.LoadComboBoxes();
            this.errorMessageLabel.Text = "";
            this.ClearSearchFormInputs();
            this.ResetCart();
            this.memberIDSearchTextBox.Text = "";
        }

        private void MemberSearchButtonClick(object sender, EventArgs e)
        {
            this.ResetCart();
            if (!String.IsNullOrEmpty(this.memberIDSearchTextBox.Text))
            {
                try
                {
                    int memberID = Convert.ToInt32(this.memberIDSearchTextBox.Text);
                    this.theMember = this.theMemberController.GetMemberByID(memberID);
                    if (this.theMember != null)
                    {
                        this.cartForMemberLabel.Visible = true;
                        this.currentMemberNameLabel.Text = this.theMember.FirstName + " " + this.theMember.LastName;
                        this.viewCartButton.Enabled = true;
                        this.resetCartButton.Enabled = true;
                    }
                    else
                    {
                        this.ShowErrorMessage("Cannot find member with specified ID.");
                    }
                }
                catch (Exception)
                {
                    this.ShowErrorMessage("There was an issue retrieving member information by ID.");
                }
            }
        }

        private void ResetCartButtonClick(object sender, EventArgs e)
        {
            this.ResetCart();
            this.memberIDSearchTextBox.Text = "";
        }

        private void ResetCart()
        {
            this.cartForMemberLabel.Visible = false;
            this.currentMemberNameLabel.Text = "";
            this.viewCartButton.Enabled = false;
            this.resetCartButton.Enabled = false;
            this.theMember = null;
            this.theCart.Clear();
            this.errorMessageLabel.Text = "";
            this.theViewCartForm.Dispose();
            this.theViewCartForm = new ViewCartForm();
        }

        private void FurnitureDataGridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                if (this.theMember != null)
                {
                    int i = e.RowIndex;
                    Furniture theFurniture = (Furniture)furnitureBindingSource[i];
                    using (AddToCartForm theAddToCartForm = new AddToCartForm())
                    {
                        theAddToCartForm.TheFurniture = theFurniture;
                        DialogResult result = theAddToCartForm.ShowDialog();
                        if (result == DialogResult.OK && theAddToCartForm.Quantity > 0)
                        {
                            if (this.theCart.ContainsKey(theFurniture))
                            {
                                this.theCart[theFurniture] += theAddToCartForm.Quantity;
                            }
                            else
                            {
                                this.theCart.Add(theFurniture, theAddToCartForm.Quantity);
                            }
                            this.errorMessageLabel.Text = theAddToCartForm.Quantity + " " + theFurniture.Name + " item(s) successfully added to cart.";
                            this.errorMessageLabel.ForeColor = Color.Green;
                        }
                    }
                }
                else
                {
                    this.ShowErrorMessage("A cart has not been created. Please choose a member to create a cart.");
                }
            }
        }

        private void ViewCartButtonClick(object sender, EventArgs e)
        {
            {
                if (this.theCart.Count > 0)
                {
                    theViewCartForm.TheFurnitureList = theCart;
                    theViewCartForm.TheMember = this.theMember;
                    this.theViewCartForm.ShowDialog();
                }
                else
                {
                    this.ShowErrorMessage("The cart is currently empty.");
                }
            }
            
        }
    }
}
