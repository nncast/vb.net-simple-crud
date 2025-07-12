# simpleCRUD  
(2024)

**simpleCRUD** is a lightweight desktop application built with VB.NET, demonstrating basic Create, Read, Update, and Delete (CRUD) operations using a MySQL database.  
It is intended as a learning resource or starter template for developers building Windows Forms applications with database integration.

[Preview Video](https://www.youtube.com/watch?v=6MIb-sQymHw)

## Features
- Create, Read, Update, and Delete (CRUD) functionality
- Simple Windows Forms user interface
- MySQL database integration using `MySql.Data.dll`
- Data display using `ListView`

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
1. Download and extract the project `.zip` file.
2. Start MySQL using XAMPP, WAMP, or another server stack.
3. Open your MySQL client and import the `.sql` file located in the `sql` folder.
4. Open `simpleCRUD.sln` in Visual Studio.
5. Ensure the following before running the application:  
   - The project targets .NET Framework 4.8.1 or later.  
   - `MySql.Data.dll` is added and referenced in the project.
6. Build and run the project.

---

**Developer:** Janelle Ann Castillo ([nncast](https://github.com/nncast))
