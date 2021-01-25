# Recipes desktop app - University Project

This is a unviersity application for recipe managment.

## Main project requirements

  - `.NET 5` and `WinForms`
  - `Entity Framework Core 5.0`
  -  login / register form with user roles
  -  create, update and delete panels for registered user or administrator

## Project structure.

The following projects serve the following roles:

- Recipes.Data - stores EFCore implementation of the repository pattern. Connection to the DB and operations on the DB are defined here.
- Recipes.Data.Common - interfaces for data and the repository pattern.