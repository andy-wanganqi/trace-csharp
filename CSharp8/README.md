# CSharp 8.0
Released September, 2019

Origin: https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-80

C# 8.0 is the first major C# release that specifically targets .NET Core. Some features rely on new CLR capabilities, others on library types added only in .NET Core. C# 8.0 adds the following features and enhancements to the C# language:

* Readonly members
* Default interface methods
* Pattern matching enhancements:
  * Switch expressions
  * Property patterns
  * Tuple patterns
  * Positional patterns
* Using declarations
* Static local functions
* Disposable ref structs
* Nullable reference types
* Asynchronous streams
* Indices and ranges
* Null-coalescing assignment
* Unmanaged constructed types
* Stackalloc in nested expressions
* Enhancement of interpolated verbatim strings

Default interface members require enhancements in the CLR. Those features were added in the CLR for .NET Core 3.0. Ranges and indexes, and asynchronous streams require new types in the .NET Core 3.0 libraries. Nullable reference types, while implemented in the compiler, is much more useful when libraries are annotated to provide semantic information regarding the null state of arguments and return values. Those annotations are being added in the .NET Core libraries.
