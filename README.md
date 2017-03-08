# Easy-Sleep-Tool-For-Macro-Keyboards
A Simple Commandline Tool For putting a computer to sleep intended for use with keyboard macros

# Usage
##From The Help 
Default Usage forces sleep mode and allows for software wake event

Sleep:     forces sleep mode and allows software wake event

Hibernate: forces hybernate and allows for software wake event

NoWake:    disables software wake event

Nice:      disables forced power state change
##Example Using CUE (Corsair Utility Engine)
1. Make a new macro or Action which uses an installed application

2. With the application in a folder you can remember point the utility at the application

3. After the application name add flags as described above (with spaces) inorder to use the utility as desired
##Example
From my macro the text area for using an Action (key press) to "Launch application" looks as follows

With "Run The Following Program" Selected I have the following 

"C:\Program Files (x86)\EasySleepForMacro.exe" Nice
