HOW TO USE
----------
Extract everything in this archive to your LOTRO skins directory in your My Documents folder.
It should end up looking something like "My Documents\The Lord of the Rings Online\ui\skins\BuildSkin\..."
Then run BuildSkin.exe (it has a ring icon).

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

MAKING ADDONS
-------------
The general procedure is the same as that for UiBuilder.
1. In the appropriate directory (folder) for the element, place an XML file called "<YourSkinName>.xml"
2. If the skin element is resolution specific, create a directory called "<YourSkinName>res" and put in it an (empty) file named "resenable.xml" and a file named "<YourSkinName> <Resolution>.xml" for each supported resolution.
3. If you have a screenshot of just that element with your skin enabled, place it in the Preview folder and name it "<YourSkinName>.jpg"
4. If your skin requires custom art, place it in a separate folder (preferrably something like "<YourSkinName>art").
5. NOTE: You MUST change the paths of your art mappings. They need to be relative to where the full skin XML will end up, NOT where your element XML file goes. In other words, they should be something like "..\<Element>\<YourSkinArtFolder>\<whatever>.tga"

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
 ->	0.5a	Add Options Window / More Options
	0.5b	Add Automatic Resolution Calculation
	0.6		Add Documentation
 ??	0.6a	Add Internationalization Support (SECOND TEST RELEASE)
 ??	0.6b	Add Language Packs
 ??	0.7		Add Command Line Interface
	0.9		Code/Images/Folders Cleanup
	0.9z	Bugfixes (let it set a while)
	1.0		Real Public Release - Probably final for a while

COPYRIGHT/LICENSE
-----------------
Copyright (c) 2012 Mevordel

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.