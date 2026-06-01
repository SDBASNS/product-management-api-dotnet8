# product-management-api-dotnet8
# Product Management API - CRN Technical Assessment

## Overview

This project is a RESTful Backend API built using ASP.NET Core Web API with Clean Architecture principles.

The solution provides CRUD operations for Products and demonstrates enterprise-level backend development practices including JWT Authentication, Entity Framework Core, Swagger documentation, Docker support, and layered architecture.

---

# Tech Stack

- .NET 8 / ASP.NET Core Web API
- C#
- Entity Framework Core
- SQL Server
- JWT Authentication
- Swagger / OpenAPI
- Docker & Docker Compose
- FluentValidation
- xUnit & Moq
- Clean Architecture

---

# Project Structure

```txt
src/
│
├── API
├── Application
├── Domain
└── Infrastructure

tests/
```

---

# Features Implemented

- CRUD APIs for Products
- JWT Authentication
- Swagger API Documentation
- SQL Server Integration
- Entity Framework Core Migrations
- Clean Architecture Pattern
- DTOs & Service Layer
- Docker Support
- API Versioning
- Dependency Injection

---

# API Endpoints

## Products

| Method | Endpoint |
|---|---|
| GET | /api/v1/products |
| GET | /api/v1/products/{id} |
| POST | /api/v1/products |
| PUT | /api/v1/products/{id} |
| DELETE | /api/v1/products/{id} |

---

## Authentication

| Method | Endpoint |
|---|---|
| POST | /api/auth/login |

---

# Database Setup

Update connection string inside:

```txt
src/API/appsettings.json
```

Example:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=.\\SQLEXPRESS;Database=ProductManagementDb;Trusted_Connection=True;TrustServerCertificate=True"
}
```

---

# Running the Project

## Clone Repository

```bash
git clone <repository-url>
```

---

## Run API

```bash
dotnet run --project src/API
```

---

## Apply Migrations

```bash
dotnet ef database update --project src/Infrastructure --startup-project src/API
```

---

# Swagger URL

```txt
http://localhost:5072/swagger
```

---

# Docker Support

## Build Docker Container

```bash
docker-compose up --build
```

---

# Authentication

JWT Authentication has been implemented for protected endpoints.

Protected endpoints:

- POST Product
- PUT Product
- DELETE Product

---

# Author

CRN Technical Assessment Submissions
