@echo off
echo. This window will appear to freeze at times! Do not fret - this is completly normal! Don't disconnect your device!
echo.
echo.
echo Backing up the device...
adb shell twrp backup SDCR123BO 
echo Wiping the device.
adb shell twrp wipe data
adb shell twrp wipe cache
adb shell twrp wipe dalvik
echo.
echo 
echo Sending LineageOS to your device...
adb push C:\Tools\LineageOSInstaller\LinOS-Files\lineageos.zip /sdcard/
echo Sending GApps to your device...
adb push C:\Tools\LineageOSInstaller\LinOS-Files\gapps.zip /sdcard/
adb shell twrp install /sdcard/lineageos.zip
adb shell twrp install /sdcard/gapps.zip
echo Done!
echo Wiping cahce and dalvik...
adb shell twrp wipe cache
adb shell twrp wipe dalvik
echo Done!
adb reboot
exit