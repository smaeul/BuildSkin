Overview
--------
BuildSkin is a utility that allows users to mix and match elements from
different skins via drop-down menus in a GUI. It also automatically adjusts
them (think toolbar) to your screen resolution.

What's New
----------
* In 0.99.9.20c - Fixed bug when refreshing local addons
* In 0.99.9.20b - Fixed bug that prevented updating addons
* In 0.99.9.20a - Added Invisible.tga I forgot to put in earlier
* The addons system has been implemented. See 'Upgrading' below.
* Code has been cleaned up and commented.
* Skin renaming now works.
* Checks have been added to reduce crashing.
* The requested resolution has been added.
* The preview box has been put back.

Future Features
---------------
* Recycle Bin support
* Functional links on the addons tab
* Complete 'preset' skins includable with addons (e.g. everything set to your
skin)
* Possibly resized preview box / better addon descriptions

For Skin Users
==============
Installation
------------
This program requires the .NET framework, version 2.0 or newer. Most computers
will already have it installed, but if yours does not, it is available for free
[here](http://www.microsoft.com/download/en/confirmation.aspx?id=19).
To install this program, extract the "BuildSkin" folder in the zipfile you
downloaded to "My Documents\\The Lord Of The Rings Online\\ui\\skins". The exe
file should end up at "...\\ui\\skins\\BuildSkin\\BuildSkin.exe". If you want a
shortcut, you can right-click it and select "Send To" \> "Desktop (create
shortcut)".

Linux/Mac Users: BuildSkin works under recent versions of Wine with the .NET
framework installed, and it should also work with Mono.

Upgrading
---------
This update does not affect the settings file or how skins are built, but the
new version does need to keep track of things in the "Elements" folder.
Therefore, I recommend, unless you have modified files there, to delete your
current "Elements" folder (inside the BuildSkin folder) and re-download the
addons you want. If you want to start fresh, write down your skin configuration
and delete everything. ;) Since most of them will have been updated for Rohan
anyways, you will still probably need to rebuild your skins.

> Note: Until I have a chance to update all of the existing addons, they will
> not show up in the program. All addons that *do* show up *are*
> compatible.

General Usage
-------------
Some quick help is on the Info/Settings tab. I hope I've made the program easy
to use, but if you have any issues, please comment and ask.

Selecting Your Skin in LOTRO
----------------------------
Go to UI settings in the Options panel. Scroll down to just above the "UI
scale" section. There will be a drop-down box containing "None" or your
previous skin (if you had one). Select the skin you just made. Images will
change immediately. Sizes and layouts will change when you log back in (the
toolbar may require a full game client restart).

Options
-------
Most options are self-explanatory. Some notes, however:
* You will have to check "Skip Recycle Bin" to delete skins in the app - that
feature will come later.
* The XML editor path is the program that opens when you click "Edit XML" on
the Skins tab.
* If your resolution is not in the list, *close the program* and add it
to the long line, separated by a comma and no spaces.

For Skin Authors
================
I have provided a few addons as examples to get you started. However, users are
encouraged to make their own add-ons and, if desired, *please* upload them
to LOTROInterface. Soon you will be able to include a preset configuration
(well, really you could now, by just putting the "Skins/\<name\>/BuildSkin" in
your zip), so you can distribute your skin as a complete product.

XML Layouts
-----------
To make skins adapt for resolutions (or to just be easier to mod), you can set
an attribute to, for example, X="{Travel_Window.Width-10}" or for toolbars
since Rohan, Y="{Screen.Height-ToolbarField.Height}". You can use this method
to set any value based on the screen size or any other defined value, and you
can use any [mathematical expression supported by NCalc]
(http://ncalc.codeplex.com/wikipage?title=functions). Simply
surround the entire formula in curly braces, like above. Probably the most
useful are Screen.Width and Screen.Height

Things to look out for:
* Only variables *you* set are defined (I am not allowed to include
Turbine defaults)
* Divide by zero - undefined variables are set to 0
* Circular dependencies

Art Assets
----------
ArtAsset paths should be someting like "../../Elements/\<Category\>/\<Name\>/\<my
folder\>/\<blablabla\>.tga" or something like that.

Packaging
---------
Refer to the MMUI zip for an example. Although the example paths below include
"Buildskin\\", there should be no BuildSkin folder in the zipfile. *The
Elements folder and anything else go directly in the root of the zip.*

The folder structure extensible - you can add whatever categories and elements
you feel appropriate, and they will automatically appear in the list. It goes
like "BuildSkin\\Elements\\\<Category\>\\\<Name\>\\\<your option\>.xml".
Previews go at "BuildSkin\\Elements\\\<Category\>\\\<Name\>\\\<your option\>.jpg" -
notice the lowercase jpg.

For Tinkerers
=============
Full somewhat-well-commented code is included in the zip. The program is MIT
licensed, so you can do whatever you want with it.

Source code is available at [Github](https://github.com/smaeul/BuildSkin).
