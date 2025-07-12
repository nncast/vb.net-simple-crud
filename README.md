# simpleCRUD
(2024)

simpleCRUD is a lightweight, desktop-based application developed in VB.NET that demonstrates the fundamental Create, Read, Update, and Delete (CRUD) operations with a MySQL backend.
Designed primarily as a learning tool or starter template for developers working with Windows Forms and database-driven applications.

[Preview Video](https://www.youtube.com/watch?v=6MIb-sQymHw)

**Features**
- Basic Create, Read, Update, Delete (CRUD) operations
- Clean and simple Windows Forms interface
- MySQL database integration using `MySql.Data.dll`
- Displays data with ListView

**Requirements**
- Visual Studio (2012 or later)
- .NET Framework 4.8.1 or later
      - [Download .NET Framework 4.8.1](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net481)
- XAMPP/WAMP
      - [Download XAMPP](https://www.apachefriends.org/index.html)
      - [Download WAMP](https://www.wampserver.com/en/)     
- SQLYog (or any MySQL client)
- MySQL .NET Connector `MySql.Data.dll`

**Installation Instructions**
1. Download and extract the project `.zip` file.
2. Start MySQL using XAMPP/WAMP, or your preferred server stack.
3. Open SQLYog and import the `.sql` file inside the sql folder to create the database and tables.
4. Open the project by launching simpleCRUD.sln in Visual Studio.
5. Before running the application, ensure the following:    
      - Your system has .NET Framework 4.8.1 or later installed and running on the project
      - The MySQL .NET Connector (MySql.Data.dll) is added and referenced in your project:
7. Build and run the project.

---
Developed by Janelle Ann Castillo (nncast)
