namespace RentMe.View
{
    partial class MemberRegistrationConfirmationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberRegistrationConfirmationForm));
            this.memberNameValue = new System.Windows.Forms.Label();
            this.memberPhoneLabel = new System.Windows.Forms.Label();
            this.memberPhoneValue = new System.Windows.Forms.Label();
            this.memberDateOfBirthValue = new System.Windows.Forms.Label();
            this.memberDateOfBirthLabel = new System.Windows.Forms.Label();
            this.memberAddressValue = new System.Windows.Forms.Label();
            this.memberAddressLabel = new System.Windows.Forms.Label();
            this.confirmAddButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // memberNameValue
            // 
            this.memberNameValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberNameValue.Location = new System.Drawing.Point(13, 13);
            this.memberNameValue.Name = "memberNameValue";
            this.memberNameValue.Size = new System.Drawing.Size(456, 23);
            this.memberNameValue.TabIndex = 0;
            this.memberNameValue.Text = "Name";
            // 
            // memberPhoneLabel
            // 
            this.memberPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberPhoneLabel.Location = new System.Drawing.Point(13, 43);
            this.memberPhoneLabel.Name = "memberPhoneLabel";
            this.memberPhoneLabel.Size = new System.Drawing.Size(59, 23);
            this.memberPhoneLabel.TabIndex = 1;
            this.memberPhoneLabel.Text = "Phone:";
            // 
            // memberPhoneValue
            // 
            this.memberPhoneValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberPhoneValue.Location = new System.Drawing.Point(113, 43);
            this.memberPhoneValue.Name = "memberPhoneValue";
            this.memberPhoneValue.Size = new System.Drawing.Size(356, 23);
            this.memberPhoneValue.TabIndex = 2;
            // 
            // memberDateOfBirthValue
            // 
            this.memberDateOfBirthValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberDateOfBirthValue.Location = new System.Drawing.Point(112, 72);
            this.memberDateOfBirthValue.Name = "memberDateOfBirthValue";
            this.memberDateOfBirthValue.Size = new System.Drawing.Size(357, 23);
            this.memberDateOfBirthValue.TabIndex = 4;
            // 
            // memberDateOfBirthLabel
            // 
            this.memberDateOfBirthLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberDateOfBirthLabel.Location = new System.Drawing.Point(13, 72);
            this.memberDateOfBirthLabel.Name = "memberDateOfBirthLabel";
            this.memberDateOfBirthLabel.Size = new System.Drawing.Size(100, 23);
            this.memberDateOfBirthLabel.TabIndex = 3;
            this.memberDateOfBirthLabel.Text = "Date of Birth:";
            // 
            // memberAddressValue
            // 
            this.memberAddressValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberAddressValue.Location = new System.Drawing.Point(112, 102);
            this.memberAddressValue.Name = "memberAddressValue";
            this.memberAddressValue.Size = new System.Drawing.Size(357, 62);
            this.memberAddressValue.TabIndex = 6;
            // 
            // memberAddressLabel
            // 
            this.memberAddressLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberAddressLabel.Location = new System.Drawing.Point(13, 102);
            this.memberAddressLabel.Name = "memberAddressLabel";
            this.memberAddressLabel.Size = new System.Drawing.Size(100, 23);
            this.memberAddressLabel.TabIndex = 5;
            this.memberAddressLabel.Text = "Address:";
            // 
            // confirmAddButton
            // 
            this.confirmAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.confirmAddButton.FlatAppearance.BorderSize = 0;
            this.confirmAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmAddButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmAddButton.ForeColor = System.Drawing.Color.White;
            this.confirmAddButton.Location = new System.Drawing.Point(219, 212);
            this.confirmAddButton.Name = "confirmAddButton";
            this.confirmAddButton.Size = new System.Drawing.Size(147, 27);
            this.confirmAddButton.TabIndex = 9;
            this.confirmAddButton.Text = "Confirm and Add";
            this.confirmAddButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.DimGray;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(385, 212);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(84, 27);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // MemberRegistrationConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 251);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmAddButton);
            this.Controls.Add(this.memberAddressValue);
            this.Controls.Add(this.memberAddressLabel);
            this.Controls.Add(this.memberDateOfBirthValue);
            this.Controls.Add(this.memberDateOfBirthLabel);
            this.Controls.Add(this.memberPhoneValue);
            this.Controls.Add(this.memberPhoneLabel);
            this.Controls.Add(this.memberNameValue);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MemberRegistrationConfirmationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirm New Member Registration";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label memberNameValue;
        private System.Windows.Forms.Label memberPhoneLabel;
        private System.Windows.Forms.Label memberPhoneValue;
        private System.Windows.Forms.Label memberDateOfBirthValue;
        private System.Windows.Forms.Label memberDateOfBirthLabel;
        private System.Windows.Forms.Label memberAddressValue;
        private System.Windows.Forms.Label memberAddressLabel;
        private System.Windows.Forms.Button confirmAddButton;
        private System.Windows.Forms.Button cancelButton;
    }
}