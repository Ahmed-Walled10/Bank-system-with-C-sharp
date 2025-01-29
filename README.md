# 🏦 Bank System in C# (OOP)

A secure and robust bank system demonstrating **C# Object-Oriented Programming**, **encapsulation**, and **exception handling**. Built with clean code practices, meaningful naming conventions, and detailed comments.

---

## 🚀 Features

- **Account Management**:
  - ✅ Create a new account (unique account number + password).
  - 🔐 Log in with existing credentials.
  - 💰 Deposit/Withdraw funds (with validation).
  - 📤 Transfer money to other accounts.
  - 📅 Schedule appointments at bank branches.
- **Error Handling**:
  - 🛑 Custom exceptions for invalid inputs, duplicates, insufficient funds, and more.

---

## 🧱 Code Structure

### Key Classes
- **`Account`**:  
  - Encapsulates `AccountNumber`, `Password`, `Balance`.  
  - Methods: `Deposit()`, `Withdraw()`, `Transfer()`.
- **`Bank`**:  
  - Manages accounts (`List<Account>`).  
  - Methods: `CreateAccount()`, `Login()`, `ScheduleAppointment()`.
- **`Program`**:  
  - Main entry point with user menus and input handling.
- **Custom Exceptions**:  
  - `InsufficientFundsException`, `InvalidCredentialsException`, `DuplicateAccountException`.

---
