#Web.TORCHx.Core

This repository contains an alternative version of the TORCHx web stack written in [.NET Core](https://www.microsoft.com/net/core). .NET Core is a reimplementation of the .NET framework that is cross-platform, open source, Dockerizable, more modular, and up to 10x faster than the traditional .NET framework.

This repo consists of a single .NET core solution that can be opened using Visual Studio 2017 for Windows or Visual Studio for Mac. It contains the following projects:

##Web.TORCHx.Core.BLL
This project contains the pure business logic for the solution. It is data-only and has no UI or dependencies on HTTP. It consists of **service** classes containing business logic,  communicating with [repository](https://msdn.microsoft.com/en-us/library/ff649690.aspx) classes for CRUD data access. Interaction with the SQL Server database is done via [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/).

##Web.TORCHx.Core.Web.API
The project contains the ASP.NET MVC project that exposes a REST API to interface with the business logic layer. As a guiding principle, this layer should be as **thin** as possible. In other words, this layer should only contain the minimal amount of logic for API versioning, authentication/authorization, input validation, JSON serialization, error generation, and exception handling. The API wraps its reponses using the [JSend](https://labs.omniti.com/labs/jsend) specification.

##Web.TORCHx.Core.Web.MVC
The project contains the ASP.NET MVC project that exposes HTML to interface with the business logic layer. As a guiding principle, this layer should be as **thin** as possible. In other words, this layer should only contain the minimal amount of logic for authentication/authorization, input validation, error generation, and exception handling.

##Web.TORCHx.Core.Web.Common
This project contains common code shared between the Web.API and Web.MVC projects. Specifically, code involving cookies and JWT-based authentication.