@echo off
echo Sending Files to your device. This will take a few minutes, and the window may appear to freeze; this is normal. Do not disconnect your device or close this window.
echo.
echo Sending LineageOS to your device...
adb push C:\Tools\LineageOSInstaller\LinOS-Files\lineageos.zip /sdcard/
echo Sending GApps to your device...
adb push C:\Tools\LineageOSInstaller\LinOS-Files\gapps.zip /sdcard/
echo Done!
exit