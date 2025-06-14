# Le Cantine

This repository contains a WinForms application targeting **.NET 8**. The project uses a MySQL database and requires the `MySql.Data` library.

## Building and Running

The application uses the `Microsoft.NET.Sdk.WindowsDesktop` SDK which is only supported on Windows. To compile and run the program you need a Windows environment with the [.NET 8 SDK](https://dotnet.microsoft.com/download) installed.

1. Install the **.NET 8 SDK** on your Windows machine.
2. Clone this repository and open the `le_cantine.csproj` file in Visual Studio or run `dotnet build` from the command line.
3. Import the SQL schema from `le_cantine.sql` into your MySQL server.
4. Update the connection string in `BDD.cs` if your database settings differ.
5. Run the project from Visual Studio or execute `dotnet run` from a developer command prompt.

## Limitations on Linux

The project cannot be built on Linux because the `Microsoft.NET.Sdk.WindowsDesktop` SDK is not available. Attempting to run `dotnet build` on Linux will result in the following error:

```
/usr/lib/dotnet/sdk/8.0.117/Sdks/Microsoft.NET.Sdk/targets/Microsoft.NET.Sdk.targets(1355,3): error MSB4019: The imported project "/usr/lib/dotnet/sdk/8.0.117/Sdks/Microsoft.NET.Sdk.WindowsDesktop/targets/Microsoft.NET.Sdk.WindowsDesktop.targets" was not found.
```

To work with the application, use a Windows environment.
