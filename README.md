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
