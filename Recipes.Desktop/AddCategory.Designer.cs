
namespace Recipes.Desktop
{
    partial class AddCategory
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
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.categoryNameLabel = new System.Windows.Forms.Label();
            this.categoryNameInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Location = new System.Drawing.Point(31, 386);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(363, 23);
            this.addCategoryButton.TabIndex = 0;
            this.addCategoryButton.Text = "Add Category";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // categoryNameLabel
            // 
            this.categoryNameLabel.AutoSize = true;
            this.categoryNameLabel.Location = new System.Drawing.Point(160, 102);
            this.categoryNameLabel.Name = "categoryNameLabel";
            this.categoryNameLabel.Size = new System.Drawing.Size(88, 15);
            this.categoryNameLabel.TabIndex = 1;
            this.categoryNameLabel.Text = "Category name";
            // 
            // categoryNameInput
            // 
            this.categoryNameInput.Location = new System.Drawing.Point(31, 223);
            this.categoryNameInput.Name = "categoryNameInput";
            this.categoryNameInput.Size = new System.Drawing.Size(363, 23);
            this.categoryNameInput.TabIndex = 2;
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 450);
            this.Controls.Add(this.categoryNameInput);
            this.Controls.Add(this.categoryNameLabel);
            this.Controls.Add(this.addCategoryButton);
            this.Name = "AddCategory";
            this.Text = "AddCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.Label categoryNameLabel;
        private System.Windows.Forms.TextBox categoryNameInput;
    }
}