
# LineageOS-Installer

HEADS UP: This project is more-or-less abandoned. It does NOT support A/B partitioned devices. It will still probably work for devices such as Nexus devices as they follow the traditional ROM-flashing format, but no guarentees of success can be made. Use at your own risk.


## Focus List
Idk what to call this section so I'll call it the "Focus List". Essentially these are just ideas that will be implemented soon.
- Channels: The user can pick between a stable channel that will automatically download all files. This will only be available for select devices.
- Samsung Devices: 
Samsung Devices are some of the most popular in the world. Unfortunatly, Samsung has been making an effort to lock down their devices. As such, older models (think S3, S4, S5) will be primarily targeted at first. 
## Source Patch Notes:
Some notable features have been committed, but not added to a release just yet. These features are not considered "big enough" to push as an update on their own.

- Channels UI: The user can now <theoretically> pick between "Stable" and "Advanced" channels. The latter leads into what the application has been so far, but with options to skip file check (perhaps if you modified a script to flash an additional file) and/or go directly to the installation. The stable channel is not ready yet (and is disabled in the UI, but enabling via source won't do anything either) as LOS builds have no stable rollout available. If/when those become a thing, the user will simply select their (supported/tested) device, and all files will be automatically downloaded. We _should_ be able to directly download the LineageOS zip and TWRP img from their respective mirrors, but GApps requires custom hosting as their website doesn't permit this. We also can't redistribute their prebuilt binaries. No problem; behold! [This repository](https://github.com/PJBeans/Compiled-Gapps) hosts GApps compiled by yours truly, and we can directly download from GitHub! I haven't flashed and tested them, but I don't see why they wouldn't work. Currently I only have ARM for API 25, but I intend to get APIs 24-27 uploaded soon.

- Control-colored issues (such as button pre-highlighting) have been fixed

## Version 2.0
On December 22, 2017, development on version 2.0 began.
## What is new
- Proper names for forms
- Forms designed to look like message boxes have been removed. Now, labels and buttons appear in the respective form.
- Use of Ignace Mae's "Material Skin" (as opposed to colored labels and picture boxes)
- > This means window borders, along with buttons and text all follow Material Design! Buttons have animation when you hover and click them, although with the set up of this application, the animation for floating buttons isn't seen. Hopefully this can be fixed, but it isn't a major issue.
- A nicer installation screen with a progress bar
- A new guide for enabling USB Debugging, written in HTML. This guide isn't complete yet.
- The form (yes - form without the "s;" all files are downloaded in one form, with the browsers being shown/hidden at the click of a button) to download files is now bigger, and an "Open in Browser" button was added incase the page proves difficult to use in a confined space or simply won't display correctly.
- The ADB check is now automatic (needs improvement, see below)
- A file check is now performed prior to installation that checks for the LineageOS Zip, GApps Zip, TWRP, and all installation scripts.
## What is to come
- Foreign language support (see below)
- Support for Samsung Devices if possible
## What isn't complete
- ADB Check is not complete; although it can check to see whether the device is connected, it *cannot* determine whether the user allowed the connection to be authorized.
- Foreign language support will come with text that is programatically set at run time or through the `LangSelect` form. It is partially implemented for English but it is not complete; only a few forms (and even those may be incomplete) are set up for this right now. The HTML pages also won't change with this button; for local pages ("Set Up Your Device") we could probably just add each language's "Set Up Your Device" page. 
- Flat buttons are pre-highlighted.
## What is new in the repository
- Removed adb executible for now; it is unclear whether ADB and Fastboot can be redistributed. If they can, they will be included in the application.
- Removed `Land.png`, Next and About button textures as they are all now irrelevant.


A simple, graphical solution to installing LineageOS.

NOTE 1: The repository has been renamed from `Lineage-OS-Installer` to `LineageOS-Installer`. Keep this in mind next time you commit to the repository if something goes wrong.

NOTE 2: The embedded browsers have been replaced by a better solution called Awesomium. Please download it at "http://www.awesomium.com/download." This will allow us to render web pages correctly, as it is based on Chromium.

A prebuilt version (ready to install, the "normal user" version) can be found [here](https://github.com/PJBeans/LineageOS-Installer/releases).[Prebuilt version may not work. If this is the case, please build it from the source.] However, the application is still young, so do not expect it to work perfectly (so back up your data and understand what you will have to do in case you/the application mess up). If you have a Nexus device, this _should_ work like a charm. Also, if you have a device that follows the process of "Unlock the bootloader with `fastboot oem unlock`, flash recovery, flash the rom," the installer will probably work, although it has a chance of failure. But if you're _daring_ enough to try the installer, give it a whirl! Report your results (good or bad) at [this thread](https://forum.xda-developers.com/lineage/general/want-lineage-os-installer-t3529172)

The developers of this application and the LineageOS Community is not responsible for anyone who bricks their devices. This tool is still in development.

TESTED DEVICES:
 - Nexus 7 2013 [WiFi] (flo) by PJBeans on 1.4.0: Worked like a charm
 - Nexus 5X by NateDev on 1.2.0: Worked, although ADB and Fastboot didn't function correctly out-of-the-box.

## Versions
- Prebuilt: v2.0-development
- Source: v2.1-development (Still referred to as v2.0)

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

# FAQ:

[-] Why would I want to use this?

See [this](https://github.com/PJBeans/LineageOS-Installer/wiki/Who-is-this-program-for%3F)

