
## Console output
```
C:\Program Files\Mono>mono --version
Mono JIT compiler version 5.8.0 (Visual Studio built mono)
Copyright (C) 2002-2014 Novell, Inc, Xamarin Inc and Contributors. www.mono-project.com
        TLS:           normal
        SIGSEGV:       normal
        Notification:  Thread + polling
        Architecture:  amd64
        Disabled:      none
        Misc:          softdebug
        LLVM:          supported, not enabled.
        GC:            sgen

C:\Program Files\Mono>mono c:\users\anticrisis\source\repos\fsharp-struct-mono-64\fsharp-struct-mono-64\bin\Debug\fsharp_struct_mono_64.exe
[||]
System.IntPtr.Size = 8
vs = [{a = 1;
  b = 2;
  c = 3;}; {a = 4;
            b = 5;
            c = 6;}; {a = 1;
                      b = 2;
                      c = 3;}]

distinct vs = [{a = 1;
  b = 2;
  c = 3;}; {a = 4;
            b = 5;
            c = 6;}; {a = 1;
                      b = 2;
                      c = 3;}]
length of distinct vs = 3
```

Note that the `distinct` list should contain only 2 items, not 3.

I ran into this problem running FSharp code in Unity3D, but was able to reproduce it using a clean Mono 64 bit installation on Windows.
