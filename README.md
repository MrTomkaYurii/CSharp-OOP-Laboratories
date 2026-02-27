# C# & OOP Laboratories: Практикум у .NET 10

[![.NET 10](https://img.shields.io/badge/.NET-10.0-512bd4.svg?style=flat-square&logo=dotnet)](https://dotnet.microsoft.com/)
[![C# 13/14](https://img.shields.io/badge/C%23-13%20%2F%2014-239120.svg?style=flat-square&logo=csharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)

Єдиний консолідований репозиторій для виконання лабораторних робіт та практичних занять з курсу **«Об'єктно-орієнтоване програмування у C# .NET 10»**.

Усі лабораторні роботи консолідовано в одному монорепозиторії, вичищено від зайвих внутрішніх Git-артефактів, модернізовано до сучасної цільової платформи **.NET 10**, перевірено на успішність компіляції (`0 errors`) та забезпечено вичерпними україномовними методичними посібниками у форматі Markdown.

---

## 📋 Зміст лабораторного практикуму

| Лабораторна | Тема | Архітектура та ключові завдання | Статус |
|:---|:---|:---|:---:|
| **[Lab01-Introduction](Lab01-Introduction/)** | Вступ до синтаксису C# | Прямокутники, форматування, маніпуляції з рядками та консольний I/O | ✅ Завершено (0 err) |
| **[Lab02-Arrays](Lab02-Arrays/)** | Масиви та алгоритми | Ротація масивів, згортання, індексація, пошук послідовностей та частот | ✅ Завершено (0 err) |
| **[Lab03-Defining-Classes](Lab03-Defining-Classes/)** | Оголошення класів та конструктори | Інкапсуляція даних, конструктори, розрахунок різниці дат, родини | ✅ Завершено (0 err) |
| **[Lab04-Working-With-Abstraction](Lab04-Working-With-Abstraction/)** | Робота з абстракцією | Моделювання предметних областей: Point in Rectangle, Greedy Times, Hospital, Hotel | ✅ Завершено (0 err) |
| **[Lab05-Encapsulation](Lab05-Encapsulation/)** | Інкапсуляція та валідація даних | Валідація інваріантів: Box Data, Animal Farm, Shopping Spree, Pizza Calories, Football Team | ✅ Завершено (0 err) |
| **[Lab06-Inheritance](Lab06-Inheritance/)** | Успадкування та перевизначення | Ієрархії класів: Person, Book Shop, Mankind, Online Radio Database, Mordor Plan, Animals | ✅ Завершено (0 err) |
| **[Lab07-Interfaces-And-Abstraction](Lab07-Interfaces-And-Abstraction/)** | Інтерфейси та абстракція | Контракти: IPerson, Multiple Implementation, Ferrari, Telephony, Military Elite, Collection Hierarchy | ✅ Завершено (0 err) |
| **[Lab08-Polymorphism](Lab08-Polymorphism/)** | Поліморфізм та фабрики | Динамічний поліморфізм: Vehicles, Vehicles Extension, Wild Farm | ✅ Завершено (0 err) |
| **[Lab09-Generics](Lab09-Generics/)** | Узагальнення (Generics) | Generic Box, Swap, CountGreaterThan, CustomList, Tuple, Threeuple | ✅ Завершено (0 err) |
| **[Lab10-Iterators-And-Comparators](Lab10-Iterators-And-Comparators/)** | Ітератори та компаратори | `yield return`, `IComparable`, `IComparer`, Froggy, Strategy Pattern, Equality Logic, Pet Clinics | ✅ Завершено (0 err) |
| **[Lab11-Reflection-And-Attributes](Lab11-Reflection-And-Attributes/)** | Рефлексія та кастомні атрибути | Метапрограмування: Harvesting Fields, Black Box Integer, BarracksWars (IoC/DI), Inferno Infinity | ✅ Завершено (0 err) |
| **[Lab12-Communication-And-Events](Lab12-Communication-And-Events/)** | Комунікація та події | Патерн Спостерігач: `event EventHandler`, King's Gambit, Dependency Inversion, Work Force | ✅ Завершено (0 err) |
| **[Lab13-LINQ-Basics](Lab13-LINQ-Basics/)** | Основи LINQ | Запити LINQ до колекцій студентів, фільтрація, групування, об'єднання та експорт в Excel | ✅ Завершено (0 err) |
| **[Lab14-Functional-Programming](Lab14-Functional-Programming/)** | Функціональне програмування | Делегати `Action`, `Func`, `Predicate`, композиція предикатів, TriFunction, Party Filters | ✅ Завершено (0 err) |
| **[Lab15-Streams-Files-And-Directories](Lab15-Streams-Files-And-Directories/)** | Потоки, файли та каталоги | `StreamReader`/`StreamWriter`, поблочне копіювання бінарних файлів, обхід файлової системи, ZIP | ✅ Завершено (0 err) |
| **[Lab17-EFCore-Code-First](Lab17-EFCore-Code-First/)** | EF Core: Code First | Моделювання баз даних: Hospital Database, Sales Database, міграції та генератори даних | ✅ Завершено (0 err) |
| **[Lab18-EFCore-Entity-Relations](Lab18-EFCore-Entity-Relations/)** | EF Core: Зв'язки між сутностями | Реляційні зв'язки 1:N та N:M: Student System, Football Betting (10 сутностей, складені ключі) | ✅ Завершено (0 err) |
| **[Lab19-EFCore-Advanced-Relations](Lab19-EFCore-Advanced-Relations/)** | EF Core: Розширені зв'язки | `IEntityTypeConfiguration`, поліморфні платіжні методи, унікальні складені індекси, PayBills | ✅ Завершено (0 err) |
| **[Lab20-EFCore-Advanced-Querying](Lab20-EFCore-Advanced-Querying/)** | EF Core: Поглиблені запити | BookShop (19 проектів): складні проекції, фільтри за віком/ціною/автором, масові операції | ✅ Завершено (0 err) |

---

## 🛠️ Як зібрати та запустити будь-яку лабораторну

```powershell
# Приклад збірки конкретного рішення
dotnet build "Lab07-Interfaces-And-Abstraction/OOP - Lab07.sln" -c Release

# Приклад запуску проекту з конкретної лабораторної
dotnet run --project "Lab08-Polymorphism/03. Wild Farm/03.WildFarm.csproj"
```

---

## 🌿 Гілки лабораторних робіт

Кожна лабораторна робота була розроблена в ізольованій атомарній гілці перед злиттям у `main`:
- `lab/01-introduction`
- `lab/02-arrays`
- `lab/03-defining-classes`
- `lab/04-working-with-abstraction`
- `lab/05-encapsulation`
- `lab/06-inheritance`
- `lab/07-interfaces-and-abstraction`
- `lab/08-polymorphism`
- `lab/09-generics`
- `lab/10-iterators-and-comparators`
- `lab/11-reflection-and-attributes`
- `lab/12-communication-and-events`
- `lab/13-linq-basics`
- `lab/14-functional-programming`
- `lab/15-streams-files-and-directories`
- `lab/17-efcore-code-first`
- `lab/18-efcore-entity-relations`
- `lab/19-efcore-advanced-relations`
- `lab/20-efcore-advanced-querying`
