# simpleCRUD
(2024)

**simpleCRUD** is a lightweight desktop application built with VB.NET, demonstrating basic Create, Read, Update, and Delete (CRUD) operations using a MySQL database. It manages basic school records — **Classrooms, Courses, Departments, Instructors and Schedules** — each in its own form.
It is intended as a learning resource or starter template for developers building Windows Forms applications with database integration.

[Preview Video](https://www.youtube.com/watch?v=6MIb-sQymHw)

## Features

| Module | Fields | Notes |
| --- | --- | --- |
| **Classrooms** | Building name, room number, capacity, equipment | Building picked from Building A–E |
| **Courses** | Course name, credits, course type | Credits via number spinner; type is Core / Elective |
| **Departments** | Department name, department head, phone number, office location | Office picked from Building A–D |
| **Instructors** | First name, last name, email | |
| **Schedules** | Day of week, time slot | Monday–Friday; time chosen with a time picker |

Every form works the same way:

- **New** → fill in the fields → **Save** to add a record (all fields are required)
- **Double-click** a row in the list to load it, then **Update** → **Save**, or **Delete**
- **Cancel** discards the current add/edit
- Every action asks for confirmation first
- Records are displayed in a `ListView`

## Tech Stack

- **Language:** Visual Basic .NET
- **UI:** Windows Forms
- **Framework:** .NET Framework 4.8.1
- **Database:** MySQL / MariaDB
- **Driver:** MySql.Data (MySQL Connector/NET)

## Project Structure

```
vb.net-simple-crud/
├── README.md
├── sql/
│   └── dbstudent.sql               # Database schema + sample data
└── simpleCRUD/
    ├── simpleCRUD.sln              # Visual Studio solution
    └── simpleCRUD/
        ├── Conn.vb                 # Shared DB module: Connect, GetQuery (SELECT), SetQuery (INSERT/UPDATE/DELETE)
        ├── Classrooms.vb           # Classrooms CRUD form
        ├── Courses.vb              # Courses CRUD form
        ├── Departments.vb          # Departments CRUD form
        ├── Instructors.vb          # Instructors CRUD form
        ├── Schedules.vb            # Schedules CRUD form (startup form)
        ├── *.Designer.vb / *.resx  # Form layouts
        ├── Resources/              # Images
        ├── My Project/             # App settings, startup form, assembly info
        └── App.config
```

## Database

Database name: `dbstudent` — five independent tables:

| Table | Columns |
| --- | --- |
| `classrooms` | `classid` (PK), `bldgname`, `roomnum`, `capacity`, `equipment` |
| `courses` | `courseid` (PK), `coursename`, `credits`, `coursetype` |
| `departments` | `deptid` (PK), `deptname`, `depthead`, `phonenum`, `officelocation` |
| `instructors` | `instrid` (PK), `fname`, `lname`, `email` |
| `schedules` | `schedid` (PK), `dayofweek`, `timeslot` |

All primary keys are `AUTO_INCREMENT`.

## Requirements
- Visual Studio 2012 or later
  [Download Visual Studio](https://visualstudio.microsoft.com/downloads/)
- .NET Framework 4.8.1 or later
  [Download .NET Framework 4.8.1](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net481)
- XAMPP or WAMP (for MySQL)
  [Download XAMPP](https://www.apachefriends.org/index.html)
  [Download WAMP](https://www.wampserver.com/en/)
- SQLYog or any MySQL client
  [Download SQLYog](https://github.com/webyog/sqlyog-community/wiki/Downloads)
- MySQL .NET Connector (`MySql.Data.dll`)
  [Download Connector/NET](https://dev.mysql.com/downloads/connector/net/)

## Installation
1. Clone the repository, or download and extract the project `.zip` file.
   ```bash
   git clone https://github.com/nncast/vb.net-simple-crud.git
   ```
2. Start MySQL using XAMPP, WAMP, or another server stack.
3. Open your MySQL client and import `sql/dbstudent.sql`, or use the CLI:
   ```bash
   mysql -u root -p < sql/dbstudent.sql
   ```
4. Open `simpleCRUD/simpleCRUD.sln` in Visual Studio.
5. Ensure the following before running the application:
   - The project targets .NET Framework 4.8.1 or later.
   - `MySql.Data.dll` is added and referenced in the project. If it shows a warning icon under *References*, remove it and add it again from wherever Connector/NET is installed on your machine.
6. Check the connection settings. Each form connects with:
   ```vb
   Connect("localhost", "dbstudent", "3306", "root", "")
   ```
   Change the server, port, username or password in each form's `_Load` event if yours are different.
7. Build and run the project.

### Opening a different module

The app opens the **Schedules** form by default, and there is no main menu linking the forms. To open another module, go to **Project → simpleCRUD Properties → Application → Startup form** and pick `Classrooms`, `Courses`, `Departments`, or `Instructors`.

## Troubleshooting

**`Incorrect integer value: '' for column ...` when saving a new record**

The Add forms send an empty ID and rely on MySQL filling in the next auto-increment number, which strict mode blocks. Turn strict mode off:

```sql
SET GLOBAL sql_mode = 'NO_ENGINE_SUBSTITUTION';
```

To keep the setting after a restart, add `sql_mode = NO_ENGINE_SUBSTITUTION` under `[mysqld]` in your `my.ini` (in XAMPP: *Config → my.ini* on the MySQL row).

**`Unable to connect to any of the specified MySQL hosts`**

Make sure MySQL is running (e.g. started from the XAMPP Control Panel) and that the connection settings match your server.

---

**Developer:** Janelle Ann Castillo ([nncast](https://github.com/nncast))

![VB.NET](https://img.shields.io/badge/VB.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![.NET Framework](https://img.shields.io/badge/.NET_Framework_4.8.1-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows_Forms-0078D4?style=for-the-badge&logo=windows&logoColor=white)
![MySQL](https://img.shields.io/badge/MySQL-4479A1?style=for-the-badge&logo=mysql&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visualstudio&logoColor=white)
