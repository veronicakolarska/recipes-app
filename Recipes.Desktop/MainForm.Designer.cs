﻿
namespace Recipes.Desktop
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.recipesPage = new System.Windows.Forms.TabPage();
            this.recipeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.addRecipeButton = new System.Windows.Forms.Button();
            this.recipesFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.recipeAdminTabPage = new System.Windows.Forms.TabPage();
            this.categoryAdminTabPage = new System.Windows.Forms.TabPage();
            this.userAdminTabPage = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.logoutButton = new System.Windows.Forms.Button();
            this.userProfilePanel = new System.Windows.Forms.Panel();
            this.mainTabs.SuspendLayout();
            this.recipesPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabs
            // 
            this.mainTabs.Controls.Add(this.recipesPage);
            this.mainTabs.Controls.Add(this.recipeAdminTabPage);
            this.mainTabs.Controls.Add(this.categoryAdminTabPage);
            this.mainTabs.Controls.Add(this.userAdminTabPage);
            this.mainTabs.Location = new System.Drawing.Point(57, 73);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(1020, 532);
            this.mainTabs.TabIndex = 0;
            // 
            // recipesPage
            // 
            this.recipesPage.Controls.Add(this.recipeTypeComboBox);
            this.recipesPage.Controls.Add(this.addRecipeButton);
            this.recipesPage.Controls.Add(this.recipesFlowPanel);
            this.recipesPage.Location = new System.Drawing.Point(4, 24);
            this.recipesPage.Name = "recipesPage";
            this.recipesPage.Padding = new System.Windows.Forms.Padding(3);
            this.recipesPage.Size = new System.Drawing.Size(1012, 504);
            this.recipesPage.TabIndex = 0;
            this.recipesPage.Text = "All Recipes";
            this.recipesPage.UseVisualStyleBackColor = true;
            // 
            // recipeTypeComboBox
            // 
            this.recipeTypeComboBox.AllowDrop = true;
            this.recipeTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.recipeTypeComboBox.FormattingEnabled = true;
            this.recipeTypeComboBox.Items.AddRange(new object[] {
            "All Recipes",
            "My Recipes",
            "Favourite Recipes"});
            this.recipeTypeComboBox.Location = new System.Drawing.Point(178, 29);
            this.recipeTypeComboBox.Name = "recipeTypeComboBox";
            this.recipeTypeComboBox.Size = new System.Drawing.Size(121, 23);
            this.recipeTypeComboBox.TabIndex = 2;
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
            this.recipesFlowPanel.AutoScroll = true;
            this.recipesFlowPanel.Location = new System.Drawing.Point(68, 70);
            this.recipesFlowPanel.Name = "recipesFlowPanel";
            this.recipesFlowPanel.Size = new System.Drawing.Size(933, 370);
            this.recipesFlowPanel.TabIndex = 0;
            // 
            // recipeAdminTabPage
            // 
            this.recipeAdminTabPage.Location = new System.Drawing.Point(4, 24);
            this.recipeAdminTabPage.Name = "recipeAdminTabPage";
            this.recipeAdminTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.recipeAdminTabPage.Size = new System.Drawing.Size(1012, 504);
            this.recipeAdminTabPage.TabIndex = 2;
            this.recipeAdminTabPage.Text = "Recipe Admin";
            this.recipeAdminTabPage.UseVisualStyleBackColor = true;
            // 
            // categoryAdminTabPage
            // 
            this.categoryAdminTabPage.Location = new System.Drawing.Point(4, 24);
            this.categoryAdminTabPage.Name = "categoryAdminTabPage";
            this.categoryAdminTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.categoryAdminTabPage.Size = new System.Drawing.Size(1012, 504);
            this.categoryAdminTabPage.TabIndex = 3;
            this.categoryAdminTabPage.Text = "Category Admin";
            this.categoryAdminTabPage.UseVisualStyleBackColor = true;
            // 
            // userAdminTabPage
            // 
            this.userAdminTabPage.Location = new System.Drawing.Point(4, 24);
            this.userAdminTabPage.Name = "userAdminTabPage";
            this.userAdminTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.userAdminTabPage.Size = new System.Drawing.Size(1012, 504);
            this.userAdminTabPage.TabIndex = 4;
            this.userAdminTabPage.Text = "User Admin";
            this.userAdminTabPage.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(1336, 28);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // userProfilePanel
            // 
            this.userProfilePanel.Location = new System.Drawing.Point(1117, 97);
            this.userProfilePanel.Name = "userProfilePanel";
            this.userProfilePanel.Size = new System.Drawing.Size(294, 508);
            this.userProfilePanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 628);
            this.Controls.Add(this.userProfilePanel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.mainTabs);
            this.Name = "MainForm";
            this.Text = "Main";
            this.mainTabs.ResumeLayout(false);
            this.recipesPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabs;
        private System.Windows.Forms.TabPage recipesPage;
        private System.Windows.Forms.FlowLayoutPanel recipesFlowPanel;
        private System.Windows.Forms.Button addRecipeButton;
        private System.Windows.Forms.TabPage recipeAdminTabPage;
        private System.Windows.Forms.TabPage categoryAdminTabPage;
        private System.Windows.Forms.TabPage userAdminTabPage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Panel userProfilePanel;
        private System.Windows.Forms.ComboBox recipeTypeComboBox;
    }
}