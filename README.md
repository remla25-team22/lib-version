# lib-version

This repository contains the **version-aware utility library** for the REMLA project (Team 22).  
It provides a class that exposes the current version of the library, enabling version introspection for logs, APIs, or monitoring.

---

##  Project Structure

```
lib-version/
├── lib-version/             # Main source code directory
│   └── VersionUtil.cs       # Class to retrieve version
├── lib-version.tests/       # Unit tests for VersionUtil
│   └── VersionTest.cs
├── VERSION.txt              # Semantic version file
├── .github/workflows/       # CI/CD automation
│   └── github-actions.yml   # Version tagging and pre-release bump
└── lib-version.sln          # .NET Solution file
```

---

## Usage

The `VersionUtil` class reads the library version from `VERSION.txt`, making it accessible at runtime.

```csharp
string version = VersionUtil.GetVersion();
Console.WriteLine($"Current Version: {version}");
```
