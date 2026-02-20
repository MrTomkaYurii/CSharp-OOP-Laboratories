# Лабораторна робота №18: Зв'язки між сутностями в Entity Framework Core (.NET 10)

## 🎯 Мета роботи
Глибоке практичне засвоєння моделювання та конфігурації **реляційних зв'язків (Entity Relations)** в **Entity Framework Core 9 (.NET 10)**:
- Моделювання зв'язків один-до-багатьох (1:N) та багато-до-багатьох (N:M) зі складеними первинними ключами (`Composite Primary Keys`);
- Конфігурація множинних зовнішніх ключів до однієї і тієї ж сутності (наприклад, кольори форми `PrimaryKitColor`/`SecondaryKitColor` або команди матчу `HomeTeam`/`AwayTeam`);
- Налаштування поведінки каскадного видалення (`DeleteBehavior.Restrict`) для запобігання циклічним залежностям у SQL Server;
- Початкове наповнення бази даних пов'язаними даними (`Database Seeding`).

---

## 📋 Перелік практичних завдань

| Проект | Назва завдання | Архітектура та опис завдання |
| :---: | :--- | :--- |
| **01** | **Студентська система (Student System)** | Моделювання навчального процесу: <br>• Сутності: `Student`, `Course`, `Resource`, `Homework`.<br>• Проміжна сутність `StudentCourse` зі складеним ключем `(StudentId, CourseId)`.<br>• Перелічення `ContentType` та `ResourceType`.<br>• Fluent API зв'язування домашніх завдань та ресурсів із курсами та студентами. |
| **02** | **Наповнення студентської системи (Student System Seed)** | Консольний додаток, який створює екземпляр `StudentSystemContext` та автоматично генерує демонстраційні курси, студентів, ресурси та записи здачі домашніх завдань. |
| **03** | **Футбольні ставки (Football Betting)** | Складна реляційна модель з 10 сутностей: `Team`, `Color`, `Town`, `Country`, `Player`, `Position`, `PlayerStatistic`, `Game`, `Bet`, `User`. <br>• Складений ключ у `PlayerStatistic` `(GameId, PlayerId)`.<br>• Множинні навігаційні властивості між `Game` та `Team` (домашня/гостьова команди), а також `Team` та `Color` (основний/запасний комплекти форми). |

---

## 🛠️ Як зібрати та запустити

```powershell
# Збірка всього рішення лабораторної
dotnet build "Lab18-EFCore-Entity-Relations/OOP - Lab18.sln" -c Release

# Запуск наповнення студентської системи тестовими даними
dotnet run --project "Lab18-EFCore-Entity-Relations/02. Student System Seed/02. Student System Seed.csproj"
```
