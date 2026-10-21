# C# Inheritance Examples

This repository contains C# code examples to understand **Inheritance in C#**, an important concept of Object-Oriented Programming (OOP).

The examples are based on a tutorial covering inheritance, access modifiers, and different types of inheritance.

## 📚 Topics Covered

- What is Inheritance?
- Parent Class and Child Class
- Base Class and Derived Class
- Syntax of Inheritance in C#
- Public, Private, and Protected Access Modifiers
- Single Inheritance
- Multilevel Inheritance
- Hierarchical Inheritance
- Multiple Inheritance and its limitations in C#
- Hybrid Inheritance

## 🛠️ Technologies Used

- C#
- .NET
- Visual Studio

## 📂 Project Structure

```text
CSharp-Inheritance-Examples/
├── Program.cs
├── README.md
└── .gitignore
```

## 💡 What Is Inheritance?

Inheritance is an Object-Oriented Programming concept that allows a new class to acquire accessible members of an existing class.

In C#, inheritance is implemented using a colon (`:`) followed by the parent class name.

### Example

```csharp
class Car
{
    public string model;
    public string color;
    public int price;
}

class Maruti : Car
{
    public float mileage;
}
```

Here, `Car` is the parent class, and `Maruti` is the child class. The `Maruti` class inherits the accessible members of `Car`.

## 🚗 Types of Inheritance Demonstrated

### 1. Single Inheritance

One child class inherits from one parent class.

```text
Car
 |
Maruti
```

### 2. Multilevel Inheritance

A class inherits from a derived class, forming a chain.

```text
Car
 |
Ferrari
 |
Maruti
```

### 3. Hierarchical Inheritance

Multiple child classes inherit from the same parent class.

```text
      Car
     /   \
Ferrari  Maruti
```

**Note:** C# does not support multiple inheritance of classes. A class can implement multiple interfaces.

## 🔐 Access Modifiers

- `public`: Accessible wherever permitted by the type's visibility.
- `private`: Accessible within the containing type.
- `protected`: Accessible within the containing type and its derived types.

These modifiers control how class members can be accessed.

## ▶️ How to Run the Project

1. Install the .NET SDK.
2. Clone this repository:

   ```bash
   git clone https://github.com/YOUR_USERNAME/CSharp-Inheritance-Examples.git
   ```

3. Navigate to the project folder:

   ```bash
   cd CSharp-Inheritance-Examples
   ```

4. Run the application:

   ```bash
   dotnet run
   ```

If you created a standalone `Program.cs` file without a project file, create a console project first using `dotnet new console`, then replace its `Program.cs` with your example.

## 🎯 Learning Objective

The objective of this project is to understand how inheritance enables code reuse, establishes relationships between classes, and supports different inheritance structures in C#.

## 📖 Reference

- YouTube tutorial: https://youtu.be/ES9n7crZ65o

## 👨‍💻 Author

Created as part of my C# and Object-Oriented Programming learning journey.
