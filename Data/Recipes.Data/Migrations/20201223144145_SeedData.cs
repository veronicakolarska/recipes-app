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
                    { 1, new DateTime(2020, 12, 23, 16, 41, 45, 398, DateTimeKind.Local).AddTicks(7694), "I'm 20 years old", "someMail@abv.bg", "shorturl.at/ltyFY", null, "123FDGEF", 1 },
                    { 2, new DateTime(2020, 12, 23, 16, 41, 45, 400, DateTimeKind.Local).AddTicks(7493), "Hello there", "other@abv.bg", "shorturl.at/ltyFY", null, "12FddFDDGEF2", 1 },
                    { 3, new DateTime(2020, 12, 23, 16, 41, 45, 400, DateTimeKind.Local).AddTicks(7515), "I'm new here", "email@abv.bg", "shorturl.at/ltyFY", null, "werDGEF2", 1 },
                    { 4, new DateTime(2020, 12, 23, 16, 41, 45, 400, DateTimeKind.Local).AddTicks(7518), "Admin", "email@abv.bg", "shorturl.at/ltyFY", null, "ggdsg@gmail.com", 2 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedOn", "CreatorId", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 12, 23, 16, 41, 45, 401, DateTimeKind.Local).AddTicks(7699), 4, null, "Salads" },
                    { 2, new DateTime(2020, 12, 23, 16, 41, 45, 401, DateTimeKind.Local).AddTicks(8071), 4, null, "Soups" },
                    { 3, new DateTime(2020, 12, 23, 16, 41, 45, 401, DateTimeKind.Local).AddTicks(8082), 4, null, "Main dishes" },
                    { 4, new DateTime(2020, 12, 23, 16, 41, 45, 401, DateTimeKind.Local).AddTicks(8084), 4, null, "Vegetarian" },
                    { 5, new DateTime(2020, 12, 23, 16, 41, 45, 401, DateTimeKind.Local).AddTicks(8087), 4, null, "Desserts" },
                    { 6, new DateTime(2020, 12, 23, 16, 41, 45, 401, DateTimeKind.Local).AddTicks(8089), 4, null, "Drinks" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "CreatorId", "Description", "ModifiedOn", "Name", "TitleImageUrl" },
                values: new object[] { 1, 3, new DateTime(2020, 12, 23, 16, 41, 45, 402, DateTimeKind.Local).AddTicks(2136), 1, "Traditional Bulgarian dish", null, "Musaka", "shorturl.at/zAGI3" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "CreatorId", "Description", "ModifiedOn", "Name", "TitleImageUrl" },
                values: new object[] { 2, 5, new DateTime(2020, 12, 23, 16, 41, 45, 402, DateTimeKind.Local).AddTicks(2150), 3, "Classic chocolate cake", null, "Chocolate cake", "shorturl.at/fzBES" });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "CreatedOn", "ModifiedOn", "Name", "Quantity", "RecipeId", "Unit" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 12, 23, 16, 41, 45, 402, DateTimeKind.Local).AddTicks(4219), null, "Potatoes", 1.5m, 1, "kg" },
                    { 2, new DateTime(2020, 12, 23, 16, 41, 45, 402, DateTimeKind.Local).AddTicks(4231), null, "Meat", 0.7m, 1, "kg" },
                    { 3, new DateTime(2020, 12, 23, 16, 41, 45, 402, DateTimeKind.Local).AddTicks(4235), null, "Milk", 1m, 2, "ml" },
                    { 4, new DateTime(2020, 12, 23, 16, 41, 45, 402, DateTimeKind.Local).AddTicks(4237), null, "Biscuits", 0.25m, 2, "kg" },
                    { 5, new DateTime(2020, 12, 23, 16, 41, 45, 402, DateTimeKind.Local).AddTicks(4240), null, "Chocolate", 0.2m, 2, "kg" }
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
