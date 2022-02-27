# HandIn-HandOut:

[![Codacy Badge](https://app.codacy.com/project/badge/Grade/8741185222434701afd1fee193e59659)](https://www.codacy.com/gh/AbdulSuboor-Syed/HandIn-HandOut/dashboard?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=AbdulSuboor-Syed/HandIn-HandOut&amp;utm_campaign=Badge_Grade)<br>

This project is dedicated to help university to showcase the book's that are available and allow students to view information about buying price, renting price and also information on how students can sell their old books.


## Stack:
Front-End: Html, Javascript, Bootstrap<br>
Back End: C#&ASP.Net<br>
Database: Azure cloud Database<br>

## External Requirement:
[Microsoft Visual Studio (2019)](https://visualstudio.microsoft.com/downloads/): Install the Community version.<br>
[Azure Account](https://azure.microsoft.com/en-us/): If you wish to deploy on Azure please get an account for Azure cloud services <br>




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
