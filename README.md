# DNNE Sample

Demonstrates exporting C API compatible functions from F#

## Building

You will need to install the MSVC compiler. (Adding the C++ workload to Visual Studio)

```pwsh
dotnet build
```

## View Exports

Locate the path to dumpbin.exe on your system

```pwsh
&"C:\Program Files\Microsoft Visual Studio\2022\Preview\VC\Tools\MSVC\14.41.33923\bin\Hostx64\x64\dumpbin.exe" /exports ".\bin\Debug\net8.0\DNNESampleNE.dll"
```