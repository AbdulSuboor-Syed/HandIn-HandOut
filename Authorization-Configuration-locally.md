## Creating Custom user Admin
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
