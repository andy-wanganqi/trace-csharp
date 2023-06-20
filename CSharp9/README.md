# CSharp 9.0
Released November, 2020

Origin: https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-9

C# 9 was released with .NET 5. It's the default language version for any assembly that targets the .NET 5 release. It contains the following new and enhanced features:

* Records
* Init only setters
* Top-level statements
* Pattern matching enhancements
* Performance and interop
  * Native sized integers
  * Function pointers
  * Suppress emitting localsinit flag
* Fit and finish features
  * Target-typed new expressions
  * static anonymous functions
  * Target-typed conditional expressions
  * Covariant return types
  * Extension GetEnumerator support for foreach loops
  * Lambda discard parameters
  * Attributes on local functions
* Support for code generators
  * Module initializers
  * New features for partial methods

C# 9 continues three of the themes from previous releases: removing ceremony, separating data from algorithms, and providing more patterns in more places.

Top level statements means your main program is simpler to read. There's less need for ceremony: a namespace, a Program class, and static void Main() are all unnecessary.

The introduction of records provides a concise syntax for reference types that follow value semantics for equality. You'll use these types to define data containers that typically define minimal behavior. Init-only setters provide the capability for non-destructive mutation (with expressions) in records. C# 9 also adds covariant return types so that derived records can override virtual methods and return a type derived from the base method's return type.

The pattern matching capabilities have been expanded in several ways. Numeric types now support range patterns. Patterns can be combined using and, or, and not patterns. Parentheses can be added to clarify more complex patterns.

Another set of features supports high-performance computing in C#:

* The nint and nuint types model the native-size integer types on the target CPU.
* Function pointers provide delegate-like functionality while avoiding the allocations necessary to create a delegate object.
* The localsinit instruction can be omitted to save instructions.

Another set of improvements supports scenarios where code generators add functionality:

* Module initializers are methods that the runtime calls when an assembly loads.
* Partial methods support new accessibly modifiers and non-void return types. In those cases, an implementation must be provided.

C# 9 adds many other small features that improve developer productivity, both writing and reading code:

* Target-type new expressions
* static anonymous functions
* Target-type conditional expressions
* Extension GetEnumerator() support for foreach loops
* Lambda expressions can declare discard parameters
* Attributes can be applied to local functions

The C# 9 release continues the work to keep C# a modern, general-purpose programming language. Features continue to support modern workloads and application types.
