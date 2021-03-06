# Welcome to .NET

## What is .NET?
- .NET is an open source developer platform created by Microsoft. It's for building many different types of apps, such as web apps, desktop apps, games, api, smart phones apps....
- In short, .NET Platform is a collection of **languages**, **libraries**, and **frameworks** to make various applications, developed under one common standard.
- With .Net platform you can build your app, test app, deploy the app and maintain. This is why .Net caters mostly all phases of SDLC.

## Supported Programming Languages
- Dozens of programming languages are supported by .Net provided they are compatible with the platform, [listed.](https://en.wikipedia.org/wiki/List_of_CLI_languages)
- 3 different languages which are by default supported by .Net are
- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/): Features are: 
    - Object oriented, type safe language and is case sensitive
        - object oriented means, that everything is an object. These objects are further organized with classes
        - Type-safe means that once you declare a type of a variable, you can't really change it. 
    - Component-oriented 
    - Lambda Expression, LINQ (Language Integrated Query), asynchronous operations ...
- Visual Basic : Supports UI and component oriented language.
- F#: F# is a functional programming language supported by .NET
- All .Net compliant languages ahve to follow a Standard. These standard are defined by CLS (Common Language Specification).
  - CLS gives a set of rules and regulation a .Net compliant language should follow. Ex all .Net compliant languages should be OOP languages, Array index should start from 0 etc...

## Technologies we'll be using during this training
- .NET 6 SDK (Runtime, toolkit to devlop apps, .Net CLI) and C#
- SQL (Sql Server)
- ASP.NET Core for creating web applications
- Azure Cloud Service for hosting
- Javascript, Typescript, HTML, CSS, jQuery and Angular for frontend

## [History of .Net](https://docs.microsoft.com/en-us/dotnet/core/porting/versioning-sdk-msbuild-vs)
- Microsoft introduced .Net 1.0 (deprecated) in 2002. It was known as .Net Framework
  
## .NET Implementation
4 main implementation of .NET 
- **.NET Framework**: first implementation of .NET, only works on windows, and it is shipped with every windows.
- **.NET / .NET Core**: .NET Core is the cross-platform implemtation of .NET, and is a successor of .NET Framework. 
    - This is a primary implementation of .NET and is the focus of ongoing development effort. This what we'll be using.
    -.NET 5
- **Mono**
    - .NET runtime that power Xamarin application. 
    - useful when small footprint is needed
    - also powers games built with Unity
- **Universal Windows Platform (UWP)**
    - Used for building modern, touch-enabled Windows applications and software for the Internet of Things (IoT). 
    - It's designed to unify the different types of devices that you may want to target, including PCs, tablets, phones, and even the Xbox.

## Components of .NET Implementation
- One or more runtime: Example, .NET Framework CLR, .NET 5 CLR
    - CLR stands for *Common Language Runtime* and it's a runtime environment provided by .NET
- A class library, for example, .NET Framework Base Class Library, or .NET 5 Base Class Library.
- Optionally, we have one or more application frameworks, such as ASP.NET Core for web application development, Windows Forms, etc.
- Optionally, development tools. Some are shared among multiple implementations.

#### CLR? SDK?
- CLR Stands for Common Language Runtime, and it's runtime environment. It is also know as main execution Engine and is used to run any .Net application.
- SDK stands for Software Development Kit.
- CLR comes included in SDK

## .NET Standard
- .NET Standard is a base set of API's that are common to all .NET implementation.

### Additional Frameworks
These are frameworks that extend .NET platform to provide additional functionalities.
- **ASP.NET Core**: Open source framework for building web apps and web services
    - it's a redesign on ASP.NET 4.x with architectural changes that result in a lener, more modular framework
- **Unity**: Real-time 3D development platform
- **UWP (Universal Windows Platform)**: for developing various windows applications
- **Xamarin**: for mobile development
- **ML.NET**: machine learning
- and more..

### Other Niceties..
- **Nuget**: a package manager for .NET

.NET 5
ASP.NET: ASP.NET Core to match with .NET Core 


# [Basics of C#](https://docs.microsoft.com/en-gb/users/dotnet/collections/yz26f8y64n7k07?WT.mc_id=dotnet-35129-website) 
## Anatomy of C# program
- namespace -> Types -> Type members
- Namespaces are used to organize C#'s many classes and to control scope of class and methods in large programming project
    - Namespace
        - Types
                - Members (Methods, variables, properties)
- Types (Classes, Enums, Structs, Interface, Delegates)
    -   All types in  C# are inherited directly or indirectly **System.Object**
        - **[Value Types](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types)** 
            - which stores the direct value, 
            - stored in memory Stack,
            - Stack is always faster to retrieve data than heap
            - Every value type has a set of memory set aside for it to occupy (Ex: int can only store 32-bits while a double can store 64-bits) and stack memory is all about structure for efficiency and how data cannot be dynamically changing in size
            - Ex Predefined (int, long, short, byte, DateTime, char)
                - Structs - like a class but gets stored in the stack for memory retrieval efficiency
                - Enums - defines a set of named integral constants
        - **[Reference Types](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/reference-types)** 
            - They are datatypes that are stored in the heap and reference variables that are stored in the stack
            - Think of reference variables as having the address of a house since an address only holds the info on where the house is and not the actual house itself
            - When you declare a variable of a reference type and not have it point to anything in the beginning, it will have a null value
                - Null in the coding world means lack of value or there isn't any value at all
            - Reference variables are stored in the stack while the actual object itself is stored in the heap
            - retrieval a value from heap is an expensive process.
            - Why the heap? since memory in the heap can be dynamically changing
            - Ex Predefined -> string, arrays, collections etc, Classes, interface, Delegates.  
## Conversion
- C# is statically typed at compiled time. Meaning after a variable is declared, it cannot be declared again.
- However, it is possible to change the variable type
- **[Type Conversion](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/conversions)** : conversion of 1 type into another 
    - **Implicit type conversion** : 
        - Generally, it is when you can convert the type without any data loss
        - Mostly used with numerical datatypes
        - No special syntax needed to write and compiler will do it for you
        - no need to type cast manually/explicitly. 
        - Ex byte value can be placed in int; converting an int into a double

    - **Explicit type conversion** : 
        - If there is a risk of losing information, you must perform a **Cast**
        - Special syntax is needed to write to tell the compiler to do it anyway
        - Casting is denoted with (datatype)
        - type cast it using `<datatype>.Parse(value)`, `Convert.<datatype>(value)`. You can have a data loss if its not fitting in the type.
        - The `Parse` method returns the converted number; the `TryParse` method returns a boolean value that indicates whether the conversion succeeded, and returns the converted number in an `out` parameter.
- **Boxing**- refers to conversion Value type to reference types.
- **Unboxing**- refers to conversion of reference types to value types.

- **[Expressions](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/)**
  - An expression is a sequence of operators and operands.
    - Ex int c = a + b;
    ```
    [(6/2)+2*3-1]
    - 3 + 2 * 3 - 1
    - 3 + 6 - 1
    - 9 - 1
    - 8
    ```
 
- **[Recursion](https://www.codeproject.com/Articles/142292/Recursive-methods-in-Csharp)** - It is a process of repetitiion own its own. A recursive function is a function that calls itself.
    - A function that calls another function is normal but when a function calls itself then that is a recursive function.

### Additional Resources
- [.NET Documentation](https://docs.microsoft.com/en-us/dotnet/core/introduction)
- [.NET Glossary](https://docs.microsoft.com/en-us/dotnet/standard/glossary)
- [Introducing .NET 5](https://devblogs.microsoft.com/dotnet/introducing-net-5/)
- [What is .NET?](https://www.codecademy.com/articles/what-is-net)
- [.Net CLI](https://docs.microsoft.com/en-us/dotnet/core/tools/)