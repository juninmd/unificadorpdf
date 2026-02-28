```markdown
# AGENTS.md File Guidelines

These guidelines are designed to ensure the efficient, maintainable, and reliable development of AGENTS.md. Adherence to these principles is mandatory for all development efforts.

## 1. DRY (Don't Repeat Yourself)

*   All code should have single, well-defined responsibilities.
*   Avoid duplicating functionality.
*   Refactor existing code to improve reusability.
*   When implementing a new feature, it should be implemented once and then reused across multiple AGENTS.md files.

## 2. KISS (Keep It Simple, Stupid)

*   Prioritize simplicity in design.
*   Avoid unnecessary complexity.
*   Use clear and concise code.
*   Strive for readability.
*   Break down large tasks into smaller, manageable units.

## 3. SOLID Principles

*   **Single Responsibility Principle:** Each class/module should have one and only one reason to change.
*   **Open/Closed Principle:** Classes/Modules should be open for extension but closed for modification.
*   **Liskov Substitution Principle:** Subclasses should be substitutable for their base classes without altering the correctness of the program.
*   **Interface Segregation Principle:** Clients should not be forced to implement interfaces they do not use.
*   **Dependency Inversion Principle:** Interfaces should be replaced by implementations.

## 4. YAGNI (You Aren't Gonna Need It)

*   Only implement functionality that is explicitly required at the current point in time.
*   Avoid implementing unnecessary features.
*   Focus on delivering working code first, then add features.

## 5. File Size & Code Structure

*   Each file should be no more than 180 lines of code.
*   File structure should be logical and hierarchical.
*   Use clear naming conventions.
*   Consistent indentation and whitespace.
*   Comments should explain *why* not *what*.

## 6. Testing & Coverage

*   All development MUST be productive.
*   Automated tests should be prioritized.
*   Tests should cover critical functionality and edge cases.
*   Aim for 80% test coverage across all modules.
*   Coverage reports should be generated and reviewed regularly.

## 7.  Code Standards & Practices

*   Use a consistent code style guide (e.g., PEP 8 for Python).
*   Follow established coding conventions.
*   Employ version control (Git) for all changes.
*   Document code effectively using docstrings.
*   Unit tests should be written as early as possible.

## 8.  Specific Considerations - AGENTS.md

*   Each agent module shall follow a consistent structure.
*   All data structures should be well-defined and documented.
*   Interfaces should be clearly documented with examples.
*   Error handling should be robust and informative.
*   Data validation is a core concern.

## 9.  Error Handling & Logging

*   Use appropriate logging levels for different scenarios.
*   Log important events and errors.
*   Implement error handling to gracefully manage unexpected situations.

## 10.  Maintainability & Readability

*   Use meaningful variable and function names.
*   Write clear and concise code.
*   Use whitespace effectively to improve readability.
*   Include comments to explain complex logic.

## 11.  Dependencies

*   All dependencies should be documented and managed.
*   Dependencies should be versioned and tested.

## 12.  Testing Framework

*   Utilize a robust testing framework (e.g., pytest, unittest).
*   Write unit tests to verify individual components.
*   Implement integration tests to verify interactions between modules.
```