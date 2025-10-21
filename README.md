 StudentManagementSystem-4TierArchitecture

A clean and modular ASP.NET Core MVC project demonstrating **4-Tier Architecture**:
1. **Presentation Layer** – ASP.NET MVC (UI, Controllers)
2. **Business Logic Layer (BLL)** – Handles all business rules
3. **Data Access Layer (DAL)** – Entity Framework Core, Repository pattern
4. **Entities Layer** – Plain model classes

---

Technologies Used
- ASP.NET Core MVC (.NET 6)
- Entity Framework Core
- SQL Server
- Dependency Injection

---

 🗂️ Project Structure
StudentManagementSystem.sln
│
├── StudentManagementSystem.Web → UI (Controllers + Views)
├── StudentManagementSystem.Business → Business Logic (Services)
├── StudentManagementSystem.DataAccess → EF Core + Repositories
└── StudentManagementSystem.Entities → Models/Entities


---

 How to Run
1. Clone the repository  
2. Configure the connection string in `appsettings.json`  
3. Run migrations:  
Add-Migration InitialCreate
Update-Database
4. Start the project (`Ctrl + F5`)
