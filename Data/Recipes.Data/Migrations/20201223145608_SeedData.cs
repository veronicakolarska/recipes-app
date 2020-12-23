using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Recipes.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatorId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Users_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: true),
                    TitleImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatorId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipes_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recipes_Users_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FavouriteRecipes",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavouriteRecipes", x => new { x.UserId, x.RecipeId });
                    table.ForeignKey(
                        name: "FK_FavouriteRecipes_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FavouriteRecipes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingredients_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedOn", "Description", "Email", "ImageUrl", "ModifiedOn", "Password", "Role" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 12, 23, 16, 56, 8, 348, DateTimeKind.Local).AddTicks(4843), "I'm 20 years old", "someMail@abv.bg", "https://p7.hiclipart.com/preview/780/873/166/cooking-mama-world-kitchen-cooking-mama-lets-cookuff01-puzzle-cooking-mama-cooking-png-photo-thumbnail.jpg", null, "123FDGEF", 1 },
                    { 2, new DateTime(2020, 12, 23, 16, 56, 8, 350, DateTimeKind.Local).AddTicks(2913), "Hello there", "other@abv.bg", "https://p7.hiclipart.com/preview/780/873/166/cooking-mama-world-kitchen-cooking-mama-lets-cookuff01-puzzle-cooking-mama-cooking-png-photo-thumbnail.jpg", null, "12FddFDDGEF2", 1 },
                    { 3, new DateTime(2020, 12, 23, 16, 56, 8, 350, DateTimeKind.Local).AddTicks(2935), "I'm new here", "email@abv.bg", "https://p7.hiclipart.com/preview/780/873/166/cooking-mama-world-kitchen-cooking-mama-lets-cookuff01-puzzle-cooking-mama-cooking-png-photo-thumbnail.jpg", null, "werDGEF2", 1 },
                    { 4, new DateTime(2020, 12, 23, 16, 56, 8, 350, DateTimeKind.Local).AddTicks(2938), "Admin", "email@abv.bg", "https://p7.hiclipart.com/preview/780/873/166/cooking-mama-world-kitchen-cooking-mama-lets-cookuff01-puzzle-cooking-mama-cooking-png-photo-thumbnail.jpg", null, "ggdsg@gmail.com", 2 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedOn", "CreatorId", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 12, 23, 16, 56, 8, 351, DateTimeKind.Local).AddTicks(3161), 4, null, "Salads" },
                    { 2, new DateTime(2020, 12, 23, 16, 56, 8, 351, DateTimeKind.Local).AddTicks(3540), 4, null, "Soups" },
                    { 3, new DateTime(2020, 12, 23, 16, 56, 8, 351, DateTimeKind.Local).AddTicks(3549), 4, null, "Main dishes" },
                    { 4, new DateTime(2020, 12, 23, 16, 56, 8, 351, DateTimeKind.Local).AddTicks(3552), 4, null, "Vegetarian" },
                    { 5, new DateTime(2020, 12, 23, 16, 56, 8, 351, DateTimeKind.Local).AddTicks(3554), 4, null, "Desserts" },
                    { 6, new DateTime(2020, 12, 23, 16, 56, 8, 351, DateTimeKind.Local).AddTicks(3556), 4, null, "Drinks" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "CreatorId", "Description", "ModifiedOn", "Name", "TitleImageUrl" },
                values: new object[] { 1, 3, new DateTime(2020, 12, 23, 16, 56, 8, 351, DateTimeKind.Local).AddTicks(7645), 1, "Traditional Bulgarian dish", null, "Musaka", "https://i0.wp.com/www.kashkaval-tourist.com/wp-content/uploads/2014/02/musaka.jpg" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "CreatorId", "Description", "ModifiedOn", "Name", "TitleImageUrl" },
                values: new object[] { 2, 5, new DateTime(2020, 12, 23, 16, 56, 8, 351, DateTimeKind.Local).AddTicks(7661), 3, "Classic chocolate cake", null, "Chocolate cake", "https://cdn.sallysbakingaddiction.com/wp-content/uploads/2013/04/triple-chocolate-cake-4.jpg" });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "CreatedOn", "ModifiedOn", "Name", "Quantity", "RecipeId", "Unit" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 12, 23, 16, 56, 8, 351, DateTimeKind.Local).AddTicks(9759), null, "Potatoes", 1.5m, 1, "kg" },
                    { 2, new DateTime(2020, 12, 23, 16, 56, 8, 351, DateTimeKind.Local).AddTicks(9771), null, "Meat", 0.7m, 1, "kg" },
                    { 3, new DateTime(2020, 12, 23, 16, 56, 8, 351, DateTimeKind.Local).AddTicks(9775), null, "Milk", 1m, 2, "ml" },
                    { 4, new DateTime(2020, 12, 23, 16, 56, 8, 351, DateTimeKind.Local).AddTicks(9777), null, "Biscuits", 0.25m, 2, "kg" },
                    { 5, new DateTime(2020, 12, 23, 16, 56, 8, 351, DateTimeKind.Local).AddTicks(9779), null, "Chocolate", 0.2m, 2, "kg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CreatorId",
                table: "Categories",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_FavouriteRecipes_RecipeId",
                table: "FavouriteRecipes",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_RecipeId",
                table: "Ingredients",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_CategoryId",
                table: "Recipes",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_CreatorId",
                table: "Recipes",
                column: "CreatorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavouriteRecipes");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
