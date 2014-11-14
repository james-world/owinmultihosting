#Owin Hosting Options#

This Visual Studio solution demonstrates hosting an OWIN based WebApi in a console app, IIS and in-memory (for integration testings) - with the WebApi itself in a separate self-contained class library. It has the following projects:

- Api: A self-contained OWIN WebApi with a single controller, `ValuesController`
- IISHost: A web project that hosts `Api` in IIS.
-  SelfHost: A console app that self hosts `Api`.
-  ApiTests: `NUnit` integration tests using the in-memory host in the `Microsoft.Owin.Testing` nuget package.