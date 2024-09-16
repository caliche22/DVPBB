# Backend de Gestión de Productos y Listas de Deseos

## Descripción

Este proyecto es un backend desarrollado en C# que gestiona productos, listas de deseos y categorías. Está diseñado para interactuar con una base de datos SQL Server. 

## Requisitos

- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (debe estar configurado y en funcionamiento)
- [.NET Core SDK](https://dotnet.microsoft.com/download/dotnet) (versión 6 o superior recomendada)

## Configuración de SQL Server

1. **Configurar la cadena de conexión en `appsettings.json`**:

   Abre el archivo `appsettings.json` y ubica la sección `DefaultConnection`. Modifica la cadena de conexión para que apunte a tu instancia de SQL Server. Aquí tienes un ejemplo de cómo debería verse:

   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=localhost;Database=NombreDeBaseDeDatos;User Id=tuUsuario;Password=tuContraseña;"
     }
   }
## actualizacion base de datos con migraciones 
dotnet ef database update

## Intalar entity framework 
dotnet tool install --global dotnet-ef

## compilar 
dotnet build

## ejecutar
dotnet run
 
