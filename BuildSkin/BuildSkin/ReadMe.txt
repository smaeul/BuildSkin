HOW TO USE
----------
Extract everything in this archive to your LOTRO skins directory in your My Documents folder.
It should end up looking something like "My Documents\The Lord of the Rings Online\ui\skins\BuildSkin\..."
Then run BuildSkin.exe (it has a ring icon).
The program contains 3 areas: Element options, in the bottom left; Preview, at the top; and Skin options, in the bottom right.
To create a skin, first name it and select your screen resolution on the right side, then select what type of each UI element you want.
Preview images, if available, will be shown at the top of the program.
Then click on the build button, and select your skin in LOTRO.

USAGE NOTES
-----------
+ Skins created with UiBuilder cannot be "Loaded" in BuildSkin. (But you can rebuild them, and then they will work.)
+ Addons created for UiBuilder can be converted to BuildSkin by copying ConvertUiBuilderAddons.cmd to the UiBuilder directory and running it, then copying those folders into the BuildSkin directory. If they have Art assets, paths to those must also be fixed. Simply do a find and replace with the search string of \<Old name>\ and replace it witn \<new name>\

MANAGING OPTIONS
----------------
Options are stored in the BuildSkin.conf file. It is created from defaults the first time you close to program (if it does not already exist).
They are stored in the following manner:
	Path to text editor
	Most recently selected skin
	Available resolutions (separated by comma and NO space)
	Deprecated line that used to contain available toolbar widths
	Confirm on build, load or delete? True/False
	Auto-load last skin on startup? True/False

Text editor path, confirmations, and auto-load can be configured from within the program, through the options window (the button in the bottom right corner).

MAKING ADDONS
-------------
The general procedure is the same as that for UiBuilder.
1. In the appropriate directory (folder) for the element, place an XML file called "<YourSkinName>.xml"
2. See the Expressions section for resolution-specific values.
3. If you have a screenshot of just that element with your skin enabled, place it in the Preview folder and name it "<YourSkinName>.jpg"
4. If your skin requires custom art, place it in a separate folder (preferrably something like "<YourSkinName>art").
5. NOTE: You MUST change the paths of your art mappings. They need to be relative to where the full skin XML will end up, NOT where your element XML file goes. In other words, they should be something like "..\<Element>\<YourSkinArtFolder>\<whatever>.tga"

EXPRESSIONS
-----------
Resolution-specific elements are calculated during skin building for the user's resolution. To use them in your XML, put an expression contained in { and } in the apropriate field, instead of a nubmer.
There are two types of variables. First are Screen.Width and Screen.Height, which are replaced with the appropriate values from the user's resolution.
Also available are variables in the form "ElementID.Attribute" such as ToolbarField.X or DyeColorMenu_Legs.Height
This theoretically works for any element id.
HOWEVER, using it on repeated items such as BaseBox or InnerShadow will most likely cause undesired results.
In other words, you can set the BaseBox to the size of its panel, but not the other way around.
For example toolbar width would be written as Width="{(Screen.Width-1024)/2}" for a 1024 pixel wide toolbar.

CHANGELOG/ROADMAP
-----------------
 v'	0.0.1	UI Mockup
 v'	0.0.1a	Code Cleanup
 v'	0.0.2	Add Object-Oriented Code
 v'	0.0.2a	Implement Directory Parsing
 v'	0.0.2b	Implement Preview Images
 v'	0.0.3	Implement XML File Building
 v'	0.0.3a	Implement XML File Loading
 v'	0.0.3b	Implement Manual Editing
 v'	0.0.3c	Add Resolution Support
 v'	0.0.3z	Code Cleanup (FIRST TEST RELEASE)
 v'	0.0.4	Add More Skin Elements
 v'	0.0.4a	Correctly Implement Error Messages/Handling
 v'	0.0.4b	UI/Code Cleanup/Bugfixes
 v'	0.0.4z	Add Options File
 v'	0.5		Add Options Window / More Options
 ->	0.9		Add Automatic Resolution Calculation
	0.9a	Code/Images/Folders Cleanup
	0.9z	Bugfixes (let it set a while)
	1.0		Real Public Release - Probably final for a while

COPYRIGHT/LICENSE
-----------------
Copyright (c) 2012 Mevordel and Telemachus

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.