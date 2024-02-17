# MarketPlants: A Comprehensive Plant Marketplace Application

## Overview
MarketPlants is an advanced .NET 6 application designed to facilitate the buying and selling of plants through a comprehensive marketplace. This project demonstrates a deep integration with relational databases, showcasing complex SQL queries, stored procedures, triggers, and user-defined functions to manage and manipulate data efficiently. The application features a user-friendly Windows Forms interface, making it accessible for users to browse, add, and purchase plants with ease.

## Technologies Used
- **.NET 6**: For building a robust application framework.
- **C#**: As the primary programming language for backend development.
- **SQL Server**: For database management, showcasing advanced SQL scripting.
- **Windows Forms**: For creating the graphical user interface.
- **Entity Framework**: For database integration and manipulation.

## Key Features
- **Dynamic Database Integration**: Utilizes SQL Server to manage user data, plant information, transactions, and more.
- **Complex SQL Operations**: Includes advanced SQL scripts for database setup, data manipulation, and queries, demonstrating proficiency in database management.
- **User Authentication and Authorization**: Secure login and registration system for users, vendors, and administrators.
- **CRUD Operations**: Comprehensive implementation of Create, Read, Update, and Delete operations for managing plants, users, and transactions.
- **Data Validation and Constraints**: Implements data integrity checks, constraints, and triggers to ensure reliable data storage and processing.

## Setup and Installation
1. **Clone the repository:**
- `git clone https://github.com/AlexPaiva/MarketPlants.git`

2. **Database Setup:**
- Install SQL Server and create a new database using the `DatabaseSetup.sql` script.
- Execute the SQL scripts in the `/Db` directory to set up tables, insert initial data, and configure stored procedures and triggers.
3. **Application Configuration:**
- Open the solution in Visual Studio.
- Update the connection string in `appsettings.json` to match your SQL Server instance.
- Build and run the application.

## Database Design
The database is meticulously designed to support the marketplace's operations, featuring tables for users, products (plants), transactions, and more. Key aspects include:
- **Normalization**: Ensures data integrity and reduces redundancy.
- **Indexes**: Improves query performance, especially for search operations.
- **Stored Procedures and Triggers**: Automates complex operations and ensures data consistency.

## How to Use
- **Register/Login**: Start by creating an account or logging in.
- **Browse Plants**: Explore the variety of plants available for sale.
- **Add to Cart**: Select plants and add them to your shopping cart.
- **Checkout**: Complete your purchase with a secure transaction process.

## Contributing
Contributions are welcome! Please fork the repository and submit pull requests with your proposed changes. For major changes, please open an issue first to discuss what you would like to change.

## License
This project is licensed under the MIT License - see the [LICENSE](../main/LICENSE) file for details.

## Contact Information
For any inquiries or collaboration requests, please contact me at: alex0paiva0 at gmail dot com