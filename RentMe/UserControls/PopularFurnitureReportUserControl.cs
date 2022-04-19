﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace RentMe.UserControls
{
    public partial class PopularFurnitureReportUserControl : UserControl
    {
        public PopularFurnitureReportUserControl()
        {
            InitializeComponent();
        }

        private void ShowErrorMessage(string message)
        {
            this.errorMessageLabel.Text = message;
            this.errorMessageLabel.ForeColor = Color.Red;
        }

        private void GenerateReportButton_Click(object sender, EventArgs e)
        {
            this.errorMessageLabel.Text = "";
            DateTime startDate = this.startDateTimePicker.Value;
            DateTime endDate = this.endDateTimePicker.Value;
            try
            {
                this.getMostPopularFurnitureDuringDatesTableAdapter.Fill(this.cs6232_g1DataSet.getMostPopularFurnitureDuringDates, startDate, endDate);
                this.popularFurnitureReportViewer.RefreshReport();
            }
            catch (Exception)
            {
                this.ShowErrorMessage("There was an issue retrieving the data for the report.");
            }
        }
    }
}
