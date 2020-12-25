
namespace Recipes.Desktop
{
    partial class Main
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
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.recipesPage = new System.Windows.Forms.TabPage();
            this.addRecipeButton = new System.Windows.Forms.Button();
            this.recipesFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.favouritePage = new System.Windows.Forms.TabPage();
            this.favouriteRecipesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.recipeAdminTabPage = new System.Windows.Forms.TabPage();
            this.categoryAdminTabPage = new System.Windows.Forms.TabPage();
            this.userAdminTabPage = new System.Windows.Forms.TabPage();
            this.recipeGridView = new System.Windows.Forms.DataGridView();
            this.mainTabs.SuspendLayout();
            this.recipesPage.SuspendLayout();
            this.favouritePage.SuspendLayout();
            this.recipeAdminTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabs
            // 
            this.mainTabs.Controls.Add(this.recipesPage);
            this.mainTabs.Controls.Add(this.favouritePage);
            this.mainTabs.Controls.Add(this.recipeAdminTabPage);
            this.mainTabs.Controls.Add(this.categoryAdminTabPage);
            this.mainTabs.Controls.Add(this.userAdminTabPage);
            this.mainTabs.Location = new System.Drawing.Point(57, 73);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(1092, 532);
            this.mainTabs.TabIndex = 0;
            // 
            // recipesPage
            // 
            this.recipesPage.Controls.Add(this.addRecipeButton);
            this.recipesPage.Controls.Add(this.recipesFlowPanel);
            this.recipesPage.Location = new System.Drawing.Point(4, 24);
            this.recipesPage.Name = "recipesPage";
            this.recipesPage.Padding = new System.Windows.Forms.Padding(3);
            this.recipesPage.Size = new System.Drawing.Size(1084, 504);
            this.recipesPage.TabIndex = 0;
            this.recipesPage.Text = "All Recipes";
            this.recipesPage.UseVisualStyleBackColor = true;
            // 
            // addRecipeButton
            // 
            this.addRecipeButton.Location = new System.Drawing.Point(68, 29);
            this.addRecipeButton.Name = "addRecipeButton";
            this.addRecipeButton.Size = new System.Drawing.Size(75, 23);
            this.addRecipeButton.TabIndex = 1;
            this.addRecipeButton.Text = "Add Recipe";
            this.addRecipeButton.UseVisualStyleBackColor = true;
            this.addRecipeButton.Click += new System.EventHandler(this.addRecipeButton_Click);
            // 
            // recipesFlowPanel
            // 
            this.recipesFlowPanel.Location = new System.Drawing.Point(68, 70);
            this.recipesFlowPanel.Name = "recipesFlowPanel";
            this.recipesFlowPanel.Size = new System.Drawing.Size(933, 370);
            this.recipesFlowPanel.TabIndex = 0;
            // 
            // favouritePage
            // 
            this.favouritePage.Controls.Add(this.favouriteRecipesFlowLayoutPanel);
            this.favouritePage.Location = new System.Drawing.Point(4, 24);
            this.favouritePage.Name = "favouritePage";
            this.favouritePage.Padding = new System.Windows.Forms.Padding(3);
            this.favouritePage.Size = new System.Drawing.Size(1084, 504);
            this.favouritePage.TabIndex = 1;
            this.favouritePage.Text = "Favourite Recipes";
            this.favouritePage.UseVisualStyleBackColor = true;
            // 
            // favouriteRecipesFlowLayoutPanel
            // 
            this.favouriteRecipesFlowLayoutPanel.Location = new System.Drawing.Point(76, 67);
            this.favouriteRecipesFlowLayoutPanel.Name = "favouriteRecipesFlowLayoutPanel";
            this.favouriteRecipesFlowLayoutPanel.Size = new System.Drawing.Size(933, 370);
            this.favouriteRecipesFlowLayoutPanel.TabIndex = 1;
            // 
            // recipeAdminTabPage
            // 
            this.recipeAdminTabPage.Controls.Add(this.recipeGridView);
            this.recipeAdminTabPage.Location = new System.Drawing.Point(4, 24);
            this.recipeAdminTabPage.Name = "recipeAdminTabPage";
            this.recipeAdminTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.recipeAdminTabPage.Size = new System.Drawing.Size(1084, 504);
            this.recipeAdminTabPage.TabIndex = 2;
            this.recipeAdminTabPage.Text = "Recipe Admin";
            this.recipeAdminTabPage.UseVisualStyleBackColor = true;
            // 
            // categoryAdminTabPage
            // 
            this.categoryAdminTabPage.Location = new System.Drawing.Point(4, 24);
            this.categoryAdminTabPage.Name = "categoryAdminTabPage";
            this.categoryAdminTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.categoryAdminTabPage.Size = new System.Drawing.Size(1084, 504);
            this.categoryAdminTabPage.TabIndex = 3;
            this.categoryAdminTabPage.Text = "Category Admin";
            this.categoryAdminTabPage.UseVisualStyleBackColor = true;
            // 
            // userAdminTabPage
            // 
            this.userAdminTabPage.Location = new System.Drawing.Point(4, 24);
            this.userAdminTabPage.Name = "userAdminTabPage";
            this.userAdminTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.userAdminTabPage.Size = new System.Drawing.Size(1084, 504);
            this.userAdminTabPage.TabIndex = 4;
            this.userAdminTabPage.Text = "User Admin";
            this.userAdminTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.recipeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipeGridView.Location = new System.Drawing.Point(65, 93);
            this.recipeGridView.Name = "dataGridView1";
            this.recipeGridView.RowTemplate.Height = 25;
            this.recipeGridView.Size = new System.Drawing.Size(895, 349);
            this.recipeGridView.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 703);
            this.Controls.Add(this.mainTabs);
            this.Name = "Main";
            this.Text = "Main";
            this.mainTabs.ResumeLayout(false);
            this.recipesPage.ResumeLayout(false);
            this.favouritePage.ResumeLayout(false);
            this.recipeAdminTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recipeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabs;
        private System.Windows.Forms.TabPage recipesPage;
        private System.Windows.Forms.TabPage favouritePage;
        private System.Windows.Forms.FlowLayoutPanel recipesFlowPanel;
        private System.Windows.Forms.FlowLayoutPanel favouriteRecipesFlowLayoutPanel;
        private System.Windows.Forms.Button addRecipeButton;
        private System.Windows.Forms.TabPage recipeAdminTabPage;
        private System.Windows.Forms.TabPage categoryAdminTabPage;
        private System.Windows.Forms.TabPage userAdminTabPage;
        private System.Windows.Forms.DataGridView recipeGridView;
    }
}