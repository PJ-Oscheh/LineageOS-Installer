@echo off
echo.
echo LineageOS Installation Script version 1.0
echo Script by PJBeans
echo.
dir C:\Tools\LineageOSInstaller\LinOS-Files\
echo Ensure you see the following above:
echo.
echo lineageos.zip
echo recovery.img
echo.
echo If you do not see those files, make sure you saved them to the correct place.
echo Press any key to start installation.
pause
adb reboot bootloader
timeout 15
echo Unlock bootloader? 
echo THIS WILL CLEAR YOUR DEVICE - PRESS ANY KEY 3 TIMES TO CONTINUE
pause
pause
pause
fastboot oem unlock
echo Your device should be unlocked. If it did not reboot, reboot it now.
echo Setup the device as usual. (To save time, you don't need to connect to WiFi or log in to your Google account) 
echo When you finish the setup, reenable Developer Options and USB Debugging. Press any key when you're done.
echo.
pause
adb reboot bootloader
timeout 45
echo Preparing to flash TWRP custom recovery...
fastboot flash recovery C:\Tools\LineageOSInstaller\LinOS-Files\recovery.img
echo After Recovery has flashed, press any key.
pause
echo Now, we will install LineageOS. This next part will take place on your device.
echo On your device, use the volume buttons to cycle through the options.
echo Select 'Restart Bootloader'
pause
echo Select 'Recovery mode'
pause
echo.
echo Tap 'Wipe' then 'Advance Wipe'
echo Select all the options (except MicroSD Card if that it is present)
echo Slide to wipe the device.
echo.
echo After you wipe the device, tap the Home button.
pause
echo Pushing LineageOS to your device, please wait...
adb push C:\Tools\LineageOSInstaller\LinOS-Files\lineageOS.zip /sdcard/
echo On your device, select 'Install'
echo Select 'lineageos.zip'
echo Slide to flash the zip. This will install LineageOS. Press any key when it is done.
pause
echo Select Reboot System.
echo LineageOS should start. It may appear to bootloop (The boot animation going forever without starting the OS), but just be patient!
echo Enjoy your fresh new device ;)
echo.
echo Press any key to exit.
pause