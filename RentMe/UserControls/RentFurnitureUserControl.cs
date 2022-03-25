using RentMe.Controller;
using RentMe.Model;
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

        public RentFurnitureUserControl()
        {
            InitializeComponent();
            this.theFurnitureCategoryController = new FurnitureCategoryController();
            this.theFurnitureStyleController = new FurnitureStyleController();
            this.theFurnitureController = new FurnitureController();
            this.LoadComboBoxes();
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
                        furnitureBindingSource.Clear();
                        furnitureBindingSource.Add(furnitureItem);
                    }
                    else
                    {
                        this.ShowErrorMessage("Cannot find member with specified ID.");
                    }
                }
                catch (Exception)
                {
                    this.ShowErrorMessage("There was an issue retrieving furniture information by ID.");
                }
            }
        }
    }
}
