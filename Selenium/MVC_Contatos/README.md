# Criado com AspNetCore 3.1 - com Blazor Server

dotnet new webapp -o RazorPagesMovie
cd RazorPagesMovie
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design

dotnet tool install -g dotnet-aspnet-codegenerator --version 3.1.0

//para extrair do Views Identity
dotnet aspnet-codegenerator identity -dc MVC_Contatos.Data.ApplicationDbContext

// Add movie model to project
// Build run the app.
// From project directory, run in a command window

dotnet aspnet-codegenerator razorpage -m Movie -dc RazorPagesMovie.Data.MovieContext -udl -outDir Pages\Movies --referenceScriptLibraries

dotnet ef migrations add Initial
dotnet ef database update
