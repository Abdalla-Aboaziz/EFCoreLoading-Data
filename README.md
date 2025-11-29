# EF Core Practice – Summary of Implemented Concepts

This project is a complete hands-on implementation of **EF Core relational loading**, **Join operators**, and **Inheritance Mapping** using two separate contexts:

* **AirLineContext** → (Loading Related Data + Joins)
* **Model01DbContext** → (Inheritance Mapping)

The README summarizes the *concepts implemented*, not the questions.

---

## 🚀 Section A – Loading Related Data

Focus: **Navigation properties**, **Include**, **ThenInclude**, **Filtered Include**, and **Many-to-Many loading**.

### ✔ 1. Loading Parent with Nested Collections

Example: Load an airline with its aircrafts and each aircraft’s routes.

* Used:

  * `.Include()`
  * `.ThenInclude()`
  * Many-to-Many intermediate table `RouteAircraft`

### ✔ 2. Load Parent with Child Collection

Example: Load airlines and their employees + nested qualifications.

### ✔ 3. Filtered Includes

Example: Load airlines *only with transactions where Amount > 10000*.

* Used:

  * `Include(a => a.Transactions.Where(...))`

### ✔ 4. Deep Loading across Multiple Relations

Example: Load routes → route-aircraft → aircraft → airline.

* Demonstrates chaining `.ThenInclude()`.

### ✔ 5. Loading Child with Parent

Example: Load all aircrafts with their airline + its phones.

---

## 🧩 Section B – Join Operators (LINQ)

Focus: **LINQ Join**, **multiple joins**, and **selecting mixed data from several tables**.

### ✔ 1. Inner Join

Combine Employees + Airlines to output employee name & airline name.

### ✔ 2. Multi-Level Joins

Join:
Route → RouteAircraft → Aircraft → Airline
Used to show:

* Route information
* Aircraft model
* Airline name

### ✔ 3. Grouping Results by Relation

List each airline with its aircraft models.

### ✔ 4. Conditional Join Output

Show all transactions (id, amount, description) with airline name **where amount > 20000**.

---

## 🏛 Section C – Inheritance Mapping

Focus: **Three different inheritance strategies** in EF Core.

### ✔ Q1 – Table-Per-Hierarchy (TPH)

Both `Car` and `Bus` inherit from `Vehicle`.
Mapped into **a single table** using:

```csharp
HasBaseType<Vehicle>();
```

Result: One table with a discriminator column.

### ✔ Q2 – Table-Per-Type (TPT)

Each derived class has **its own table**, base class has its own table.
Classes:

* Payment (base)
* CreditCardPayment
* CashPayment

Mapping:

```csharp
modelBuilder.Entity<CreditCardPayment>().HasBaseType<Payment>();
```

### ✔ Q3 – Table-Per-Concrete-Type (TPC)

No base table exists.
Each concrete class has its own table.
Classes:

* Book
* Electronics

Configured with:

```csharp
modelBuilder.Entity<Book>().ToTable("Books Table");
modelBuilder.Entity<Electronics>().ToTable("Electronics Table");
```

---

## 📦 Project Highlights

* Demonstrates full EF Core usage in:

  * Navigation Loading
  * Filtered Include
  * Many-to-Many Mapping
  * Fluent API Relations
  * Different Inheritance Strategies
* Includes CRUD operations for all entities.
* All examples are implemented using both:

  * **Method Syntax**
  * **LINQ Query Syntax**

---

## 🧱 Technologies

* .NET 6
* Entity Framework Core
* SQL Server
* LINQ (Query & Method syntax)

---

## 📁 Project Structure

```
/Model01DbContext   → Inheritance Mapping
/AirLineContext     → Loading Related Data + Joins
/Models             → Entities & Relations
/Program.cs         → Samples & Demonstrations
```

---

## ✔ Purpose

This project is intended as a **practical EF Core reference**, showcasing how to:

* Model relationships using Fluent API
* Perform advanced loading patterns
* Execute joins across multiple tables
* Implement inheritance in EF Core

Use it as a quick reference while studying or preparing for backend interviews.


Author: Abdalla Adel Aboaziz
