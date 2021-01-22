
namespace Recipes.Desktop.UserControls
{
    partial class CategoriesAdmin
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
            this.categoriesAdminDataGrid = new System.Windows.Forms.DataGridView();
            this.addCategoryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesAdminDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // categoriesAdminDataGrid
            // 
            this.categoriesAdminDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriesAdminDataGrid.Location = new System.Drawing.Point(0, 39);
            this.categoriesAdminDataGrid.Name = "categoriesAdminDataGrid";
            this.categoriesAdminDataGrid.RowTemplate.Height = 25;
            this.categoriesAdminDataGrid.Size = new System.Drawing.Size(949, 368);
            this.categoriesAdminDataGrid.TabIndex = 2;
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Location = new System.Drawing.Point(10, 8);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(105, 23);
            this.addCategoryButton.TabIndex = 3;
            this.addCategoryButton.Text = "Add Category";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // CategoriesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addCategoryButton);
            this.Controls.Add(this.categoriesAdminDataGrid);
            this.Name = "CategoriesAdmin";
            this.Size = new System.Drawing.Size(949, 407);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesAdminDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView categoriesAdminDataGrid;
        private System.Windows.Forms.Button addCategoryButton;
    }
}
