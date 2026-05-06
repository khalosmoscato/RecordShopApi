# Record Shop API

A high-performance .NET 10 Web API for managing a record store inventory, built with a focus on security, scalability, and strict engineering standards.

## Project Architecture & Quality Gates

This project is built using modern C# standards and automated quality assurance to ensure a production-ready codebase.

### Layered Design
* API Layer: ASP.NET Core with Minimal APIs, utilizing Scalar for interactive OpenAPI documentation.
* Domain Layer: Strong typing using Records and Enums ensures data integrity and prevents invalid state transitions.
* Data Layer: Repository pattern implementation to decouple core logic from data persistence.

### Global Configuration
* Directory.Build.props: Centralised project configuration ensuring a consistent Target Framework (.NET 10), Nullable reference types, and Implicit Usings across the solution.
* Strict Warnings: TreatWarningsAsErrors is enabled globally to maintain a zero-warning codebase.
* Code Analysis: EnforceCodeStyleInBuild and AnalysisMode (All) are active to ensure the project adheres to .editorconfig rules and security best practices during every build.

### Automation & CI/CD
* GitHub Actions: A build-and-test.yml pipeline automatically validates every push to ensure the solution builds and all tests pass in a clean environment.
* Pull Request Template: A standardised PR template is used to ensure consistent documentation of changes, testing steps, and impact analysis.

### Git Hooks & Standards
* Husky.Net: Manages local Git hooks to automate code quality checks.
* Commit Linting: A commit-msg hook enforces Conventional Commits (feat:, fix:, docs:, etc.). Commits that do not meet this standard are rejected to maintain a professional Git history.

## Folder Structure
```text
RecordShopApi/
├── .github/
│   ├── workflows/             # CI/CD Automation scripts
│   └── pull_request_template.md
├── RecordShop.Api/            # ASP.NET Core Web API
│   ├── Models/                # Domain entities and DTOs
│   ├── Repositories/          # Data access logic
│   ├── GlobalUsings.cs        # Centralised namespace management
│   └── Program.cs             # API Entry point and Scalar config
├── RecordShop.Tests/          # XUnit Test Suite
│   ├── GlobalUsings.cs        # Shared test namespaces (Xunit, Moq)
│   └── ...
├── .husky/                    # Local Git Hook configurations
├── Directory.Build.props      # Global MSBuild settings
├── .editorconfig              # Universal code style rules
├── RecordShopApi.sln          # Solution file
└── README.md
```

## 🛠️ Getting Started

### Prerequisites
* .NET 10 SDK
* PowerShell 7+
* [Husky.Net](https://github.io) (for local commit linting)

### Development
1. Clone the repository.
2. Run `dotnet tool restore` to install Husky.
3. Run `dotnet husky install` to set up local git hooks.
4. Build the solution using `dotnet build` to verify strict rules compliance.
5. Use `dotnet test` to run the suite of XUnit tests.