# RemoteApp Tool
With Microsoft RemoteApp technology, you can seamlessly use an application that is running on another computer.

RemoteApp Tool is a utility that allows you to create/manage RemoteApps hosted on Windows (7, 8, 10, XP and Server) as well as generate RDP and MSI files for clients.

If you want your RemoteApps to appear in the Start Menu of your clients, or via a web interface, check out [RAWeb](https://github.com/kimmknight/raweb)!

If you have questions, comments or suggestions about RemoteApp Tool, please visit the [forum](https://groups.google.com/forum/embed/?place=forum/remoteapptool).

## Features

* Create and manage RemoteApps on Windows desktops and servers
* Generate RDP files
* Generate MSI installers (requires WiX Toolset)
* Use a Remote Desktop Gateway
* Set options such as session timeouts
* Select icons for your apps
* File type associations for deployed apps

## Requirements

* Microsoft .Net Framework 4
* [WiX Toolset](http://wixtoolset.org/) (If you want to create MSIs. Reboot after installing.)
* A **supported** edition of Windows XP, 7, 8, 10, or Server. See the [compatibility chart](https://github.com/kimmknight/remoteapptool/wiki/Windows-Compatibility).

**Note:** If you try to host RemoteApps on an incompatible edition of Windows (eg. Windows 10 Home), the tool will run but RemoteApps ***will not work***. The RDP client will appear to be connecting, then just disappear with no error shown.

## Download

[Latest Installer](http://www.kimknight.net/remoteapptool/RemoteApp%20Tool%205300.msi)

[Latest Portable](http://www.kimknight.net/remoteapptool/remoteapptool5300.zip)

## User guide

[How to create a RemoteApp and use it on another computer](https://github.com/kimmknight/remoteapptool/wiki/Create-a-RemoteApp-and-use-it-on-another-computer)

## Screenshots

![Screenshot 1](https://raw.githubusercontent.com/wiki/kimmknight/remoteapptool/images/screenshots/ss1.png)

![Screenshot 2](https://raw.githubusercontent.com/wiki/kimmknight/remoteapptool/images/screenshots/ss2.png)

![Screenshot 3](https://raw.githubusercontent.com/wiki/kimmknight/remoteapptool/images/screenshots/ss3.png)

![Screenshot 4](https://raw.githubusercontent.com/wiki/kimmknight/remoteapptool/images/screenshots/ss4.png)

## Remarks

The project was made open-source on 29/9/2019.

I started this project in 2011 as an inexperienced developer playing with VB.NET. Over the years I have changed and improved the functionality, but the code remains awful.

I no longer have time to make regular updates, so please take it and improve upon it if you have the time and motivation.

-Kim
