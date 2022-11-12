Date 27/10/2022 Time 6:50 PM
I started making new web application
I named it "FenilsBookStore" 
Made a github Repository
take a break
07:00 PM

**************************************************************************
						(PART-1)

Date: 10/29/2022 9:12PM

Correct Date formation:
2022-10-29  Time : 9:12 PM

I resumed my assignment......
I update code in Startup.cs file 
Erase option in identity user

9:20PM
Debugging with the Index and then Privacy pages successfully....

Download Bootstarp.css theme of Pulse from the website Bootswatch.com
Added Bootstrap.css in the css folder
Linked the Bootstarp.css in Layout.cshtml
Run the application it doesn't work .........

Update with my code in Layout.cshtml by removing text-dark 
Changed code in footer line...
Run the application .....9:44Pm
It works successfully....
Update my Readme.txt

Update with my layout.cshtml file by adding some codes.....
Linked stylesheets and script file from css_js.txt to the Layout.cshtml
Added dropdown option in the navigation bar of the application.
Run the application dropdown icon is showing..... but options are not showing.
Something is missing I dont know as the code line is not given properly
in the tutorial.....
10:14 PM I am done today I will ask my proffesor about the code...

*********************************************************************************
Date: 03/11/2022 Time: 7:16 PM

Correct Date formation:
2022-11-03    Time: 7:16 PM

Resume with my assignment.......
Update code in the layout.cshtml file with adding content management ....
run the application it run successfully.....
Dropdown menu works.....
All function works properly till 1.3 Step of the Part-1
Added a new file in the application README.md 

Check my Web application once again it works successfully... 
8:08 PM now time to move on Step 1.4 Add projects and modify.

Added new project and classes named such as:
FenilsBooks.DataAccess
FenilsBooks.Models
FenilsBooks.Utility
Update my Readme.txt 
Added NuGet Packages Microsoft.EntityFrameworkCore.Relational and SqlServer
to the all new project..
Move data folder to the FenilsBooks.DataAccess and delete the original one
Delete All the class 
Build the project
Move Models in FenilsBooks.Models and delete the original one.
Modify error.cshtml, and added a project reference .DataAccess and .Models
Rename Model to ViewModels , Change ErrorViewModels.cs namespace  
.ModelsViewModels Buil the project
Buil Successfully time is 9:20 Pm
Now changes the startup.cs file run the application and see the error 
solve error and change ErrorViewModel to the .Models.ViewModels.ErrorViewModels.
Run the application Time is 9:30Pm
It Works ........
Update my Readme.txt....

Time to take break 9:39PM 
Resume With my assignment 9:49PM..........
In the Utility project create static details class known as SD.cs
Modify the properties of the class
Add project reference to the main project
In DataAccess project reference Models and Utility..
Added a customer area in areas
Change Startup.cs file 
Move HomeController.cs to the Area > Customer> Controller folder>
and delete Data and Models.
Edit HomeController.cs
Take a break 
Resumed assignment 
12:30 Am
Moved  Views > Home and modify Homecontroller namespace

Run the application it run successfully
welcome message seen..
moving further
Copy Viewstart and Viewimports in Customer Area
Added the new path in Viewstart.cshtml  
Run the application 1:12 AM
It works Successfully
upadte readme.txt.........

Add a New Admin Area in Areas folder
Added a proper view files
Delete Models and Data folder in it
Delete Controllers Folder
Run the application it works
Succesfully completed part-1 1:25 AM
Update my readme.txt file
Update My Readme.md file
1:27 Am 
********************************************************************************
					(PART-2)

2022-11-07  Time: 7:50 PM 

Started Part-2 after todays lecture.....
2.1 Build the project, Create the db
Build the applications and there is no error showing it works normally...
Change code in appsetting.json file modify the database and save it.
Use NuGet Package Manager Console to add migration with name AddDefaultIdentityMigration.
Wrong default project is selected than I select FenilsBooks.DataAccess and add migartion
Migration added successfully......
Update my readme file and now its time for a break 8:13 PM 

2022-11-10 Time: 8:30 PM

Resumed my Assignment
New Migration file name is 20221108010002_AddDefaultIdentityMigration.cs 
I found error while doing update-database 
Deleted whole migration folder but still Build Failed 
9:24 PM 
I started Part-2 Once again.

2022-11-12 Time: 03:01 PM

Tried to solve error search on web but doesnot found any solution
it showing SqlServerValueGenerationStrategy does not exist in the  current context.

03:05 PM Restart from Part-1.

5:10 PM completed Part-1 and added README.txt and README.md files

************* (Part-2 Again) *************
05:19 PM Now Part-2 
2.1  Creating Db
Build the application for checking there is no error....
No error found... Moved further
Review and change DefaultConnection code in appsettings.json
Create a migration using NuGet Package Manager Console.
New Migreation File is named by "20221112222454_AddDefaultIdentityMigration.cs"
Review the file as per SQL Syntax.
Update the database successfully...
Review SQL Server Object Explorer there were tables created in FenilsBookStore.
Run the application it works successfully 
Update Readme.txt 
05:39 PM