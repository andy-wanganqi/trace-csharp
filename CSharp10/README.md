# CSharp 10
Released November, 2021

Origin: https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-10

C# 10 adds the following features and enhancements to the C# language:

* Record structs
* Improvements of structure types
* Interpolated string handlers
* global using directives
* File-scoped namespace declaration
* Extended property patterns
* Improvements on lambda expressions
* Allow const interpolated strings
* Record types can seal ToString()
* Improved definite assignment
* Allow both assignment and declaration in the same deconstruction
* Allow AsyncMethodBuilder attribute on methods
* CallerArgumentExpression attribute
* Enhanced #line pragma

More features were available in preview mode. In order to use these features, you must set <LangVersion> to Preview in your project:

* Generic attributes later in this article.
* static abstract members in interfaces

C# 10 continues work on themes of removing ceremony, separating data from algorithms, and improved performance for the .NET Runtime.

Many of the features mean you'll type less code to express the same concepts. Record structs synthesize many of the same methods that record classes do. Structs and anonymous types support with expressions. Global using directives and file scoped namespace declarations mean you express dependencies and namespace organization more clearly. Lambda improvements makes it easier to declare lambda expressions where they're used. New property patterns and deconstruction improvements create more concise code.

The new interpolated string handlers and AsyncMethodBuilder behavior can improve performance. These language features were applied in the .NET Runtime to achieve performance improvements in .NET 6.

C# 10 also marks more of a shift to the yearly cadence for .NET releases. Because not every feature can be completed in a yearly timeframe, you can try a couple of "preview" features in C# 10. Both generic attributes and static abstract members in interfaces can be used, but these preview features may change before their final release.
