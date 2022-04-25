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
        private readonly List<RentalItem> theCart;
        private ViewCartForm theViewCartForm;
        private Member theMember;
        private Employee theEmployee;

        public Employee TheEmployee
        {
            get { return this.theEmployee; }
            set
            {
                this.theEmployee = value ?? throw new Exception("Employee not provided.");
            }
        }

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
            this.theCart = new List<RentalItem>();
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
                        this.ClearFurnitureSearchFormInputs();
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
                            this.ClearFurnitureSearchFormInputs();
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
                        this.memberNameValueLabel.Text = this.theMember.FirstName + " " + this.theMember.LastName;
                        this.viewCartButton.Enabled = true;
                        this.resetCartButton.Enabled = true;
                        this.cartIconLabel.Text = "\ue7bf";
                        this.updateCartQuantityDisplay();
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

        private void FurnitureDataGridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                this.errorMessageLabel.Text = "";
                if (this.theMember != null)
                {
                    Furniture theFurniture = (Furniture)furnitureBindingSource[e.RowIndex];
                    using (AddToCartForm theAddToCartForm = new AddToCartForm())
                    {
                        theAddToCartForm.TheFurniture = theFurniture;
                        theAddToCartForm.QuantityAvailable = theFurniture.TotalQuantity;
                        if (this.theCart.Exists(item => item.FurnitureID == theFurniture.FurnitureID))
                        {
                            RentalItem theRentalItem = this.theCart.Find(item => item.FurnitureID == theFurniture.FurnitureID);
                            theAddToCartForm.QuantityAvailable = theFurniture.TotalQuantity - theRentalItem.Quantity;
                        }
                        DialogResult result = theAddToCartForm.ShowDialog();

                        if (result == DialogResult.OK && theAddToCartForm.QuantityToAdd > 0)
                        {
                            RentalItem theRentalItem = null;
                            if (this.theCart.Exists(item => item.FurnitureID == theFurniture.FurnitureID))
                            {
                                theRentalItem = this.theCart.Find(item => item.FurnitureID == theFurniture.FurnitureID);
                                theRentalItem.Quantity += theAddToCartForm.QuantityToAdd;
                            }
                            else
                            {
                                theRentalItem = new RentalItem
                                {
                                    Quantity = theAddToCartForm.QuantityToAdd,
                                    FurnitureID = theFurniture.FurnitureID,
                                    FurnitureName = theFurniture.Name,
                                    RentalRate = theFurniture.RentalRate
                                };
                                this.theCart.Add(theRentalItem);
                            }
                            this.errorMessageLabel.Text = theAddToCartForm.QuantityToAdd + " " + theFurniture.Name + " item(s) successfully added to cart.";
                            this.errorMessageLabel.ForeColor = Color.Green;
                            this.updateCartQuantityDisplay();
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
            this.errorMessageLabel.Text = "";
            if (this.theCart.Count > 0)
            {
                this.theViewCartForm.TheRentalItemList = theCart;
                this.theViewCartForm.TheMember = this.theMember;
                this.theViewCartForm.TheEmployee = this.theEmployee;
                DialogResult result = this.theViewCartForm.ShowDialog();
                this.updateCartQuantityDisplay();
                if (result == DialogResult.OK) 
                {
                    this.ResetForm();
                }
            }
            else
            {
                this.ShowErrorMessage("The cart is currently empty.");
            }
        }

        /// <summary>
        /// Resets the form.
        /// </summary>
        public void ResetForm()
        {
            this.furnitureBindingSource.Clear();
            this.LoadComboBoxes();
            this.errorMessageLabel.Text = "";
            this.ClearFurnitureSearchFormInputs();
            this.ResetCart();
            this.memberIDSearchTextBox.Text = "";
        }

        private void ResetCartButtonClick(object sender, EventArgs e)
        {
            this.ResetCart();
            this.memberIDSearchTextBox.Text = "";
        }

        private void ResetCart()
        {
            this.cartForMemberLabel.Visible = false;
            this.memberNameValueLabel.Text = "";
            this.viewCartButton.Enabled = false;
            this.resetCartButton.Enabled = false;
            this.theMember = null;
            this.theCart.Clear();
            this.errorMessageLabel.Text = "";
            this.cartIconLabel.Text = "";
            this.cartQuantityLabel.Text = "";
            this.theViewCartForm.Dispose();
            this.theViewCartForm = new ViewCartForm();
        }

        private void ClearFurnitureSearchFormInputs()
        {
            this.furnitureIDSearchTextBox.Text = "";
            this.categoryComboBox.SelectedIndex = 0;
            this.styleComboBox.SelectedIndex = 0;
        }

        private void OnSearchValueChanged(object sender, EventArgs e)
        {
            this.errorMessageLabel.Text = "";
            this.errorMessageLabel.ForeColor = default;
        }

        private void ShowErrorMessage(string message)
        {
            this.errorMessageLabel.Text = message;
            this.errorMessageLabel.ForeColor = Color.Red;
        }

        private void LoadMemberFromLookupButtonClick(object sender, EventArgs e)
        {
            this.ResetCart();
            if (MemberInformationUserControl.MemberFromLookup != null)
            {
                this.theMember = MemberInformationUserControl.MemberFromLookup;
                this.cartForMemberLabel.Visible = true;
                this.memberNameValueLabel.Text = this.theMember.FirstName + " " + this.theMember.LastName;
                this.viewCartButton.Enabled = true;
                this.resetCartButton.Enabled = true;
                this.memberIDSearchTextBox.Text = this.theMember.MemberID.ToString();
            }
            else
            {
                this.ShowErrorMessage("Please look up a member in the Member Information tab before trying to load.");
            }
        }

        private void updateCartQuantityDisplay()
        {
            int totalItemsInCart = this.getTotalItemsInCart();
            if (totalItemsInCart == 0)
            {
                this.cartQuantityLabel.Text = "Empty";
            }
            else if (totalItemsInCart == 1)
            {
                this.cartQuantityLabel.Text = "1 Item";
            }
            else
            {
                this.cartQuantityLabel.Text = totalItemsInCart + " Items";
            }
        }

        private int getTotalItemsInCart()
        {
            int totalItems = 0;
            foreach (RentalItem theRentalItem in this.theCart)
            {
                totalItems += theRentalItem.Quantity;
            }
            return totalItems;
        }
    }
}
