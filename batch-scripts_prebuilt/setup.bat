@echo off
color 37
echo Lineage OS Installer Setup
echo.
echo This will setup your LineageOS Installer in a directory called "C:\Tools\LineageOSInstaller"
echo The program will be created there because it is a simple self-extracting package; it does not determine if you have a 32 bit or 64 bit system.
pause
mkdir C:\Tools
mkdir C:\Tools\LineageOSInstaller
mkdir C:\Tools\LineageOSInstaller\scripts
copy "LineageOS Installer.exe" C:\Tools\LineageOSInstaller\
copy scripts C:\Tools\LineageOSInstaller\scripts
echo Finished! The program is located in C:\Tools\LineageOSInstaller.
echo Navigate to that directory, and open LineageOS Installer.exe
pause
color 07
exit