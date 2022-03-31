# Pre-requesition:

1. Install choclatey
2. Open Powershell as administrator
3. Type the command
   > choco install docfx
4. Open the project in local repository and delete all the following files<br>
   ![img](https://user-images.githubusercontent.com/77799896/160996677-def34bf9-1edb-4f75-8c64-72dae30f2503.png)

# Compile/Build/Run

1. Open the project in Microsoft Visual Studio
2. Rigth Click on ![image](https://user-images.githubusercontent.com/77645775/160992784-8ec86755-f625-463f-a5e5-0185c5d38080.png)
3. Click on Manage NuGet Packages ..
4. Click on docfx.console
   ![image](https://user-images.githubusercontent.com/77645775/160993178-78f36d17-4765-41dc-8be6-ea2b5fa258af.png)
5. Click on uninstall <br>
   ![image](https://user-images.githubusercontent.com/77645775/160993262-343a57e2-070e-4dd3-8927-3587f578f677.png)
6. Click on Browse> type docfx.console> install
   ![image](https://user-images.githubusercontent.com/77645775/160993565-fa176df7-27d6-473f-afef-f8001b7bd189.png)
7. Click on ![image](https://user-images.githubusercontent.com/77645775/160993707-8e77792e-7421-4a82-b88f-e333afcf569b.png) to run the application and it will auto generate the documentation.
8. Open Powershell as administration in HandInHandOut folder<br>
   ![image](https://user-images.githubusercontent.com/77645775/160995800-2c74c7c8-ba6b-4c50-bdf9-0cac621fb9be.png)
9. Enter the command to commpile and run docfx locally 
> docfx docfx.json <br>
> docfx serve _site
