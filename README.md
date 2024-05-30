# university

In project i use entity framework with Sqlite database
To generate db schema (tables and columns (name + type)) and update database: use the Package Manager Console in Visual Studio

After updating models please execute:
 - Add-Migration AddCarModel
 - dotnet ef migrations add InitialCreate

To run project please execute command to update database:
- Update-Database

or

- dotnet ef database update