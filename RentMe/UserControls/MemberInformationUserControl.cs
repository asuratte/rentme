using System.Collections.Generic;
using System.Windows.Forms;

namespace RentMe.UserControls
{
    /// <summary>
    /// Represents the member information user interface
    /// </summary>
    public partial class MemberInformationUserControl : UserControl
    {
        private readonly SortedDictionary<string, string> sexList;

        /// <summary>
        /// Initialize the member information user interface
        /// </summary>
        public MemberInformationUserControl()
        {
            InitializeComponent();
            this.sexList = new SortedDictionary<string, string> {
                { "Male", "M"},
                { "Female", "F"},
                { "Other", "O"},
                { "Prefer not to say", "P"}
            };
        }

        /// <summary>
        /// Resets the form.
        /// </summary>
        public void ResetForm()
        {
            this.LoadComboBoxes();
            this.errorMessageLabel.Text = "";
        }

        private void LoadComboBoxes()
        {
            this.sexFormComboBox.DataSource = new BindingSource(sexList, null);
            this.sexFormComboBox.DisplayMember = "Key";
            this.sexFormComboBox.ValueMember = "Value";
        }
    }
}
