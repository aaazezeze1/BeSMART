# BeSMART Notes App
BeSMART is a simple notes application for Windows that has a few extra features intended to be used offline and for
students.

This application is our Final Project in ITEC 103 (Intermediate Programming). 
Project made by Amazing Grace Cabiles and Cyrelle Kristin Gapit from BSCS-1B.

# What we used for the project
1. Visual Studio Community 2022 (17.9.5)
2. .NET 8 (Long Term Support)
3. Built In Libraries of C#
4. Newtonsoft.Json by James Newton-King (13.0.3)
5. System.Windows.Extensions by Microsoft (version 8.0.0)

# Important Notes
1. The alarm sound will not work if the wav file included in the Windows OS is not found in the computer. 
2. The project may not work on older .NET versions or newer versions of the software or libraries used.
3. The library used for playing music (Sound Player) is made by Microsoft and used to be built in by default. However in 
Visual Studio 2022 the System.Media library has to be installed using the NuGet package manager.
4. Newtonsoft.Json has to be installed or else te currency converter will not work.
5. The video player is small. If the user wants to make it full screen then the user will have to click the video player twice.

Note: After installing Newtonsoft.Json using NuGet, go to the project's solution and click Rebuild Solution. Once it's done, 
Newtonsoft can now be imported by typing using Newtonsoft.Json.Linq;

# Bugs Encountered
1. Visual Studio Bug - Form2.Designer.cs or the C# design file for the converter *sometimes* has a problem with running 
due to the formula image that has to be loaded. Sometimes it works but there are times where the project is reloaded 
or reopened in Visual Studio and the compiler will throw an error that NotesApp does not have "Properties". The solution
for this is to simply go to Form2.Designer.cs and look for pictureBox1. Then replace pictureBox1.Image = 
NotesApp.Properties.Resources.Screenshot_2024_04_21_1801342; with just pictureBox1.Image = Properties.Resources.Screenshot_2024_04_21_1801342;

2. Visual Studio Bug - "Could not Copy" means the application did not close fully. Sometimes when the app is closed, it still runs in the 
background (you can notice it on the task manager). This is a Visual Studio bug and unfortunaly the only solution is to 
go open Task Manager, on the Processes tab click the Search bar. Type BeSMART and you will see the application running in 
the background. Click on the application and click on End Task.

**The code works fine for the most part but for some reason, Visual Studio likes adding NotesApp to the picture box everytime the project is reloaded.**

# Things to Improve
1. Get a new API key that shows the latest currency exchange rate. The API key that this project uses is outdated and not updated.

2. Keep the history of the created notes and display it in the data grid view.  
Once the application is reloaded again, the history or previous txt files created will be gone from the data grid view. 

*The saved txt files can still be found on the users machine where they stored it. Only the history disappears upon reload.*

3. Make the delete button in the notes app also delete the actual file created. The delete button only deletes the notes 
entry (sort of like a history tab of the created notes) not the note itself so the user has to delete the notes manually.

4. Make the music player be able to play a playlist instead of just one song
The media player library of Microsoft can only play one music so the user has to select another music file afterwards.
Use the AxWMPLib instead to play a full playlist like in the media player of BeSMART.

5. Add a Database
Add a database to keep the "history" of the created entries of notes, to-do lists, and calendar events. 