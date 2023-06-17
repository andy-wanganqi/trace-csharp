# CSharp 7.2
Released Movember, 2017

Origin: https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-72

C# 7.2 added several small language features:

* Initializers on stackalloc arrays.
* Use fixed statements with any type that supports a pattern.
* Access fixed fields without pinning.
* Reassign ref local variables.
* Declare readonly struct types, to indicate that a struct is immutable and should be passed as an in parameter to its member methods.
* Add the in modifier on parameters, to specify that an argument is passed by reference but not modified by the called method.
* Use the ref readonly modifier on method returns, to indicate that a method returns its value by reference but doesn't allow writes to that object.
* Declare ref struct types, to indicate that a struct type accesses managed memory directly and must always be stack allocated.
* Use additional generic constraints. [Origin](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters)
  * where T: struct
  * where T: class
  * where T: class?
  * where T: notnull
  * where T: default
  * where T: unmanaged
  * where T: new()
  * where T: \<base class name>
  * where T: \<base class name>?
  * where T: \<interface name>?
  * where T: U
* Non-trailing named arguments
  * Named arguments can be followed by positional arguments.
* Leading underscores in numeric literals
  * Numeric literals can now have leading underscores before any printed digits.
* private protected access modifier
  * The private protected access modifier enables access for derived classes in the same assembly.
* Conditional ref expressions
  * The result of a conditional expression (?:) can now be a reference.