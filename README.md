# CSharp-Essentials-Projects

This repository contains a set of basic C# console and frontend-integrated applications that demonstrate fundamental programming concepts and practical implementations. These projects are ideal for beginners learning the C# language, object-oriented programming, and API integration.

## 💡 Projects Included

### 1. 🔢 Basic Calculator
A simple calculator that performs addition, subtraction, multiplication, and division.

**Concepts Used:**
- User input/output
- Conditional statements
- Switch case

### 2. 🧮 Student Grade Evaluator
Reads student marks and determines grades based on a grading scale.

**Concepts Used:**
- If-else conditions
- Loops
- Functions

### 3. 👩‍💼 Employee Admin Portal (Basic)
Manages a list of employees and displays basic admin operations (e.g., view, add).

**Concepts Used:**
- Classes and objects
- Lists and collections
- Menu-driven program

### 4. 🌐 Fetch and Display Posts App
Uses C# to fetch data from an external API and saves it in a `data.json` file. A separate HTML/JavaScript frontend displays the data dynamically in a styled table.

**Concepts Used:**
- HTTP requests (GET)
- JSON serialization/deserialization
- File handling
- JavaScript `fetch()` API
- Dynamic DOM manipulation

### 5. 🔐 AuthSessionDemocd (User Registration & Login)
This project demonstrates fundamental user authentication processes, including user registration and login functionalities. It's designed to showcase basic concepts of secure user management.

**Concepts Used:**
- User input validation
- Password handling (e.g., hashing - _implementation details may vary_)
- User data storage (e.g., in-memory, file-based, or basic database interaction - _specific implementation details not provided here_)
- Basic session management (if applicable for the demo)

## 🚀 How to Run

Each project is in its own folder. Navigate to the respective project folder and run using the .NET CLI or Visual Studio.

### For the C# Console Apps (Basic Calculator, Student Grade Evaluator, Employee Admin Portal, AuthSessionDemocd):

1.  Open your terminal or command prompt.
2.  Navigate to the specific project's directory (e.g., `cd "Basic Calculator"`).
3.  Run the application:
    ```bash
    dotnet run
    ```

### For the Frontend-Integrated App (Fetch and Display Posts App):

1.  Navigate to the `Fetch and Display Posts App` directory.
2.  Run the C# backend to fetch data:
    ```bash
    dotnet run
    ```
    This will generate the `data.json` file.
3.  Open the `index.html` file located in the `Frontend` subfolder of `Fetch and Display Posts App` in your web browser to view the displayed data.

## 🤝 Contributing

Feel free to fork this repository, add your own C# essential projects, or improve existing ones. Pull requests are welcome!
