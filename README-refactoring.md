# How to run
For C# project - just open VS Test Explorer and click Run All link.
For JavaScript: to run from Visual Studio - make sure the TireChangeJS is a StartUp Project and run it directly from VS or opend the index.html from any Web browser (tested in Edge, IE, Chrome, FireFox and Opera).

# Tire Change Refactoring C#
## Environment
1. Updated the project to Visual Studio 2017.
2. Updated target .NET Framework version to 4.7
3. Used new C# 7 features for compact code.

## Design
### Data model/OOP
Added new ManufacturerModel data model class to encapsulate the Manufacturer details and improve extensibility. Created the Manufacturer-> Aircraft relationship in the Repository class.
### Busines Domain layer
Added the TireChangeableAircraft class to provide business logic of the tire change decision.
### Dependency Injections ready
Added interfaces for Repository, business logic and service layers for future use of a Dependency Injection framework.

## Performance
Optimized performance using sorted List<> and BinarySearch(). See the TireChangeCS.Domain.IsTireChangeDue() method.
