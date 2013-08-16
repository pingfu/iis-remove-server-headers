IIS Remove Server Headers
=========================

A .NET module for IIS which removes the following unwanted HTTP headers from the server response.

* `Server:`
* `X-Powered-By`
* `X-AspNet-Version`

## Download

Either compile from source, or the following pre-compiled binaries are available for use with IIS where version 2.0 of the .net framework is installed;

* [Pingfu.RemoveServerHeaderModule-1.0.0-x86.msi.zip](https://s3-eu-west-1.amazonaws.com/pingfu/remove-server-header-module/Pingfu.RemoveServerHeaderModule-1.0.0-x86.msi.zip) (144 KB)

  MD5: `a037c6b4b2a2d90c7043edcf0120b26d`
  
* [Pingfu.RemoveServerHeaderModule-1.0.0-x64.msi.zip](https://s3-eu-west-1.amazonaws.com/pingfu/remove-server-header-module/Pingfu.RemoveServerHeaderModule-1.0.0-x64.msi.zip) (144 KB)

  MD5: `8b839cf4c91f2e7d2543f0e374417cf7`

## Installation to the GAC

Deploy the library to the .NET Global Assembly Cache (GAC) using `gacutil.exe`.

```
> gacutil.exe /i Pingfu.RemoveServerHeaderModule.dll
```

Once the library is installed to the GAC, any other copies can be removed from the server.

* MSDN documentation: http://msdn.microsoft.com/en-us/library/ex0ss12c.aspx
* gacutil.exe is included with Visual Studio and v1.1 of the .net framework, usually in one of the following locations:
  * %programfiles%\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\gacutil.exe
  * %programfiles%\Microsoft SDKs\Windows\v6.0\Bin\gacutil.exe
  * %programfiles%\Microsoft SDKs\Windows\v6.0A\Bin\gacutil.exe
  * %windir%\Microsoft.NET\Framework\v1.0.3705\gacutil.exe
  * %windir%\Microsoft.NET\Framework\v1.1.4322\gacutil.exe

## Configure IIS to use the module

1. Open the __Internet Information Services (IIS) Mananger__ snap-in.
2. Open the __Modules__ administration feature at the server level.
3. Select __Add Managed Module...__.
  * For `Name` enter a descriptive name, for example "Pingfu.RemoveServerHeaderModule"
  * For `Type` select the module from the list.

