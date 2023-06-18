# CSharp 7.3
Released May, 2018

Origin: https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-73

There are two main themes to the C# 7.3 release. One theme provides features that enable safe code to be as performant as unsafe code. The second theme provides incremental improvements to existing features. New compiler options were also added in this release.

The following new features support the theme of better performance for safe code:

* You can access fixed fields without pinning.
* You can reassign ref local variables.
* You can use initializers on stackalloc arrays.
* You can use fixed statements with any type that supports a pattern.
* You can use more generic constraints.

The following enhancements were made to existing features:

* You can test == and != with tuple types.
* You can use expression variables in more locations.
* You may attach attributes to the backing field of auto-implemented properties.
* Method resolution when arguments differ by in has been improved.
* Overload resolution now has fewer ambiguous cases.

The new compiler options are:

* [-publicsign](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-options/security#publicsign) to enable Open Source Software (OSS) signing of assemblies.
  > This option causes the compiler to apply a public key but doesn't actually sign the assembly. The PublicSign option also sets a bit in the assembly that tells the runtime that the file is signed.
  ```xml
  <PublicSign>true</PublicSign>
  ```
* [-pathmap](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-options/advanced#pathmap) to provide a mapping for source directories.
  > The PathMap compiler option specifies how to map physical paths to source path names output by the compiler. This option maps each physical path on the machine where the compiler runs to a corresponding path that should be written in the output files. In the following example, path1 is the full path to the source files in the current environment, and sourcePath1 is the source path substituted for path1 in any output files. To specify multiple mapped source paths, separate each with a comma.
  ```xml
  <PathMap>path1=sourcePath1,path2=sourcePath2</PathMap>
  ```