
namespace Recipes.Desktop
{
    partial class RecipeDetails
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
            this.recipeTitleLabel = new System.Windows.Forms.Label();
            this.recipeImagePictureBox = new System.Windows.Forms.PictureBox();
            this.recipeDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.recipeIngredientsListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.recipeImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // recipeTitleLabel
            // 
            this.recipeTitleLabel.AutoSize = true;
            this.recipeTitleLabel.Location = new System.Drawing.Point(34, 33);
            this.recipeTitleLabel.Name = "recipeTitleLabel";
            this.recipeTitleLabel.Size = new System.Drawing.Size(38, 15);
            this.recipeTitleLabel.TabIndex = 0;
            this.recipeTitleLabel.Text = "label1";
            // 
            // recipeImagePictureBox
            // 
            this.recipeImagePictureBox.Cursor = System.Windows.Forms.Cursors.No;
            this.recipeImagePictureBox.Location = new System.Drawing.Point(34, 67);
            this.recipeImagePictureBox.Name = "recipeImagePictureBox";
            this.recipeImagePictureBox.Size = new System.Drawing.Size(481, 163);
            this.recipeImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.recipeImagePictureBox.TabIndex = 1;
            this.recipeImagePictureBox.TabStop = false;
            // 
            // recipeDescriptionTextBox
            // 
            this.recipeDescriptionTextBox.Location = new System.Drawing.Point(34, 420);
            this.recipeDescriptionTextBox.Multiline = true;
            this.recipeDescriptionTextBox.Name = "recipeDescriptionTextBox";
            this.recipeDescriptionTextBox.ReadOnly = true;
            this.recipeDescriptionTextBox.Size = new System.Drawing.Size(481, 108);
            this.recipeDescriptionTextBox.TabIndex = 2;
            // 
            // recipeIngredientsListBox
            // 
            this.recipeIngredientsListBox.FormattingEnabled = true;
            this.recipeIngredientsListBox.ItemHeight = 15;
            this.recipeIngredientsListBox.Location = new System.Drawing.Point(34, 254);
            this.recipeIngredientsListBox.Name = "recipeIngredientsListBox";
            this.recipeIngredientsListBox.Size = new System.Drawing.Size(481, 139);
            this.recipeIngredientsListBox.TabIndex = 3;
            // 
            // RecipeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 636);
            this.Controls.Add(this.recipeIngredientsListBox);
            this.Controls.Add(this.recipeDescriptionTextBox);
            this.Controls.Add(this.recipeImagePictureBox);
            this.Controls.Add(this.recipeTitleLabel);
            this.Name = "RecipeDetails";
            this.Text = "RecipeDetails";
            ((System.ComponentModel.ISupportInitialize)(this.recipeImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label recipeTitleLabel;
        private System.Windows.Forms.TextBox recipeDescriptionTextBox;
        private System.Windows.Forms.PictureBox recipeImagePictureBox;
        private System.Windows.Forms.ListBox recipeIngredientsListBox;
    }
}