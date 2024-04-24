# NotesApp
Final Project in ITEC 103 (Intermediate Programming). Made by Amazing Grace Cabiles and Cyrelle Kristin Gapit from BSCS-1B.

# What we used for the project
1. Visual Studio Community 2022 (17.9.5)
2. .NET 8 (Long Term Support)
3. Built In Libraries of C#
4. Newtonsoft.Json by James Newton-King (13.0.3)
5. System.Windows.Extensions by Microsoft (version 8.0.0)

# Important Notes
1. The alarm sound will not work if the operating system used is not Windows or the wav file included in Windows OS 
is not found in the computer. 
2. The project may not work on older .NET versions or older versions of the software or libraries used.
3. The library used for playing music (Sound Player) is made by Microsoft and used to be built in by default. However in 
Visual Studio 2022 the System.Media library has to be installed using the NuGet package manager.
4. Newtonsoft.Json has to be installed or else te currency converter will not work.

Note: After installing Newtonsoft.Json using NuGet, go to the project's solution and click Rebuild Solution. Once it's done, 
Newtonsoft can now be imported by typing using Newtonsoft.Json.Linq;

# Bugs Encountered
1. Visual Studio Bug - Form2.Designer.cs or the C# design file for the converter *sometimes* has a problem with running 
due to the formula image that has to be loaded. Sometimes it works but there are times where the project is reloaded 
or reopened in Visual Studio and the compiler will throw an error that NotesApp does not have "Properties". The solution
for this is to simply go to Form2.Designer.cs and look for pictureBox1. Then replace pictureBox1.Image = 
NotesApp.Properties.Resources.Screenshot_2024_04_21_1801342; with just pictureBox1.Image = Properties.Resources.Screenshot_2024_04_21_1801342;

**The code works fine for the most part but for some reason, Visual Studio likes adding NotesApp to the picture box everytime the project is reloaded.**

# Things to Improve
1. Get a new API key that shows the latest currency exchange rate. The API key that this project uses is outdated and not updated.
2. Change the file name of the image formula. The reason why we didn't rename it is because if it gets renamed then 
theres a chance that we would have to code the project all over again because that one error is almost impossible to fix.

*"I accidentally permanently deleted the file while renaming it and had to clone the project all over again just to add
the image back. I had a copy of the screenshot and would rather not go through the pain of redoing the project for 
just renaming one image" - Amaze*

3. Change the Form names instead of leaving it as Form1, Form2 and so on for better readability and organization.
4. Find a way to keep the history of the created notes and display it in the data grid view.  
Once the application is reloaded again, the history or previous txt files created will be gone from the data grid view. 

*The saved txt files can still be found on the users machine where they stored it. Only the history disappears upon reload.*

5. Add an extra music file for the timer notification incase the user runs the app in other OS's.
6. Make the UI look more modern.