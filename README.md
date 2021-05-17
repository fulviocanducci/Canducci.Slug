# Canducci.Slug

[![NuGet](https://img.shields.io/nuget/v/Canducci.Slug.svg?style=plastic&label=version)](https://www.nuget.org/packages/Canducci.Slug/)
[![NuGet](https://img.shields.io/nuget/dt/Canducci.Slug.svg)](https://www.nuget.org/packages/Canducci.Slug/)
[![.NET Core](https://github.com/fulviocanducci/Canducci.Slug/actions/workflows/dotnet-core.yml/badge.svg)](https://github.com/fulviocanducci/Canducci.Slug/actions/workflows/dotnet-core.yml) [![Coverage Status](https://coveralls.io/repos/github/fulviocanducci/Canducci.Slug/badge.svg?branch=master)](https://coveralls.io/github/fulviocanducci/Canducci.Slug?branch=master)

### Package Installation (NUGET)

```Csharp
PM> Install-Package Canducci.Slug
```

### How to use?

Declare o namespace `using Canducci.Slug;`

```csharp
string textSlug = "product source main".ToSlug();
// product-source-main
```
