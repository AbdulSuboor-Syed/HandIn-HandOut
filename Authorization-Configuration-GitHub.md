## Authorization using GitHub:

### 1. Enabling SSL in the project:

Step 1: Open the project file HandInHandOut.sln in Microsoft Visual Studio (2019) <br>
Step 2: Open Solution explorer<br>
Step 3: Right click on the project folder -> click on properties -> In the debug tab scroll down until you see the SSL check box -> Make sure you check the Enable SSL checkbox<br>
Step 4: Copy the localhost link<br>

### 2. Creating credentials for GitHub:<br>

Step 1: Login to your account in GitHub<br>
Step 2: Click on the drop down by clicking on the profile picture.<br>
Step 3: Click on settings.<br>
Step 4: Scroll down until you see Developer settings on the left side of the page.<br>
Step 5: Click on OAuth Apps.<br>
Step 6: Click on New OAuth app.<br>
Step 7: Name the application to your preference.<br>
Step 8: For Homepage URL use the "**step 4**" link from subheading "**1. Enabling SSL in project**".<br>
Step 9: For Authorization callback URL use the same url as "Homepage URL/sigin-github" and register the application.<br>
Step 10: Generate Client secret and copy them to a notepad.<br>

### 3. Setting up client Secret and client id

Step 1: Open the project file HandInHandOut.sln and open startup.cs.<br>
Step 2: Change the string "GitHub:ClientSecret" with your client secret.<br>
Step 3: Change the string "GitHub:ClientSecret" with your client Id.<br>
