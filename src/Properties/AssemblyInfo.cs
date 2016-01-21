using System.Reflection;
using System.Runtime.InteropServices;
using System.Web;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Unity.MVC4")]
[assembly: AssemblyDescription("Unity.Mvc4 is a library that allows simple Integration of Microsoft's Unity IoC container with ASP.NET MVC 4. Identical to Unity.MVC3 except it references MVC4")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Brad Vincent, Oliver Rivett-Carnac")]
[assembly: AssemblyProduct("Unity.MVC4")]
[assembly: AssemblyCopyright("Copyright ©  2012")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("29adf951-5c0b-45d4-b8fe-882ea0cd7e05")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.4.0.0")]
[assembly: AssemblyFileVersion("1.4.0.0")]
[assembly: AssemblyInformationalVersion("1.4.0.0")]
[assembly: PreApplicationStartMethod(typeof(Unity.Mvc4.PreApplicationStartCode), "PreStart")]
