
namespace RentMe.UserControls
{
    partial class RentFurnitureUserControl
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
            this.categorySearchLabel = new System.Windows.Forms.Label();
            this.styleSearchLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.furnitureIDSearchLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.styleComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // categorySearchLabel
            // 
            this.categorySearchLabel.AutoSize = true;
            this.categorySearchLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorySearchLabel.Location = new System.Drawing.Point(44, 77);
            this.categorySearchLabel.Name = "categorySearchLabel";
            this.categorySearchLabel.Size = new System.Drawing.Size(65, 19);
            this.categorySearchLabel.TabIndex = 8;
            this.categorySearchLabel.Text = "Category";
            // 
            // styleSearchLabel
            // 
            this.styleSearchLabel.AutoSize = true;
            this.styleSearchLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleSearchLabel.Location = new System.Drawing.Point(236, 77);
            this.styleSearchLabel.Name = "styleSearchLabel";
            this.styleSearchLabel.Size = new System.Drawing.Size(38, 19);
            this.styleSearchLabel.TabIndex = 10;
            this.styleSearchLabel.Text = "Style";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(436, 99);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(131, 25);
            this.textBox3.TabIndex = 13;
            // 
            // furnitureIDSearchLabel
            // 
            this.furnitureIDSearchLabel.AutoSize = true;
            this.furnitureIDSearchLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnitureIDSearchLabel.Location = new System.Drawing.Point(432, 77);
            this.furnitureIDSearchLabel.Name = "furnitureIDSearchLabel";
            this.furnitureIDSearchLabel.Size = new System.Drawing.Size(83, 19);
            this.furnitureIDSearchLabel.TabIndex = 12;
            this.furnitureIDSearchLabel.Text = "Furniture ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(632, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 27);
            this.button1.TabIndex = 14;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageLabel.Location = new System.Drawing.Point(7, 342);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(756, 45);
            this.errorMessageLabel.TabIndex = 15;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(48, 99);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(170, 25);
            this.categoryComboBox.TabIndex = 16;
            // 
            // styleComboBox
            // 
            this.styleComboBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleComboBox.FormattingEnabled = true;
            this.styleComboBox.Location = new System.Drawing.Point(240, 99);
            this.styleComboBox.Name = "styleComboBox";
            this.styleComboBox.Size = new System.Drawing.Size(170, 25);
            this.styleComboBox.TabIndex = 17;
            // 
            // RentFurnitureUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.styleComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.errorMessageLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.furnitureIDSearchLabel);
            this.Controls.Add(this.styleSearchLabel);
            this.Controls.Add(this.categorySearchLabel);
            this.Name = "RentFurnitureUserControl";
            this.Size = new System.Drawing.Size(784, 437);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label categorySearchLabel;
        private System.Windows.Forms.Label styleSearchLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label furnitureIDSearchLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox styleComboBox;
    }
}
