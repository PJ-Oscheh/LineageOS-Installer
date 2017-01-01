These are the batch scripts used in the LineageOS Installer. When the application is built and published, the layout should look like this (where x represents the version number):

Lineage OS Installer vx.x-release.zip
-----------------------------------------------
	scripts\
	DO NOT OPEN LINEAGE INSTALL.txt
	LineageOS Installer.exe
	README.txt
	setup.bat
-----------------------------------------------

'DO NOT OPEN LINEAGE INSTALLER.txt' tells the user to open README for setup instructions.

'LineageOS Installer.exe' is the main program.

'README.txt' tells the user to run setup.bat rather than open the EXE file.

'setup.bat' creates and copies files to the `C:\Tools\LineageOSInstaller` directory

'scripts\' is where all the scripts live.
	'adb_check.bat' runs `adb devices` to ensure device is recognized over USB
	'install.bat' is the script that sets up LineageOS
	'startup.bat' creates 'LinOS-Files' directory



setup.bat will not work correctly unless the files are layed out as they are above. (so it will not function correctly inside youur clone)

And this goes without saying; feel free to modify these files! A gist is created for 'install.bat', and a link can be found in 'README.md' in the root of the `master` branch.
I will create gists for the other scripts if that is requested. 
