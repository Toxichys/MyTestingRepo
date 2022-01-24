
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly MyHomework_Lesson_7_2
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 02 00 00 00 00 00 ) 

  .custom instance void [mscorlib]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 15 4D 79 48 6F 6D 65 77 6F 72 6B 5F 4C 65   // ...MyHomework_Le
                                                                                              73 73 6F 6E 5F 37 5F 32 00 00 )                   // sson_7_2..
  .custom instance void [mscorlib]System.Reflection.AssemblyDescriptionAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 15 4D 79 48 6F 6D 65 77 6F 72 6B 5F 4C 65   // ...MyHomework_Le
                                                                                                73 73 6F 6E 5F 37 5F 32 00 00 )                   // sson_7_2..
  .custom instance void [mscorlib]System.Reflection.AssemblyCopyrightAttribute::.ctor(string) = ( 01 00 12 43 6F 70 79 72 69 67 68 74 20 C2 A9 20   // ...Copyright .. 
                                                                                                  20 32 30 32 32 00 00 )                            //  2022..
  .custom instance void [mscorlib]System.Reflection.AssemblyTrademarkAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.ComVisibleAttribute::.ctor(bool) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.GuidAttribute::.ctor(string) = ( 01 00 24 33 66 65 35 66 37 63 39 2D 31 63 32 36   // ..$3fe5f7c9-1c26
                                                                                                  2D 34 39 64 39 2D 39 30 35 61 2D 66 62 62 36 31   // -49d9-905a-fbb61
                                                                                                  31 31 37 36 36 37 62 00 00 )                      // 117667b..
  .custom instance void [mscorlib]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [mscorlib]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 1C 2E 4E 45 54 46 72 61 6D 65 77 6F 72 6B   // ....NETFramework
                                                                                                        2C 56 65 72 73 69 6F 6E 3D 76 34 2E 37 2E 32 01   // ,Version=v4.7.2.
                                                                                                        00 54 0E 14 46 72 61 6D 65 77 6F 72 6B 44 69 73   // .T..FrameworkDis
                                                                                                        70 6C 61 79 4E 61 6D 65 14 2E 4E 45 54 20 46 72   // playName..NET Fr
                                                                                                        61 6D 65 77 6F 72 6B 20 34 2E 37 2E 32 )          // amework 4.7.2
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module MyHomework_Lesson_7_2.exe
// MVID: {8316AE43-B4DF-415C-AFD9-FA4BBC88B820}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00020003    //  ILONLY 32BITPREFERRED
// Image base: 0x00780000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit MyHomework_Lesson_7_2.Program
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Code size       73 (0x49)
    .maxstack  4
    .locals init ([0] string filename,
             [1] valuetype [mscorlib]System.DateTime dateTime)
    IL_0000:  ldstr      "startupNEW.txt"
    IL_0005:  stloc.0
    IL_0006:  ldstr      bytearray (11 04 43 04 34 04 35 04 42 04 20 00 3F 04 40 04   // ..C.4.5.B. .?.@.
                                    3E 04 38 04 37 04 32 04 35 04 34 04 35 04 3D 04   // >.8.7.2.5.4.5.=.
                                    30 04 20 00 37 04 30 04 3F 04 38 04 41 04 4C 04   // 0. .7.0.?.8.A.L.
                                    20 00 32 04 20 00 44 04 30 04 39 04 3B 04 20 00   //  .2. .D.0.9.;. .
                                    27 00 )                                           // '.
    IL_000b:  ldloc.0
    IL_000c:  ldstr      bytearray (27 00 20 00 34 04 30 04 3D 04 3D 04 4B 04 35 04   // '. .4.0.=.=.K.5.
                                    20 00 42 04 35 04 3A 04 43 04 49 04 35 04 33 04   //  .B.5.:.C.I.5.3.
                                    3E 04 20 00 32 04 40 04 35 04 3C 04 35 04 3D 04   // >. .2.@.5.<.5.=.
                                    38 04 21 00 )                                     // 8.!.
    IL_0011:  call       string [mscorlib]System.String::Concat(string,
                                                                string,
                                                                string)
    IL_0016:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_001b:  call       valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey()
    IL_0020:  pop
    IL_0021:  call       valuetype [mscorlib]System.DateTime [mscorlib]System.DateTime::get_Now()
    IL_0026:  stloc.1
    IL_0027:  ldloc.0
    IL_0028:  ldloca.s   dateTime
    IL_002a:  ldstr      "HH:mm:ss"
    IL_002f:  call       instance string [mscorlib]System.DateTime::ToString(string)
    IL_0034:  ldstr      " "
    IL_0039:  call       string [mscorlib]System.Environment::get_NewLine()
    IL_003e:  call       string [mscorlib]System.String::Concat(string,
                                                                string,
                                                                string)
    IL_0043:  call       void [mscorlib]System.IO.File::AppendAllText(string,
                                                                      string)
    IL_0048:  ret
  } // end of method Program::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } // end of method Program::.ctor

} // end of class MyHomework_Lesson_7_2.Program


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file C:\Users\Toxic\source\repos\MyHomework_Lesson_7\MyHomework_Lesson_7_2\ILdashm_ILasm\MyHomework_Lesson_7_2.res
