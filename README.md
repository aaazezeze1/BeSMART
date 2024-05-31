# BeSMART Notes App
BeSMART is a user-friendly notes application that allows users to take notes efficiently, manage their schedule and tasks, as well as review their educational materials.  

This application is our Final Project in ITEC 103 (Intermediate Programming). Project made by Amazing Grace Cabiles and Cyrelle Kristin Gapit from BSCS-1B.  

# Application Screenshots
![main](https://github.com/aaazezeze1/BeSMART/assets/81816019/4da2e880-abbe-449b-a46a-90370f6923e6)
![notes1](https://github.com/aaazezeze1/BeSMART/assets/81816019/b01156d9-3128-46d0-ba3b-065b7a2fd84b)
![notes2](https://github.com/aaazezeze1/BeSMART/assets/81816019/26e88d09-f590-46a1-b319-8a536f81b42c)
![calendar1](https://github.com/aaazezeze1/BeSMART/assets/81816019/e09115c9-76ec-41c6-a000-ef5367418101)
![calendar2](https://github.com/aaazezeze1/BeSMART/assets/81816019/ec747cf2-2295-4150-8cb7-49a3e2e87375)
![todo](https://github.com/aaazezeze1/BeSMART/assets/81816019/c202b840-74c7-4109-9d93-cef04e7edd4e)
![converter](https://github.com/aaazezeze1/BeSMART/assets/81816019/3ee242a7-2f81-4723-adcc-0fa05240c48f)
![formula1](https://github.com/aaazezeze1/BeSMART/assets/81816019/46513628-97b7-46c0-a19a-e6a14d089e66)
![formula2](https://github.com/aaazezeze1/BeSMART/assets/81816019/efc85442-ffce-4a44-a2f4-fd647a41700a)
![about](https://github.com/aaazezeze1/BeSMART/assets/81816019/d5d38cfa-044f-479b-a97e-f5eec6ad322e)
  
# What we used for the project
1. Visual Studio Community 2022 (17.9.5)
2. .NET 8 (Long Term Support)
3. Built In Libraries of C#
4. Newtonsoft.Json by James Newton-King (13.0.3)

# Important Notes
1. The alarm sound will not work if the wav file included in the Windows OS is not found in the computer. 
2. The project may not work on older .NET versions or newer versions of the software or libraries used.
3. Newtonsoft.Json has to be installed or else the currency converter will not work.

**Note: After installing Newtonsoft.Json using NuGet, go to the project's solution and click Rebuild Solution. Once it's done, 
Newtonsoft can now be imported by typing using Newtonsoft.Json.Linq;**

# Bugs Encountered
1. Visual Studio Bug - "Could not Copy" means the application did not close fully. Sometimes when the app is closed, it still runs in the 
background (you can notice it on the task manager). This is a Visual Studio bug and unfortunately the only solution is to 
go open Task Manager, on the Processes tab click the Search bar. Type BeSMART and you will see the application running in 
the background. Click on the application and click on End Task. Reopen the app again and make sure that when closing the app
all windows are close to prevent this error.  
  
2. Visual Studio Bug - Media Player disappeared or enlarged itself. This is due to the app being made for
125% dpi scaling. The app does not work well with monitors or screens lower than 14 inches or greater 
than 15.6 inches. Windows will automatically resize the media player if the display scale setting is 
set to 100% or any value other than 125% and the screen size is not 14 or 15.6 inches which leads to 
this problem. The application can work on screens that are larger than 15.6 inches but the display 
setting has to be set to 125%. **Doing it this way leads to the text being blurry.**  

![dpiscaling](https://github.com/aaazezeze1/BeSMART/assets/81816019/d73252a4-33f0-4ac4-90de-d824a6274247)
  
# Things to Improve
1. Get a new API key that shows the latest currency exchange rate.  
The API key that this project uses is outdated and not updated.

3. Keep the history of the created notes and display it in the data grid view.  
Once the application is reloaded again, the history or previous txt files created will be gone from the data grid view.  

**The saved txt files can still be found on the users machine where they stored it. Only the history disappears upon reload.**    

3. Make the delete button in the notes app also delete the actual file created.  
The delete button only deletes the notes entry (sort of like a history tab of the created notes) not the note itself so the user has to delete the notes manually.  

4. Add a Database.  
Add a database to keep the "history" of the created entries of notes, to-do lists, and calendar events.

5. Make the text style formatting work for other file extensions.    
Only .rtf or rich text formatting files can be styled.

6. Optimize the program.  
The program is poorly optimized and when a new feature is opened the previous feature is "hidden" instead of closed which
leads to multiple windows of the previously opened features slowing down the machine.
