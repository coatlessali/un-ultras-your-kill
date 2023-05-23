# You Know what? Fuck you. \*Un ULTRAs Your KILL\*
Deletes your save file and exits upon death.

## Installation

Copy/move `uuyk.dll` to your BepInEx plugins directory.

## Uninstallation

Remove `uuyk.dll` from your BepInEx plugins directory.

## Usage

1. Die.
2. Save files are gone + game crashed.

## Building

Note: I don't use Visual Studio, so I have no clue how to compile this on Windows, though using `msbuild` should be possible. As for MacOS, the file structure is different, but by editing the .csproj file to have correct file names, you should be able to build it with `msbuild`, just like Linux, assuming you have Mono installed.

### Dependencies

* A copy of ULTRAKILL with BepInEx 5.4.21 installed.
* A stripped copy of `Assembly-CSharp.dll` from your copy of ULTRAKILL, located in `ULTRAKILL_Data/Managed/Stripped`.
* (Linux) Mono / `msbuild`.

### Instructions

1. Clone the repo with git. (`git clone https://github.com/coatlessali/un-ultras-your-kill.git`)
2. Enter the directory. (`cd un-ultras-your-kill`)
3. Build project, with `ULTRAKILLPath` set to the path to your copy of ULTRAKILL. (`msbuild un-ultras-your-kill.csproj -p:ULTRAKILLPath=/path/to/your/ULTRAKILL/`)
4. Copy `bin/Debug/uuyk.dll` to your BepInEx folder, if `msbuild` doesn't do it for you.
