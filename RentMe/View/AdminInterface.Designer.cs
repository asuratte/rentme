
namespace RentMe.View
{
    partial class AdminInterface
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInterface));
            this.employeeUsernameLabel = new System.Windows.Forms.Label();
            this.employeeNameSeparatorLabel = new System.Windows.Forms.Label();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.adminInterfaceTabControl = new System.Windows.Forms.TabControl();
            this.mostPopularFurnitureDuringDatesTabPage = new System.Windows.Forms.TabPage();
            this.popularFurnitureReportUserControl = new RentMe.UserControls.PopularFurnitureReportUserControl();
            this.rentMeLogo = new System.Windows.Forms.PictureBox();
            this.adminInterfaceTabControl.SuspendLayout();
            this.mostPopularFurnitureDuringDatesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentMeLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeUsernameLabel
            // 
            this.employeeUsernameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeUsernameLabel.Location = new System.Drawing.Point(273, 42);
            this.employeeUsernameLabel.Name = "employeeUsernameLabel";
            this.employeeUsernameLabel.Size = new System.Drawing.Size(179, 19);
            this.employeeUsernameLabel.TabIndex = 10;
            this.employeeUsernameLabel.Text = "Employee Username";
            // 
            // employeeNameSeparatorLabel
            // 
            this.employeeNameSeparatorLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNameSeparatorLabel.Location = new System.Drawing.Point(259, 42);
            this.employeeNameSeparatorLabel.Name = "employeeNameSeparatorLabel";
            this.employeeNameSeparatorLabel.Size = new System.Drawing.Size(12, 19);
            this.employeeNameSeparatorLabel.TabIndex = 9;
            this.employeeNameSeparatorLabel.Text = "|";
            this.employeeNameSeparatorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNameLabel.Location = new System.Drawing.Point(140, 42);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(117, 19);
            this.employeeNameLabel.TabIndex = 8;
            this.employeeNameLabel.Text = "Employee Name";
            this.employeeNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.logoutLinkLabel.Location = new System.Drawing.Point(720, 12);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(56, 19);
            this.logoutLinkLabel.TabIndex = 6;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // adminInterfaceTabControl
            // 
            this.adminInterfaceTabControl.Controls.Add(this.mostPopularFurnitureDuringDatesTabPage);
            this.adminInterfaceTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.adminInterfaceTabControl.Location = new System.Drawing.Point(0, 100);
            this.adminInterfaceTabControl.Name = "adminInterfaceTabControl";
            this.adminInterfaceTabControl.SelectedIndex = 0;
            this.adminInterfaceTabControl.Size = new System.Drawing.Size(784, 461);
            this.adminInterfaceTabControl.TabIndex = 11;
            // 
            // mostPopularFurnitureDuringDatesTabPage
            // 
            this.mostPopularFurnitureDuringDatesTabPage.Controls.Add(this.popularFurnitureReportUserControl);
            this.mostPopularFurnitureDuringDatesTabPage.Location = new System.Drawing.Point(4, 26);
            this.mostPopularFurnitureDuringDatesTabPage.Name = "mostPopularFurnitureDuringDatesTabPage";
            this.mostPopularFurnitureDuringDatesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mostPopularFurnitureDuringDatesTabPage.Size = new System.Drawing.Size(776, 431);
            this.mostPopularFurnitureDuringDatesTabPage.TabIndex = 0;
            this.mostPopularFurnitureDuringDatesTabPage.Text = "Most Popular Furniture During Dates";
            this.mostPopularFurnitureDuringDatesTabPage.UseVisualStyleBackColor = true;
            // 
            // popularFurnitureReportUserControl
            // 
            this.popularFurnitureReportUserControl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popularFurnitureReportUserControl.Location = new System.Drawing.Point(0, 0);
            this.popularFurnitureReportUserControl.Name = "popularFurnitureReportUserControl";
            this.popularFurnitureReportUserControl.Size = new System.Drawing.Size(770, 425);
            this.popularFurnitureReportUserControl.TabIndex = 0;
            // 
            // rentMeLogo
            // 
            this.rentMeLogo.Image = ((System.Drawing.Image)(resources.GetObject("rentMeLogo.Image")));
            this.rentMeLogo.Location = new System.Drawing.Point(8, 12);
            this.rentMeLogo.Name = "rentMeLogo";
            this.rentMeLogo.Size = new System.Drawing.Size(100, 75);
            this.rentMeLogo.TabIndex = 12;
            this.rentMeLogo.TabStop = false;
            // 
            // AdminInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.rentMeLogo);
            this.Controls.Add(this.adminInterfaceTabControl);
            this.Controls.Add(this.employeeUsernameLabel);
            this.Controls.Add(this.employeeNameSeparatorLabel);
            this.Controls.Add(this.employeeNameLabel);
            this.Controls.Add(this.logoutLinkLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentMe Admin Interface";
            this.Load += new System.EventHandler(this.AdminInterfaceOnLoad);
            this.adminInterfaceTabControl.ResumeLayout(false);
            this.mostPopularFurnitureDuringDatesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rentMeLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeeUsernameLabel;
        private System.Windows.Forms.Label employeeNameSeparatorLabel;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        private System.Windows.Forms.TabControl adminInterfaceTabControl;
        private System.Windows.Forms.TabPage mostPopularFurnitureDuringDatesTabPage;
        private System.Windows.Forms.PictureBox rentMeLogo;
        private UserControls.PopularFurnitureReportUserControl popularFurnitureReportUserControl;
    }
}