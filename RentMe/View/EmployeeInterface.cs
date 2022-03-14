﻿using System.Windows.Forms;

namespace RentMe.View
{
    /// <summary>
    /// Represents the main employee interface of the RentMe Application
    /// </summary>
    public partial class EmployeeInterface : Form
    {
        /// <summary>
        /// Initialize the employee interface
        /// </summary>
        public EmployeeInterface()
        {
            InitializeComponent();
        }

        private void EmployeeInterfaceOnTabSelected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 0)
            {
                this.memberInformationUserControl.ResetForm();
            }
        }

        private void EmployeeInterfaceOnLoad(object sender, System.EventArgs e)
        {
            this.memberInformationUserControl.ResetForm();
        }
    }
}
