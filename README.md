# Bank System in C# (OOP)

This is a simple Bank System implemented in C# using Object-Oriented Programming (OOP) principles. The system demonstrates the use of **encapsulation**, **exception handling**, and **good coding practices** such as meaningful naming conventions and comments.

## Features

1. **Create a New Account**: Users can create a new bank account with a unique account number and password.
2. **Login to Existing Account**: Users can log in using their account number and password.
3. **Deposit Money**: Users can deposit money into their account.
4. **Withdraw Money**: Users can withdraw money from their account (with balance validation).
5. **Check Account Balance**: Users can view their current account balance.
6. **Send Money to Another Account**: Users can transfer money to another account (with validation).
7. **Schedule an Appointment**: Users can schedule an appointment at a bank branch.
8. **Exception Handling**: The system includes robust exception handling for invalid inputs, insufficient funds, duplicate accounts, and other errors.

---

## Code Structure

The project is organized into the following classes:

1. **Account.cs**: Represents a bank account with properties like `AccountNumber`, `Password`, `Balance`, and methods for depositing, withdrawing, and transferring money.
2. **Bank.cs**: Manages a collection of accounts and provides methods for creating accounts, logging in, and scheduling appointments.
3. **Program.cs**: The main entry point of the application, handling user input and displaying menus.
4. **Exceptions**: Custom exceptions are used to handle specific errors like insufficient funds, invalid credentials, and duplicate accounts.

---

## How to Use

1. Clone the repository to your local machine.
   ```bash
   git clone https://github.com/your-username/bank-system-csharp.git
