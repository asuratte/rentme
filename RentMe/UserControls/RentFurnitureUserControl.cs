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
    }
}
