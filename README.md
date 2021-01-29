# Recipes desktop app - University Project

This is a university application for recipe management.

## Main project requirements

  - `.NET 5` and `WinForms`
  - `Entity Framework Core 5.0`
  -  login / register form with user roles
  -  create, update and delete panels for registered user or administrator

## Project structure.

The following projects serve the following roles:

- Recipes.Data - stores EFCore implementation of the repository pattern. Connection to the DB and operations on the DB are defined here.
- Recipes.Data.Models - stores database models used in the whole application.
- Recipes.Common - common code for the other projects - constants.
- Recipes.Services.Data - services for the business logic. Defines functionality for every entity.
- Recipes.Desktop - WinForms project.