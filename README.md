# PlateUp Mod Props

![Nuget](https://img.shields.io/nuget/v/ONe.PlateUp.Mod.Props)

This repository contains a Nuget package that aims to make it easier to develop PlateUp! Workshop mods.

## Features

- Automatically references all `Unity*.dll` and `Kitchen*.dll` libraries from the PlateUp installation
- Automatically copies build output to the `Mods` folder (enabled by default)
- Automatically launches the game after each build (disabled by default)

## How to install

1) Create an empty C# project that targets .NetStandard 2.0 or .NET 4.7.2
2) Add the `ONe.PlateUp.Mod.Props` Nuget package
3) Configure the PlateUp directory path

To configure the PlateUp directory path, open your `.csproj` file and add the following section:

```xml
    <PropertyGroup>
        <PlateUpDir>C:\Path\To\PlateUp\Folder</PlateUpDir>
    </PropertyGroup>
```

The `PlateUpDir` path should point to the directory that contains `PlateUp.exe`. By default, the path is set to `C:\Program Files (x86)\Steam\steamapps\common\PlateUp\PlateUp\` so if that is your installation folder, yo do not have to configure anything.

After you finish the setup, you can build the project and it should create a folder for your mode inside the `Mods` folder, copy the mod binaries inside the folder and launch the game.

## Configuration

There are multiple properties that can be configured in your `.csproj` file to alter how the build process works. To configure a property, add it to your `.csproj` file like this: 

```xml
<Project Sdk="Microsoft.NET.Sdk">

    <!--Your project configuration would be here-->
    
    <PropertyGroup>
        <PlateUpDir>C:\Path\To\PlateUp\Folder</PlateUpDir>
    </PropertyGroup>
    
</Project>
```

### `PlateUpDir`

Default value: `C:\Program Files (x86)\Steam\steamapps\common\PlateUp\PlateUp\ `

Directory where the PlateUp game is installed. Is used to determine where the game DLLs are located.

### `ModsDir`

Default value: `Mods`

Name of the folder where all mods are located.

### `ModName`

Default value: `<name of the project>`

Name of the mod. Is used when creating a folder inside the mods directory.

### `ModContentDir`

Default value: `<PlateUpPath>\<ModsDir>\<ModName>\Content`

Path to the `Content` directory of the mod.

### `CopyModFiles`

Default value: `true`

Whether to copy mod binaries to the mods folder after each build.

### `LaunchGameAfterBuild`

Default value: `false`

Whether the game should be launched after each build. Set to `true` to enable.

## How to publish a new Nuget version

Below are instructions how to publish a new version of this Nuget package.

1) Bump the version in `ONe.PlateUp.Mod.Props.nuspec`
2) Run the `build.bat` script from the root folder of the repository
3) The new nuget package is created in the `publish` folder
4) Upload the package at https://www.nuget.org/packages/manage/upload