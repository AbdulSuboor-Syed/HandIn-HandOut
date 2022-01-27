# HandIn-HandOut:
This project is dedicated to help university to showcase the book's that are available and allow students to view information about buying price, renting price and also information on students can sell their old books.

## External Requirement:
[Microsoft Visual Studio (2019)](https://visualstudio.microsoft.com/downloads/): Install the Community version.<br>
[Azure Account](https://azure.microsoft.com/en-us/): If you wish to deploy on Azure please get an account for Azure cloud services <br>

## Setup:

### Please follow these steps after installation of Microsoft Visual Studio 2019 (Community version)
Step 1: Open the code on Visual studio 2019 <br>
Step 2: Click on Tools > Options > NuGet Package Manager > Package Sources <br>
Click on + symbol <br>
Rename the file with Name as nuget.org and Source as https://api.nuget.org/v3/index.json <br>
Click update and click on Ok <br>
Step 3: Click on View > Other Windows > Package Manager Console <br>
Here type the command Update-Database <br>


## Running

Step 1: Open the project in Microsoft Visual Studio 2019.<br>
Step 2: Open the Solution Explorer.<br>
Step 3: Click on Controller> AdministrationController. Remove the line [Authorize(Roles ="Admin")]<br>
Step 4: Run the application.<br>
Step 5: In the navigation bar click on Register.<br>
Step 6: Register an account to act as admin <br>
Step 7: Now navigate to /administration/CreateRole. Here Create a role as Admin. <br>
Step 8: Now navigate to /Administration/ListUsers. Here find the account you wish to act as Admin.<br>
Step 9: Now go back to Step 3 and add the line [Authorize(Roles ="Admin")].<br>
Step 10: Now Login using your admin user id and click on Mange drop down link on the navigation bar > Click on Users > Find the admin account in the list of users > Click on edit > Click on manage user claim > Check all the boxes to allow the admin to edit,create and delete.<br>

Now you have an admin account which can create, edit and delete books.
