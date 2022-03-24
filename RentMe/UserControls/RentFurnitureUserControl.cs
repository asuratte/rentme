using RentMe.Controller;
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
        private readonly CategoryController theCategoryController;
        //private readonly StyleController theStyleController;
        public RentFurnitureUserControl()
        {
            InitializeComponent();
            this.theCategoryController = new CategoryController();
            //this.theStyleController = new StyleController();

            this.LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            try
            {
                List<String> categoryList = this.theCategoryController.GetAllCategories();
                categoryList.Insert(0, "");
                this.categoryComboBox.DataSource = categoryList;
                this.categoryComboBox.DisplayMember = "CategoryName";
                this.categoryComboBox.ValueMember = "CategoryName";
            }
            catch (Exception)
            {
                this.ShowErrorMessage("There was a problem getting the list of furniture categories.");
            }

            try
            {
                //this.styleComboBox.DataSource = this.theStyleController.GetAllStyles();
                //this.styleComboBox.DisplayMember = "StyleName";
                //this.styleComboBox.ValueMember = "StyleName";
            }
            catch (Exception)
            {
                //this.ShowErrorMessage("There was a problem getting the list of furniture styles.");
            }
        }

        private void ShowErrorMessage(string message)
        {
            this.errorMessageLabel.Text = message;
            this.errorMessageLabel.ForeColor = Color.Red;
        }
    }
}
