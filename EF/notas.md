# Entity Framework 
Instalar los paquetes: entity framework core, sqlserver y tools

--- 
### 1. para mapear tu bd con ef (database-first)
- **Consoloa de admin de paquetes:**
```bash
- Scaffold-DbContext "Server=.\LOCAL; Database=Test; User=usuario; Password=123456;" Microsoft.EntityFrameworkCore.SqlServer

- Scaffold-DbContext Name=TuConexion Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models 

- Scaffold-DbContext Name=TuConexion Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Force
```
  
- **CLI**
```bash
dotnet ef dbcontext scaffold Name=MyConnection Microsoft.EntityFrameworkCore.SqlServer --output-dir Models --force
```

### 2. para relizar updates (code-first)

- **Consoloa de admin de paquetes:**

```bash
Add-Migration NombreDeLaMigracion
Update-Database
```

- **CLI**
```bash
dotnet ef migrations remove
dotnet ef migrations add NuevaMigracion
dotnet ef database update
dotnet ef migrations list
```
