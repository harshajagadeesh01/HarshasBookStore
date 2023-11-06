2023-10-23

15:35 Created net5.0 Web App for the project name "HarshasBookStore" with 'Individual User Account' Authentication and initialized it with a README.txt

15:40 Inside Startup.cs removed removed the contents inside services.AddDefaultIdentity<IdentityUser>() <Emptied that parameters for IndentitiyUser>()

2023-10-24

11:01 Created a github repository with a repository name "HarshasBookStore" and cloned the project.

11:20 Finished Part 1 1.2 Debugging and tested the project by settting up breakpoints for IActionResult methods

11:45 Replaced bootstrap.css and site.css

2023-10-30

14:00 Renamed href section and changed the css name from bootstrap.min.css to bootstrap.css _Layout.css Made modifications in the _Layout.css html

14:15 Ran the project and output is working fine with the updated css design. 

14:20 made a commit to github

14:40 inlcuded additional css and javascripts files to be used from CSS_JS.txt into _Layout.cshtml

14:50 added dropdown

16:00 Changed the dropdown title from Dropdown link to Content Management

16:20 Added three new projects(.NET Core class library) to the application and copied Data folder to DataAcess project

16:40 Installed Microsoft.EntityFramework.Core.Relational and Core.SqlServer packages to .DataAccess project and deleted the migration folder

20:45 Created a NEW MVC App and reacreated all the steps all over again from the beginning because i had chosen the option "place project and solution in the same directory" which was causing an error
when trying to open the project files from github

2023-10-31

9:45 Installed EntityFramework and Nuget packages to DataAccess project...

10:45 Moved Models folder to Books.Models and renamed folder to ViewModels and changed ErrorViewModels.cs namespace

10:50 Corrected the default reference to ErrorViewModel in Error.cshtml, fixed all errors and ran the application

11:20 Fixed all the errors, build was succesful and the output is working fine...

12:20 Added Customers area to Areas, moved HomeController.cs to Area>Customer>Controller folder and moved Views>Home folder

12:30 Copied ViewImport and ViewStart to Customer Area and ran the application and the output is working fine

12:50 Added new Admin area in Areas, Added proper view files and deleted Data and Models folder

12:55 Deleted the main controllers folder and finished part-1 of the assignment 2

2023-11-05

20:21 Started Working on the Part-2 of the Assignment 2

20:30 Made modifications to the appsettings.json

20:35 Using Nuget PM Console added a new migration with the migration name 'add-migration AddDefaultIdentityMigration'

20:40 Updated database in the packet manager console

20:50 Added a new class called Category.cs to .Models project and ran the PM command 'add-migration AddCategoryToDb'

2023-11-06

13:33  added a method public DbSet<Category> Categories { get; set; } and using HarshasBooks.Models; to ApplicationDbContext.cs file

13:43 Re-run the add-migration command 'add-migration AddCategoryToDb', resolved duplication error and updated the database
