# CSharp 7.1
Released August, 2017

Origin: https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-71

C# started releasing point releases with C# 7.1. This version added the language version selection configuration element, three new language features, and new compiler behavior.

The new language features in this release are:

* async Main method
  > The entry point for an application can have the async modifier.
* default literal expressions
  > You can use default literal expressions in default value expressions when the target type can be inferred.
* Inferred tuple element names
  > The names of tuple elements can be inferred from tuple initialization in many cases.
* Pattern matching on generic type parameters
  > You can use pattern match expressions on variables whose type is a generic type parameter.

Finally, the compiler has two options -refout and -refonly that control reference assembly generation

> [ProduceReferenceAssembly](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-options/output#producereferenceassembly)
```
<ProduceReferenceAssembly>true</ProduceReferenceAssembly>
```

> [ProduceOnlyReferenceAssembly](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-options/code-generation#produceonlyreferenceassembly)
```
<ProduceOnlyReferenceAssembly>true</ProduceOnlyReferenceAssembly>
```