# This Project is created to use und develop on Windows

#### Note:``` If you're on macOS or Linux, Windows Forms won't work natively. Consider using a cross-platform alternative like Avalonia UI or .NET MAUI.```

to Build the Virtuelle Keyboard Project you need to install the following NuGet Packages:
1 ``dotnet new install Avalonia.Templates``
2 ``dotnet new avalonia.mvvm -n MyCrossPlatformApp
cd MyCrossPlatformApp
``
3. ``dotnet run``

## Packages Needed:
- ``dotnet add package OpenTK
dotnet add package OpenTK.WinForms
dotnet add package geometry3Sharp``
## Missing Dependencies
- ``dotnet add package OpenTK --version 4.7.7``
- ``dotnet add package OpenTK.WinForms --version 4.0.0-pre.6``

# Changing the Proj. to WPF
by Adding the Fowling in .csproj
``<UseWPF>true</UseWPF> ``
``<UseWindowsForms>true</UseWindowsForms> ``# ManufacturingTool
