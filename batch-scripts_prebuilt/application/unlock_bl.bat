@echo off
adb reboot bootloader
echo Preparing to unlock Bootloader...
fastboot oem unlock
echo Please accept the prompt on your device. Use the volume buttons to navigate.
echo NOTE: Your device will freeze after selecting "Yes." This is normal. Do not disconnect your device or close this window. It will close automatically.
exit