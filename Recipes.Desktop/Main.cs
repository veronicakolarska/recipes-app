﻿using Recipes.Data.Models;
using Recipes.Services.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipes.Desktop
{
    public partial class Main : Form
    {
        private ICategoryService categoryService;
        private IRecipeService recipeService;

        public Main(ICategoryService categoryService, IRecipeService recipeService)
        {

            this.categoryService = categoryService;
            this.recipeService = recipeService;

            this.InitializeComponent();

            this.FormClosed += this.Main_FormClosed;

            var allRecipes = this.recipeService
                .GetAll()
                .OrderByDescending((x) => x.CreatedOn)
                .ToList();

            var recipeTiles = allRecipes.Select((recipe) =>
            {
                var recipeTile = new RecipeTile(recipe);
                recipeTile.Click += this.RecipeTile_Click;
                return (Control)recipeTile;
            }).ToArray();

            this.recipesFlowPanel.Controls.AddRange(recipeTiles);

            // TODO: Remove when testing is done!
            var recipeTile = new RecipeTile(new Recipe { Id = 1, Name = "Test recipe1!" });
            recipeTile.Click += this.RecipeTile_Click;

            var recipeTile2 = new RecipeTile(new Recipe { Id = 2, Name = "Test recipe2!" });
            recipeTile2.Click += this.RecipeTile_Click;

            this.recipesFlowPanel.Controls.Add(recipeTile);
            this.recipesFlowPanel.Controls.Add(recipeTile2);
        }

        private void RecipeTile_Click(object sender, EventArgs e)
        {
            var tile = (RecipeTile)sender;
            MessageBox.Show($"Tile Clicked! {tile.RecipeId}");
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            var allOpenForms = Application.OpenForms.Cast<Form>();
            foreach (var form in allOpenForms)
            {
                form.Close();
            }
        }
    }
}
