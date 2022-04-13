
namespace RentMe.View
{
    partial class EditCartForm
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
            this.furnitureNameLabel = new System.Windows.Forms.Label();
            this.furnitureNameValueLabel = new System.Windows.Forms.Label();
            this.furnitureQuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.furnitureQuantityLabel = new System.Windows.Forms.Label();
            this.updateCartButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureQuantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // furnitureNameLabel
            // 
            this.furnitureNameLabel.AutoSize = true;
            this.furnitureNameLabel.Location = new System.Drawing.Point(12, 9);
            this.furnitureNameLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.furnitureNameLabel.Name = "furnitureNameLabel";
            this.furnitureNameLabel.Size = new System.Drawing.Size(48, 19);
            this.furnitureNameLabel.TabIndex = 2;
            this.furnitureNameLabel.Text = "Name:";
            // 
            // furnitureNameValueLabel
            // 
            this.furnitureNameValueLabel.Location = new System.Drawing.Point(60, 9);
            this.furnitureNameValueLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.furnitureNameValueLabel.Name = "furnitureNameValueLabel";
            this.furnitureNameValueLabel.Size = new System.Drawing.Size(249, 19);
            this.furnitureNameValueLabel.TabIndex = 8;
            // 
            // furnitureQuantityNumericUpDown
            // 
            this.furnitureQuantityNumericUpDown.Location = new System.Drawing.Point(84, 35);
            this.furnitureQuantityNumericUpDown.Name = "furnitureQuantityNumericUpDown";
            this.furnitureQuantityNumericUpDown.Size = new System.Drawing.Size(60, 25);
            this.furnitureQuantityNumericUpDown.TabIndex = 10;
            this.furnitureQuantityNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // furnitureQuantityLabel
            // 
            this.furnitureQuantityLabel.AutoSize = true;
            this.furnitureQuantityLabel.Location = new System.Drawing.Point(12, 37);
            this.furnitureQuantityLabel.Name = "furnitureQuantityLabel";
            this.furnitureQuantityLabel.Size = new System.Drawing.Size(66, 19);
            this.furnitureQuantityLabel.TabIndex = 9;
            this.furnitureQuantityLabel.Text = "Quantity:";
            // 
            // updateCartButton
            // 
            this.updateCartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.updateCartButton.FlatAppearance.BorderSize = 0;
            this.updateCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateCartButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCartButton.ForeColor = System.Drawing.Color.White;
            this.updateCartButton.Location = new System.Drawing.Point(16, 122);
            this.updateCartButton.Name = "updateCartButton";
            this.updateCartButton.Size = new System.Drawing.Size(110, 27);
            this.updateCartButton.TabIndex = 18;
            this.updateCartButton.Text = "Update Cart";
            this.updateCartButton.UseVisualStyleBackColor = false;
            this.updateCartButton.Click += new System.EventHandler(this.UpdateCartButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.DimGray;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(204, 122);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(110, 27);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.removeButton.FlatAppearance.BorderSize = 0;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.Color.White;
            this.removeButton.Location = new System.Drawing.Point(204, 33);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(110, 27);
            this.removeButton.TabIndex = 20;
            this.removeButton.Text = "Remove Item";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.RemoveItemButtonClick);
            // 
            // EditCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 161);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateCartButton);
            this.Controls.Add(this.furnitureQuantityNumericUpDown);
            this.Controls.Add(this.furnitureQuantityLabel);
            this.Controls.Add(this.furnitureNameValueLabel);
            this.Controls.Add(this.furnitureNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditCartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Cart";
            this.Load += new System.EventHandler(this.EditCartFormOnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.furnitureQuantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label furnitureNameLabel;
        private System.Windows.Forms.Label furnitureNameValueLabel;
        private System.Windows.Forms.NumericUpDown furnitureQuantityNumericUpDown;
        private System.Windows.Forms.Label furnitureQuantityLabel;
        private System.Windows.Forms.Button updateCartButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button removeButton;
    }
}