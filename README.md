iis-remove-server-headers
=========================

A .NET module for IIS which removes unwanted HTTP headers from the server response.

## Installation

### Install to the GAC

Deploy the library to the .NET Global Assembly Cache (GAC) using `gacutil.exe`.

```
> gacutil.exe /i Pingfu.RemoveServerHeaderModule.dll
```

Once the library is installed to the GAC, any other copies can be removed from the server.

* MSDN documentation: http://msdn.microsoft.com/en-us/library/ex0ss12c.aspx
* gacutil.exe is included with Visual Studio and v1.1 of the .net framework, usually in one of the following locations:
  * `%programfiles%\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\gacutil.exe`
  * %programfiles%\Microsoft SDKs\Windows\v6.0\Bin\gacutil.exe
  * %programfiles%\Microsoft SDKs\Windows\v6.0A\Bin\gacutil.exe
  * %windir%\Microsoft.NET\Framework\v1.0.3705\gacutil.exe
  * %windir%\Microsoft.NET\Framework\v1.1.4322\gacutil.exe

### Load the module in IIS

1. Open the __Internet Information Services (IIS) Mananger__ snap-in.
2. Open the __Modules__ administration feature at the server level.
3. Select __Add Managed Module...__.
  * For `Name` enter a descriptive name, for example "Pingfu.RemoveServerHeaderModule"
  * For `Type` select the module from the list.

