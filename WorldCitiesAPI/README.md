# 🌍 WorldCitiesAPI

A simple ASP.NET Core Web API that manages cities and their population data.  
This project is part of a mini assignment and demonstrates full CRUD operations with a SQL Server database using Entity Framework Core.

---

## 📦 Features

- ✅ Get all cities, sorted by population
- ✅ Get a specific city by ID
- ✅ Add a new city
- ✅ Update an existing city
- ✅ Delete a city
- 🧪 Built-in Swagger UI for testing endpoints

---

## 🧱 Technologies Used

- ASP.NET Core 8.0
- Entity Framework Core
- SQL Server (Local)
- Swagger / Swashbuckle
- Visual Studio 2022

---

## 🗃️ Database Schema

Table: `Cities`

| Column      | Type     | Description              |
|-------------|----------|--------------------------|
| `CityId`    | `int`    | Primary key (IDENTITY)   |
| `CityName`  | `string` | Name of the city         |
| `Country`   | `string` | Country name             |
| `Population`| `int`    | Number of inhabitants    |

---

## 🚀 Getting Started

1. **Clone the repository:**

   ```bash
   git clone https://github.com/AbdoTaleb/WorldCitiesAPI.git
   cd WorldCitiesAPI

## 🔧 Update the connection string in appsettings.json

```json
"ConnectionStrings": {
  "CityDB": "Server=DESKTOP-4DVTTSS;Database=WorldCities;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"
}
```



## 🗃️ Run the migration and create the database
```bash
Add-Migration InitialCreate
Update-Database```
```
## 🔁 API Endpoints

| Method | Endpoint            | Description              |
|--------|---------------------|--------------------------|
| GET    | `/api/Cities`       | Get all cities           |
| GET    | `/api/Cities/{id}`  | Get city by ID           |
| POST   | `/api/Cities`       | Add a new city           |
| PUT    | `/api/Cities/{id}`  | Update an existing city  |
| DELETE | `/api/Cities/{id}`  | Delete a city            |

## 🖼️ Swagger UI Example

![Swagger Screenshot](assets/images/swagger-screenshot.png)

## 👤 Author

**Abdo Taleb**  
📍 Location: Sweden  
🔗 GitHub: [https://github.com/AbdoTaleb](https://github.com/AbdoTaleb)


