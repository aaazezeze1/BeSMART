# BeSMART Notes App
BeSMART is a user-friendly notes application that allows users to take notes efficiently, manage their schedule and tasks, as well as review their educational materials.  

This application is our Final Project in ITEC 103 (Intermediate Programming). Project made by Amazing Grace Cabiles and Cyrelle Kristin Gapit from BSCS-1B.  

# Application Screenshots

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

2. Visual Studio Bug - Media Player disappeared or enlarged itself. This is due to the app being set to 125% dpi scaling by default. The app
does not support monitors or screen lower than 14 inches or greater 15.6 inches. Windows will automatically resize the media player if
the display scale setting is set to 100% and the screen size is not 14 or 15.6 inches which leads to this problem.

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
