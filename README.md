# LineageOS-Installer
A simple, graphical solution to installing LineageOS.

NOTE 1: The repository has been renamed from `Lineage-OS-Installer` to `LineageOS-Installer`. Keep this in mind next time you commit to the repository if something goes wrong.

NOTE 2: The embedded browsers have been replaced by a better solution called Awesomium. Please download it at "http://www.awesomium.com/download." This will allow us to render web pages correctly, as it is based on Chromium.

A prebuilt version (ready to install, the "normal user" version) can be found [here](https://github.com/PJBeans/LineageOS-Installer/releases).[Prebuilt version may not work. If this is the case, please build it from the source.] However, the application is still young, so do not expect it to work perfectly (so back up your data and understand what you will have to do in case you/the application mess up). If you have a Nexus device, this _should_ work like a charm. Also, if you have a device that follows the process of "Unlock the bootloader with `fastboot oem unlock`, flash recovery, flash the rom," the installer will probably work, although it has a chance of failure. But if you're _daring_ enough to try the installer, give it a whirl! Report your results (good or bad) at [this thread](https://forum.xda-developers.com/lineage/general/want-lineage-os-installer-t3529172)

The developers of this application and the LineageOS Community is not responsible for anyone who bricks their devices. This tool is still in development.

TESTED DEVICES:
 - Nexus 7 2013 [WiFi] (flo) by PJBeans on 1.4.0: Worked like a charm
 - Nexus 5X by NateDev on 1.2.0: Worked, although ADB and Fastboot didn't function correctly out-of-the-box.

## Versions
Prebuilt: v1.4.1-development
Source: v1.5.0-development

## Screenshots

## How can I contribute?
You can contribute right here on GitHub! If you know Visual Basic, feel free to modify the installer to fix an issue, add something or delete something obsolete. You can also test the installer for your device, and report your results on [this thread](https://forum.xda-developers.com/lineage/general/want-lineage-os-installer-t3529172). 

## What is here:

- Embedded web browsers for downloading TWRP, GApps, and LineageOS
- Images to illustrate where to find Developer Options, USB Debugging, and OEM Unlocking
- The prebuilt program includes a setup script that copies all needed files.

## What is not here:
- Support for Samsung Devices
- Possibly support for other devices (If Fastboot mode acts differently for some reason on other devices; I am not sure)
- A help (support) page

## Goals
To make this application as user-friendly as possible, we should:
- Create a help page
- Make it as fool-proof as we can. The user should feel comfortable with the application, and should not fear to unplug their device.
- If possible, automize the installation to a greater level.
- Let's try to deprecate the embedded browsers. Instead, when a device is supported by the installer, there will be a button for the device that will download Lineage and TWRP, and name it correctly. This should eliminate the possibility of the user misplacing the file when they download it.

# FAQ:

This program is an unofficial almost-automatic install for Lineage OS, designed for beginners or users who just would like to install Lineage OS and be done; for users who don't care how to install a ROM, who just want it on their phone.

[-] What does this program do?

This program on its own does not do much; in fact, all it does it give 2 embedded web browsers to download Lineage OS and TWRP. However, it gives a step-by-step explanation of what do, where to save the files, and what to name them. Lineage OS is actually installed through multiple scripts included in this repository. Those scripts allow the user to install LineageOS without interacting with the TWRP recovery and typing commands.

[-] Why would I want to use this?

See [this](https://github.com/PJBeans/LineageOS-Installer/wiki/Who-is-this-program-for%3F)

