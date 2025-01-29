# Bank Management System

## Overview
The **Bank Management System** is a C# Object-Oriented Programming (OOP) project that simulates basic banking operations while utilizing encapsulation, meaningful naming conventions, and structured comments. The system allows users to:

- Create a new bank account
- Sign in to an existing account using account number and password
- Deposit funds
- Withdraw funds with balance validation
- Check account details
- Transfer money to another account
- Schedule an appointment at a bank branch
- Handle exceptions robustly to ensure a smooth user experience

## Features

### 1. **User Authentication**
- New users can register with a unique account number and password.
- Existing users can log in securely.

### 2. **Account Operations**
- **Deposit Money:** Users can deposit funds into their accounts.
- **Withdraw Money:** Users can withdraw funds with validation to prevent overdrawing.
- **Check Balance:** Users can view their current account balance.
- **Transfer Money:** Users can send money to another account by providing the recipient's account number.

### 3. **Bank Appointment Scheduling**
- Users can schedule appointments at a bank branch.

### 4. **Exception Handling**
- Ensures the system handles errors gracefully, such as invalid inputs, insufficient balance, and incorrect credentials.

## Technologies Used
- **Language:** C#
- **Paradigm:** Object-Oriented Programming (OOP)
- **Encapsulation:** Implemented to protect sensitive data (e.g., account password, balance)

## Installation
```sh
# Clone the repository
git clone https://github.com/yourusername/bank-system.git

# Navigate to the project directory
cd bank-system

# Open the project in Visual Studio or any C#-compatible IDE
```

## Usage
### 1. **Create an Account**
- The system prompts for user details, generates an account number, and stores the information securely.

### 2. **Sign In**
- Enter the registered account number and password to access banking features.

### 3. **Perform Transactions**
- Choose operations like deposit, withdraw, transfer, or check balance.

### 4. **Schedule an Appointment**
- Enter the preferred branch and time slot for the appointment.

## Example Code Snippet
```csharp
public class BankAccount
{
    private string accountNumber;
    private string password;
    private decimal balance;

    public BankAccount(string accountNumber, string password, decimal initialBalance)
    {
        this.accountNumber = accountNumber;
        this.password = password;
        this.balance = initialBalance;
    }

    public bool Authenticate(string inputPassword)
    {
        return password == inputPassword;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be greater than zero.");
        }
        balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > balance)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }
        balance -= amount;
    }

    public decimal GetBalance()
    {
        return balance;
    }
}
```

## Exception Handling
- **Invalid login attempts:** Users receive a clear error message if credentials are incorrect.
- **Invalid transactions:** The system prevents withdrawals that exceed the account balance.
- **Input validation:** Ensures users enter correct data types (e.g., numbers for monetary transactions).

## Future Enhancements
- Implement a database to store account data persistently.
- Add a graphical user interface (GUI) for better user experience.
- Introduce two-factor authentication for improved security.

## License
This project is open-source and available under the [MIT License](LICENSE).

## Contact
For inquiries or contributions, contact: [your.email@example.com] or visit the GitHub repository: [GitHub Repository Link]

