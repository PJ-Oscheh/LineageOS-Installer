@echo off
echo Restarting Device...
adb reboot bootloader
timeout 15
echo Flashing recovery "recovery.img"
fastboot flash recovery C:\Tools\LineageOSInstaller\LinOS-Files\recovery.img
echo Recovery sucessfully flashed.
exit