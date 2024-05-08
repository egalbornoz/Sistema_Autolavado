# PROCEDIMIENTO PARA CREAR Y CONFIGURAR UN PROYECTO WEB API EN ASP.NET

1.-  En la linea de comando escribir

    * dotnet new webapi --name NOMBE_PROYECTO

2.-  Ingresar al directorio y agregar paquetes 

    * dotnet add package AutoMapper
    * dotnet add package Microsoft.EntityFrameworkCore   
    * dotnet add package Microsoft.EntityFrameworkCore.Design
    * dotnet add package Microsoft.EntityFrameworkCore.SqlServer
    * dotnet add package Newtonsoft.Json
    * dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
    * dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer
    * dotnet add package System.IdentityModel.Tokens.Jwt

3.- En Program.cs

   Agregar

builder.Services.AddMvc();
 




     app.UseAuthentication();
     app.UseAuthorization();

  Comentar.
 // app.UseHttpsRedirection();

4.- Dentro del Directorio raiz Properties
  
  abrir el archivo  launchSettings.json

Eliminar de Profiles:
"https": {
      "commandName": "Project",
      "dotnetRunMessages": true,
      "launchBrowser": true,
      "launchUrl": "swagger",
      "applicationUrl": "https://localhost:7174;http://localhost:5147",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    },

5.- Ejecutar la app para verificar que esta levantando

  dotnet run
