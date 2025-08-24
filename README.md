
# 📱 StudentCellPhone

**StudentCellPhone** is an ASP.NET Core MVC application built with C# that manages a list of student cell phones. It provides full CRUD (Create, Read, Update, Delete) functionality using SQLite as the database and Microsoft Entity Framework Core as the ORM (Object-Relational Mapper).

---

## 🛠️ Technologies Used

- **ASP.NET Core MVC**
- **C#**
- **Entity Framework Core**
- **SQLite**
- **Razor Pages**
- **Bootstrap (for basic UI styling)**

---

## 📋 Features

- ✅ Add new students with their cell phone numbers  
- 📄 View a list of all students  
- ✏️ Edit student information  
- 🗑️ Delete students from the list  
- 🔎 Search and sort student entries (optional enhancement)

---

## 📁 Project Structure
StudentCellPhone/
│
├── Controllers/
│ └── StudentsController.cs
│
├── Models/
│ └── Student.cs
│
├── Data/
│ └── AppDbContext.cs
│
├── Views/
│ └── Students/
│ ├── Index.cshtml
│ ├── Create.cshtml
│ ├── Edit.cshtml
│ ├── Delete.cshtml
│ └── Details.cshtml
│
├── wwwroot/
│ └── (Static files like CSS/JS)
│
├── appsettings.json
├── Program.cs
├── Startup.cs (if using .NET Core 3.1 or lower)
└── StudentCellPhone.csproj
