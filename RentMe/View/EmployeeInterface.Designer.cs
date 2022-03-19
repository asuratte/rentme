namespace RentMe.View
{
    partial class EmployeeInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeInterface));
            this.employeeInterfaceTabControl = new System.Windows.Forms.TabControl();
            this.memberInformationTabPage = new System.Windows.Forms.TabPage();
            this.rentFurnitureTabPage = new System.Windows.Forms.TabPage();
            this.returnFurnitureTabPage = new System.Windows.Forms.TabPage();
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.rentMeLogo = new System.Windows.Forms.PictureBox();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.employeeNameSeparatorLabel = new System.Windows.Forms.Label();
            this.employeeUsernameLabel = new System.Windows.Forms.Label();
            this.employeeInterfaceTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentMeLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeInterfaceTabControl
            // 
            this.employeeInterfaceTabControl.Controls.Add(this.memberInformationTabPage);
            this.employeeInterfaceTabControl.Controls.Add(this.rentFurnitureTabPage);
            this.employeeInterfaceTabControl.Controls.Add(this.returnFurnitureTabPage);
            this.employeeInterfaceTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.employeeInterfaceTabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.employeeInterfaceTabControl.Location = new System.Drawing.Point(0, 100);
            this.employeeInterfaceTabControl.Name = "employeeInterfaceTabControl";
            this.employeeInterfaceTabControl.SelectedIndex = 0;
            this.employeeInterfaceTabControl.Size = new System.Drawing.Size(784, 461);
            this.employeeInterfaceTabControl.TabIndex = 0;
            // 
            // memberInformationTabPage
            // 
            this.memberInformationTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberInformationTabPage.Location = new System.Drawing.Point(4, 26);
            this.memberInformationTabPage.Name = "memberInformationTabPage";
            this.memberInformationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.memberInformationTabPage.Size = new System.Drawing.Size(776, 431);
            this.memberInformationTabPage.TabIndex = 0;
            this.memberInformationTabPage.Text = "Member Information";
            this.memberInformationTabPage.UseVisualStyleBackColor = true;
            // 
            // rentFurnitureTabPage
            // 
            this.rentFurnitureTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentFurnitureTabPage.Location = new System.Drawing.Point(4, 26);
            this.rentFurnitureTabPage.Name = "rentFurnitureTabPage";
            this.rentFurnitureTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.rentFurnitureTabPage.Size = new System.Drawing.Size(776, 431);
            this.rentFurnitureTabPage.TabIndex = 1;
            this.rentFurnitureTabPage.Text = "Rent Furniture";
            this.rentFurnitureTabPage.UseVisualStyleBackColor = true;
            // 
            // returnFurnitureTabPage
            // 
            this.returnFurnitureTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnFurnitureTabPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.returnFurnitureTabPage.Location = new System.Drawing.Point(4, 26);
            this.returnFurnitureTabPage.Name = "returnFurnitureTabPage";
            this.returnFurnitureTabPage.Size = new System.Drawing.Size(776, 431);
            this.returnFurnitureTabPage.TabIndex = 2;
            this.returnFurnitureTabPage.Text = "Return Furniture";
            this.returnFurnitureTabPage.UseVisualStyleBackColor = true;
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.logoutLinkLabel.Location = new System.Drawing.Point(716, 12);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(56, 19);
            this.logoutLinkLabel.TabIndex = 1;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // rentMeLogo
            // 
            this.rentMeLogo.Image = ((System.Drawing.Image)(resources.GetObject("rentMeLogo.Image")));
            this.rentMeLogo.Location = new System.Drawing.Point(8, 12);
            this.rentMeLogo.Name = "rentMeLogo";
            this.rentMeLogo.Size = new System.Drawing.Size(100, 75);
            this.rentMeLogo.TabIndex = 2;
            this.rentMeLogo.TabStop = false;
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNameLabel.Location = new System.Drawing.Point(136, 42);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(117, 19);
            this.employeeNameLabel.TabIndex = 3;
            this.employeeNameLabel.Text = "Employee Name";
            this.employeeNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // employeeNameSeparatorLabel
            // 
            this.employeeNameSeparatorLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNameSeparatorLabel.Location = new System.Drawing.Point(255, 42);
            this.employeeNameSeparatorLabel.Name = "employeeNameSeparatorLabel";
            this.employeeNameSeparatorLabel.Size = new System.Drawing.Size(12, 19);
            this.employeeNameSeparatorLabel.TabIndex = 4;
            this.employeeNameSeparatorLabel.Text = "|";
            this.employeeNameSeparatorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // employeeUsernameLabel
            // 
            this.employeeUsernameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeUsernameLabel.Location = new System.Drawing.Point(269, 42);
            this.employeeUsernameLabel.Name = "employeeUsernameLabel";
            this.employeeUsernameLabel.Size = new System.Drawing.Size(179, 19);
            this.employeeUsernameLabel.TabIndex = 5;
            this.employeeUsernameLabel.Text = "Employee Username";
            // 
            // EmployeeInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.employeeUsernameLabel);
            this.Controls.Add(this.employeeNameSeparatorLabel);
            this.Controls.Add(this.employeeNameLabel);
            this.Controls.Add(this.rentMeLogo);
            this.Controls.Add(this.logoutLinkLabel);
            this.Controls.Add(this.employeeInterfaceTabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentMe Employee Interface";
            this.employeeInterfaceTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rentMeLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl employeeInterfaceTabControl;
        private System.Windows.Forms.TabPage memberInformationTabPage;
        private System.Windows.Forms.TabPage rentFurnitureTabPage;
        private System.Windows.Forms.TabPage returnFurnitureTabPage;
        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        private System.Windows.Forms.PictureBox rentMeLogo;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Label employeeNameSeparatorLabel;
        private System.Windows.Forms.Label employeeUsernameLabel;
    }
}