iis-remove-server-headers
=========================

A .NET module for IIS which removes unwanted HTTP headers from the server response.

## Installation

### Install to the GAC

Deploy the `Pingfu.RemoveServerHeaderModule.dll` library to the .NET Global Assembly Cache (GAC) using the `gacutil.exe` tools. The tool is included with Visual Studio (as part of the Microsoft SDK) and the .Net framework (v1 and 1.1 only!).

You might find the `gacutil.exe` in one, or more of the following locations:

```
%programfiles%\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\gacutil.exe
%programfiles%\Microsoft SDKs\Windows\v6.0\Bin\gacutil.exe
%programfiles%\Microsoft SDKs\Windows\v6.0A\Bin\gacutil.exe
%windir%\Microsoft.NET\Framework\v1.0.3705\gacutil.exe
%windir%\Microsoft.NET\Framework\v1.1.4322\gacutil.exe
```

* gacutil.exe MSDN documentation: http://msdn.microsoft.com/en-us/library/ex0ss12c.aspx

Install the library to the GAC using the `/i` argument:

```
> gacutil.exe /i Pingfu.RemoveServerHeaderModule.dll
```

Once the dll has been installed to the GAC, the downloaded version can be removed from the server.

### Load the module in IIS

1. Open the __Internet Information Services (IIS) Mananger__ snap-in and navigate to the top-level web server home node (usually the first element listed under 'Start Page').
2. Open the Modules administration feature.
3. Select __Add Managed Module...__.
4. In the "Add Mananaged Module" window give the module a `Name`, for example "Pingfu.RemoveServerHeaderModule" and select the module from the `Type` list.

