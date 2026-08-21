# Products API

API REST con .NET 8, arquitectura en capas, EF Core, JWT y Swagger.

## Estructura (arquitectura en capas)

```
src/
├── ProductsApi.Domain           Entidades puras (Product, User). Sin dependencias.
├── ProductsApi.Application      DTOs, interfaces y lógica de negocio (Services).
├── ProductsApi.Infrastructure   EF Core, DbContext, Repositorios, JWT, hashing.
└── ProductsApi.API              Controllers, Program.cs, appsettings, Swagger.
```