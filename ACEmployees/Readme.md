### Este proyecto fue realizado por Alfredo Castro, es una mini-webapp para CRUD de Empleados

## Características 
* VS 2019 y SQL Server 2019
* ASP.NET MVC .NET Framework 4.7
* Ajax mediante jquery.unobtrusive-ajax, PartialView actualizado via Ajax (_Index)
* HTMLExtensions DisplayWithBreaksFor, DisplayForBool y LabelForReq, para mejorar el desarrollo de los Views
* Mínimo uso de JS para validar los modelos usando el jquery.validate.unobtrusive y máximo uso de Atributos en el modelo
* RegEx para validar entrada de datos y aumentar seguridad
* NLog para registro de errores
* ASP.NET Identity, con campos adicionales, IdentityExtensions y localización en español
* Migraciones para la BD con seed
* Custom ModelBinders: DateTimeModelBinder y DecimalModelBinder
* Custom Atributes para validar entrada de fechas anteriores a la actual: NotAfterTodayAttribute
* Entity Framework 6 y LinQ
* Bootstrap 4
* JQuery Mask
* Bootstrap Datepicker
* Bootstrap Toggle
* Tablesorter.js
* Moment.js
* PagedList.MVC
* Compilación condicional (#if DEBUG)
* Comentarios: buscar "Alfredo Castro" en el todo código
* Validaciones: ver el modelo Employee y los atributos usados par validar cada campo
* Pagina 404 personalizada
* Pagina 500 personalizada

## Instrucciones
* Verificar que tiene instalado Visual Studio 2019 en su PC
* Verificar que tiene instalado SQL Server 2019 en su PC y existe alguna instancia de BD
* Descomprimir el archivo ZIP en alguna carpeta
* Abrir el archivo "ACEmployees.sln" utilizando Visual Studio 2019
* Compilar y esperar que se instalen todos los Nuget Packages
* Abrir el archivo Web.config, ubicar el nodo "connectionStrings" y modificar el valor del "DefaultConnection" para poder crear la base de datos en alguna instancia de SQL Server
* En Visual Studio ir al menú Tools > Nuget Package Manager > Package Manager Console
* En el Package Manager Console ejecutar el comando "update-database" y esperar que finalice la ejecución
* Ejecutar la aplicación
* Registrarse con Nombre, email y una contraseña