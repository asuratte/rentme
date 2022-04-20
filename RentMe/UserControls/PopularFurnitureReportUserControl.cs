using Microsoft.Reporting.WinForms;
using RentMe.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RentMe.UserControls
{
    /// <summary>
    /// Represents the popular furniture report user interface
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class PopularFurnitureReportUserControl : UserControl
    {
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
        /// Initializes a new instance of the <see cref="PopularFurnitureReportUserControl"/> class.
        /// </summary>
        public PopularFurnitureReportUserControl()
        {
            InitializeComponent();
        }

        private void GenerateReportButton_Click(object sender, EventArgs e)
        {
            this.errorMessageLabel.Text = "";
            DateTime startDate = this.startDateTimePicker.Value;
            DateTime endDate = this.endDateTimePicker.Value;
            this.SetReportParameters(startDate, endDate);
            if (startDate.Date > endDate.Date)
            {
                this.ShowErrorMessage("The start date must be before the end date.");
                this.popularFurnitureReportViewer.Clear();
            }
            else
            {
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

        private void SetReportParameters(DateTime startDate, DateTime endDate)
        {
            ReportParameter[] reportParameters = new ReportParameter[3];
            reportParameters[0] = new ReportParameter("StartDateReportParameter", startDate.ToShortDateString());
            reportParameters[1] = new ReportParameter("EndDateReportParameter", endDate.ToShortDateString());
            reportParameters[2] = new ReportParameter("EmployeeReportParameter", theEmployee.FirstName + " " + theEmployee.LastName);
            this.popularFurnitureReportViewer.LocalReport.SetParameters(reportParameters);
        }


        private void ShowErrorMessage(string message)
        {
            this.errorMessageLabel.Text = message;
            this.errorMessageLabel.ForeColor = Color.Red;
        }

        private void OnDateTimePickerValueChanged(object sender, EventArgs e)
        {
            this.errorMessageLabel.Text = "";
        }

        private void OnPopularFurnitureReportUserControlLoad(object sender, EventArgs e)
        {
            this.startDateTimePicker.Value = DateTime.Today.AddDays(-7);
            this.endDateTimePicker.Value = DateTime.Today;
        }
    }
}
