
namespace RentMe.UserControls
{
    partial class PopularFurnitureReportUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.getMostPopularFurnitureDuringDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cs6232_g1DataSet = new RentMe.cs6232_g1DataSet();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.popularFurnitureReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.getMostPopularFurnitureDuringDatesTableAdapter = new RentMe.cs6232_g1DataSetTableAdapters.getMostPopularFurnitureDuringDatesTableAdapter();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.getMostPopularFurnitureDuringDatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cs6232_g1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // getMostPopularFurnitureDuringDatesBindingSource
            // 
            this.getMostPopularFurnitureDuringDatesBindingSource.DataMember = "getMostPopularFurnitureDuringDates";
            this.getMostPopularFurnitureDuringDatesBindingSource.DataSource = this.cs6232_g1DataSet;
            // 
            // cs6232_g1DataSet
            // 
            this.cs6232_g1DataSet.DataSetName = "cs6232_g1DataSet";
            this.cs6232_g1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateTimePicker.Location = new System.Drawing.Point(16, 34);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(217, 25);
            this.startDateTimePicker.TabIndex = 3;
            this.startDateTimePicker.ValueChanged += new System.EventHandler(this.OnDateTimePickerValueChanged);
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLabel.Location = new System.Drawing.Point(12, 12);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(71, 19);
            this.startDateLabel.TabIndex = 2;
            this.startDateLabel.Text = "Start Date";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateLabel.Location = new System.Drawing.Point(269, 12);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(65, 19);
            this.endDateLabel.TabIndex = 4;
            this.endDateLabel.Text = "End Date";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateTimePicker.Location = new System.Drawing.Point(273, 34);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(217, 25);
            this.endDateTimePicker.TabIndex = 5;
            // 
            // generateReportButton
            // 
            this.generateReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.generateReportButton.FlatAppearance.BorderSize = 0;
            this.generateReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateReportButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateReportButton.ForeColor = System.Drawing.Color.White;
            this.generateReportButton.Location = new System.Drawing.Point(529, 33);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(143, 27);
            this.generateReportButton.TabIndex = 6;
            this.generateReportButton.Text = "Generate Report";
            this.generateReportButton.UseVisualStyleBackColor = false;
            this.generateReportButton.Click += new System.EventHandler(this.GenerateReportButton_Click);
            // 
            // popularFurnitureReportViewer
            // 
            this.popularFurnitureReportViewer.AutoScroll = true;
            reportDataSource3.Name = "PopularFurnitureDataSet";
            reportDataSource3.Value = this.getMostPopularFurnitureDuringDatesBindingSource;
            this.popularFurnitureReportViewer.LocalReport.DataSources.Add(reportDataSource3);
            this.popularFurnitureReportViewer.LocalReport.ReportEmbeddedResource = "RentMe.PopularFurnitureReport.rdlc";
            this.popularFurnitureReportViewer.Location = new System.Drawing.Point(16, 71);
            this.popularFurnitureReportViewer.Name = "popularFurnitureReportViewer";
            this.popularFurnitureReportViewer.ServerReport.BearerToken = null;
            this.popularFurnitureReportViewer.Size = new System.Drawing.Size(747, 293);
            this.popularFurnitureReportViewer.TabIndex = 7;
            // 
            // getMostPopularFurnitureDuringDatesTableAdapter
            // 
            this.getMostPopularFurnitureDuringDatesTableAdapter.ClearBeforeFill = true;
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageLabel.Location = new System.Drawing.Point(12, 378);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(751, 45);
            this.errorMessageLabel.TabIndex = 8;
            // 
            // PopularFurnitureReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.errorMessageLabel);
            this.Controls.Add(this.popularFurnitureReportViewer);
            this.Controls.Add(this.generateReportButton);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.startDateLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PopularFurnitureReportUserControl";
            this.Size = new System.Drawing.Size(784, 437);
            this.Load += new System.EventHandler(this.OnPopularFurnitureReportUserControlLoad);
            ((System.ComponentModel.ISupportInitialize)(this.getMostPopularFurnitureDuringDatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cs6232_g1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Button generateReportButton;
        private Microsoft.Reporting.WinForms.ReportViewer popularFurnitureReportViewer;
        private cs6232_g1DataSetTableAdapters.getMostPopularFurnitureDuringDatesTableAdapter getMostPopularFurnitureDuringDatesTableAdapter;
        private cs6232_g1DataSet cs6232_g1DataSet;
        private System.Windows.Forms.BindingSource getMostPopularFurnitureDuringDatesBindingSource;
        private System.Windows.Forms.Label errorMessageLabel;
    }
}
