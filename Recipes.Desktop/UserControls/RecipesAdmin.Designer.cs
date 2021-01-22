
namespace Recipes.Desktop.UserControls
{
    partial class RecipesAdmin
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
            this.recipeAdminDataGrid = new System.Windows.Forms.DataGridView();
            this.addRecipeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recipeAdminDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // recipeAdminDataGrid
            // 
            this.recipeAdminDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipeAdminDataGrid.Location = new System.Drawing.Point(0, 47);
            this.recipeAdminDataGrid.Name = "recipeAdminDataGrid";
            this.recipeAdminDataGrid.RowTemplate.Height = 25;
            this.recipeAdminDataGrid.Size = new System.Drawing.Size(1030, 402);
            this.recipeAdminDataGrid.TabIndex = 0;
            // 
            // addRecipeButton
            // 
            this.addRecipeButton.Location = new System.Drawing.Point(9, 12);
            this.addRecipeButton.Name = "addRecipeButton";
            this.addRecipeButton.Size = new System.Drawing.Size(75, 23);
            this.addRecipeButton.TabIndex = 1;
            this.addRecipeButton.Text = "Add Recipe";
            this.addRecipeButton.UseVisualStyleBackColor = true;
            this.addRecipeButton.Click += new System.EventHandler(this.addRecipeButton_Click);
            // 
            // RecipesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addRecipeButton);
            this.Controls.Add(this.recipeAdminDataGrid);
            this.Name = "RecipesAdmin";
            this.Size = new System.Drawing.Size(1030, 449);
            ((System.ComponentModel.ISupportInitialize)(this.recipeAdminDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView recipeAdminDataGrid;
        private System.Windows.Forms.Button addRecipeButton;
    }
}
