
namespace Recipes.Desktop
{
    partial class AddRecipe
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
            this.createRecipeButton = new System.Windows.Forms.Button();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.recipeNameLabel = new System.Windows.Forms.Label();
            this.imageUrlInput = new System.Windows.Forms.TextBox();
            this.imageUrlLinkLabel = new System.Windows.Forms.Label();
            this.descriptionInput = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.categoryDropDown = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createRecipeButton
            // 
            this.createRecipeButton.Location = new System.Drawing.Point(37, 393);
            this.createRecipeButton.Name = "createRecipeButton";
            this.createRecipeButton.Size = new System.Drawing.Size(75, 23);
            this.createRecipeButton.TabIndex = 0;
            this.createRecipeButton.Text = "Create";
            this.createRecipeButton.UseVisualStyleBackColor = true;
            this.createRecipeButton.Click += new System.EventHandler(this.createRecipeButton_Click);
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(37, 57);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(351, 23);
            this.nameInput.TabIndex = 1;
            // 
            // recipeNameLabel
            // 
            this.recipeNameLabel.AutoSize = true;
            this.recipeNameLabel.Location = new System.Drawing.Point(37, 39);
            this.recipeNameLabel.Name = "recipeNameLabel";
            this.recipeNameLabel.Size = new System.Drawing.Size(39, 15);
            this.recipeNameLabel.TabIndex = 2;
            this.recipeNameLabel.Text = "Name";
            // 
            // imageUrlInput
            // 
            this.imageUrlInput.Location = new System.Drawing.Point(37, 116);
            this.imageUrlInput.Name = "imageUrlInput";
            this.imageUrlInput.Size = new System.Drawing.Size(351, 23);
            this.imageUrlInput.TabIndex = 3;
            // 
            // imageUrlLinkLabel
            // 
            this.imageUrlLinkLabel.AutoSize = true;
            this.imageUrlLinkLabel.Location = new System.Drawing.Point(37, 95);
            this.imageUrlLinkLabel.Name = "imageUrlLinkLabel";
            this.imageUrlLinkLabel.Size = new System.Drawing.Size(64, 15);
            this.imageUrlLinkLabel.TabIndex = 4;
            this.imageUrlLinkLabel.Text = "Image URL";
            // 
            // descriptionInput
            // 
            this.descriptionInput.Location = new System.Drawing.Point(37, 177);
            this.descriptionInput.Multiline = true;
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.Size = new System.Drawing.Size(351, 121);
            this.descriptionInput.TabIndex = 5;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(37, 156);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(67, 15);
            this.descriptionLabel.TabIndex = 6;
            this.descriptionLabel.Text = "Description";
            // 
            // categoryDropDown
            // 
            this.categoryDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryDropDown.FormattingEnabled = true;
            this.categoryDropDown.Location = new System.Drawing.Point(37, 342);
            this.categoryDropDown.Name = "categoryDropDown";
            this.categoryDropDown.Size = new System.Drawing.Size(351, 23);
            this.categoryDropDown.TabIndex = 7;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(37, 321);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(55, 15);
            this.categoryLabel.TabIndex = 8;
            this.categoryLabel.Text = "Category";
            // 
            // AddRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 450);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.categoryDropDown);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionInput);
            this.Controls.Add(this.imageUrlLinkLabel);
            this.Controls.Add(this.imageUrlInput);
            this.Controls.Add(this.recipeNameLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.createRecipeButton);
            this.Name = "AddRecipe";
            this.Text = "AddRecipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createRecipeButton;
        private System.Windows.Forms.Label imageUrlLinkLabel;
        private System.Windows.Forms.Label recipeNameLabel;
        private System.Windows.Forms.TextBox imageUrlInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionInput;
        private System.Windows.Forms.ComboBox categoryDropDown;
        private System.Windows.Forms.Label categoryLabel;
    }
}