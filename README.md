# AcerBIOSPasswordRemover
Removing BIOS password of legacy Acer Laptop like Acer Aspire 4810

## How it works

According to the Acer eSettings Management Software 2.5 released in 2009, it use INT15.dll(or INT15_64.dll in 64-bit Windows) to modify BIOS configuration. The remover just call these functions directly.

Tested on Windows 7 with SP1 x64, Aspire 4810TZG

## Build

`csc.exe /target:exe Remover.cs`

