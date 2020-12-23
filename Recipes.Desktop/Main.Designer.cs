﻿
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
            this.recipesFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.favouritePage = new System.Windows.Forms.TabPage();
            this.favouriteRecipesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mainTabs.SuspendLayout();
            this.recipesPage.SuspendLayout();
            this.favouritePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabs
            // 
            this.mainTabs.Controls.Add(this.recipesPage);
            this.mainTabs.Controls.Add(this.favouritePage);
            this.mainTabs.Location = new System.Drawing.Point(57, 73);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(1092, 532);
            this.mainTabs.TabIndex = 0;
            // 
            // recipesPage
            // 
            this.recipesPage.Controls.Add(this.recipesFlowPanel);
            this.recipesPage.Location = new System.Drawing.Point(4, 24);
            this.recipesPage.Name = "recipesPage";
            this.recipesPage.Padding = new System.Windows.Forms.Padding(3);
            this.recipesPage.Size = new System.Drawing.Size(1084, 504);
            this.recipesPage.TabIndex = 0;
            this.recipesPage.Text = "recipes";
            this.recipesPage.UseVisualStyleBackColor = true;
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
            this.favouritePage.Text = "favourites";
            this.favouritePage.UseVisualStyleBackColor = true;
            // 
            // favouriteRecipesFlowLayoutPanel
            // 
            this.favouriteRecipesFlowLayoutPanel.Location = new System.Drawing.Point(76, 67);
            this.favouriteRecipesFlowLayoutPanel.Name = "favouriteRecipesFlowLayoutPanel";
            this.favouriteRecipesFlowLayoutPanel.Size = new System.Drawing.Size(933, 370);
            this.favouriteRecipesFlowLayoutPanel.TabIndex = 1;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabs;
        private System.Windows.Forms.TabPage recipesPage;
        private System.Windows.Forms.TabPage favouritePage;
        private System.Windows.Forms.FlowLayoutPanel recipesFlowPanel;
        private System.Windows.Forms.FlowLayoutPanel favouriteRecipesFlowLayoutPanel;
    }
}