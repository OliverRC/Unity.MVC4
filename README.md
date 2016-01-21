# Unity.MVC4

Unity.Mvc4 is a library that allows simple Integration of Microsoft's Unity IoC container with ASP.NET MVC 4. Identical to Unity.MVC3 except it references MVC4

## Building the Nuget package

1. Compile the .csproj in Visual Studio
2. Package using nuget

        nuget pack deploy\Unity.Mvc4.nuspec -OutputDirectory dist
