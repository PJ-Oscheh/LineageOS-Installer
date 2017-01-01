# Lineage-OS-Installer
A (currently) unofficial installer for LineageOS written in Visual Basic.

Live Chat: https://telegram.me/joinchat/Dri-vEAnmn5QRFVzUj8dfA

The Installation Script (as explained in the FAQ) can be found at: https://gist.github.com/PJBeans/be9a2c2635660e51cb0a135a33ab1e22
or in the `batch-scripts_prebuilt` directory.

A prebuilt version (ready to install, the "normal user" version) can be found at https://drive.google.com/file/d/0B70zQND1cM1WQVFjYi0yZy1BVnc/view?usp=sharing, although I would not recommend using it this early in this program's life.

This is the source for the UNOFFICIAL Lineage OS Installer for Windows. At the time of creating this program, Lineage OS is not prebuilt and ready for download, so when I tested it, I simply subsituted Lineage OS for CyanogenMod. It was tested on my Nexus 7 2013 WiFi (flo), and worked just fine. I do not know if it will work for non-nexus devices, but I am certain it will not work with Samsung devices, as the installation script does not utilize Download Mode. If enough people like the idea of this installer, I (or perhaps someone in the community) will give support to Samsung devices. If people begin to contribute, we can change the author name in the script and graphical program (this) from "PJBeans" to "LineageOS Community"

PJBeans and the LineageOS Community is not responsible for anyone who bricks their devices. This tool is still in development, and has only been tested on a Nexus 7 2013 WiFi (flo).

# What is here:

- Embedded web browsers for downloading TWRP and LineageOS* [See "What is not here"]*
- Images to illustrate where to find Developer Options, USB Debugging, and OEM Unlocking
- The prebuilt program includes a setup script that copies all needed files.

# What is not here:
- Lineage OS Download page in embedded browser (for it is not live)
- Support for Samsung Devices
- Possibly support for other devices (If Fastboot mode acts differently for some reason on other devices; I am not sure)

# FAQ:

This program is an unofficial almost-automatic install for Lineage OS, designed for beginers or users who just would like to install Lineage OS and be done; for users who don't care how to install a ROM, who just want it on their phone.

[-] What does this program do?

This program on its own does not do much; in fact, all it does it give 2 embedded web browsers to download Lineage OS and TWRP. However, it gives a step-by-step explanition on what do, where to save the files, and what to name them. Lineage OS is acually installed through the script located at the top of this document.

[-] Why would I want to use this?

Well, you probably don't. This installer was made for folks who would like to install Lineage OS on there phone or tablet, but are to scared to, and just would like to have it on their phone or tablet, and be done. *If you want to learn how to install ROMS, already know how to install ROMS, or are a developer, this program is not for you.

[-] What does the Installation Script do?

The Installation script, normally located at `C:\Tools\LineageOSInstaller\scripts\`, is what acually installes LineageOS onto the device. It gives the user instructions of what needs to be done, and automatically unlocks the bootloader, flashes recovery, and pushes LineageOS.zip to the user (not all at the same time, of course). There are other scripts, however, I did not feel the need to upload them; setup.bat simply sets up the C:\Tools\ directory for the program, adb_check is simply `adb_devices`, and starup.bat simply creates the folder LinOS-Files. I am willing to upload any of these files upon request.

# A few things to mention:

I made this program because I know installing a ROM can come across as difficult for someone who never did it before. Now, I only know some Visual Basic, but not all (which is why the program is so simple). I apologize if some files are missing in this Git Repository, I acually never uploaded to GitHub before. So basically, I know how to install ROMS, however, am not a very skilled developer (although I am learning), so I ask that if I did forget something in this repository that you do not yell in all caps at me. Thank you for understanding.
