# Student Data Management System

> Computer Programming Lab | Semester 1 | Spring 2026

## Project Overview

A Windows Forms application built with C# and .NET 6.0 for managing student and admin data. This project demonstrates fundamental programming concepts including GUI development, multi-form navigation, file handling, and basic authentication mechanisms.

## Academic Context

This project was developed as part of the Computer Programming Lab course during the first semester. The primary objective was to apply foundational programming concepts learned in the course, including object-oriented programming principles, event-driven GUI development, and file I/O operations in a practical application.

## Problem Statement

Educational institutions need simple, efficient systems to manage student records and academic performance data. This project addresses the need for:

- A user-friendly interface for both administrators and students
- Secure admin authentication to protect sensitive data
- Efficient storage and retrieval of student academic records
- Grade calculation and performance tracking capabilities

The system provides a menu-driven interface that allows administrators to input student data and grades, while students can look up their academic performance.

## Features Implemented

### Core Functionality
- **Menu-Driven Navigation**: Intuitive main menu with clear navigation paths
- **Admin Authentication**: Username/password validation from text file storage
- **Student Data Entry**: Form-based input for student enrollment and subject marks
- **Grade Calculation**: Automated grade computation based on obtained marks
- **Data Persistence**: File-based storage for student records and admin credentials

### User Interface
- **Multiple Form Architecture**: Specialized forms for different functions
- **Form Transitions**: Smooth navigation between forms with back/logout options
- **Input Validation**: Basic validation for required fields and mark ranges
- **Visual Feedback**: Message boxes for user confirmation and error handling

### Administrative Features
- **Bulk Student Entry**: Support for entering multiple student records
- **Mark Validation**: Ensures marks are within valid ranges (0-20 per subject)
- **Grade Calculation**: Automatic computation of total marks and letter grades
- **Data Storage**: Persistent storage of student academic records

### Student Features
- **Record Lookup**: Search by enrollment number to view academic results
- **Results Display**: Clear presentation of marks across all subjects
- **Grade Information**: View computed letter grade and total marks

## Technology Stack

| Component | Technology |
|-----------|------------|
| Language | C# (.NET 6.0) |
| UI Framework | Windows Forms |
| IDE | Visual Studio 2022 |
| Data Storage | Text Files |
| Platform | Windows |

## Project Structure

```
student-data-management-system/
├── README.md                           # This file
├── Student_Data-Management_System.sln  # Visual Studio solution file
├── .gitignore                          # Git ignore rules
└── src/                                # Source code files
    ├── Form1.cs                        # Main menu form
    ├── Form1.Designer.cs               # Form1 designer code
    ├── Form1.resx                      # Form1 resources
    ├── Form2.cs                        # Admin login form
    ├── Form2.Designer.cs               # Form2 designer code
    ├── Form2.resx                      # Form2 resources
    ├── Form3.cs                        # Student lookup form
    ├── Form3.Designer.cs               # Form3 designer code
    ├── Form3.resx                      # Form3 resources
    ├── Form4.cs                        # Admin dashboard form
    ├── Form4.Designer.cs               # Form4 designer code
    ├── Form4.resx                      # Form4 resources
    ├── Form5.cs                        # Student results form
    ├── Form5.Designer.cs               # Form5 designer code
    ├── Form5.resx                      # Form5 resources
    ├── Program.cs                      # Application entry point
    └── Student_Data-Management_System.csproj  # Project file
```

## How to Run

### Prerequisites
- Windows OS
- .NET 6.0 SDK or later
- Visual Studio 2022 (recommended)

### Installation Steps
1. **Clone the repository**
   ```bash
   git clone https://github.com/your-username/student-data-management-system.git
   cd student-data-management-system
   ```

2. **Open in Visual Studio**
   - Open `Student_Data-Management_System.sln`

3. **Build the project**
   - Press `Ctrl+Shift+B` or go to Build → Build Solution

4. **Run the application**
   - Press `F5` or click the Start button

### Configuration Notes
- The application reads admin credentials from `Admin.txt`
- Student data is stored in `Student.txt`
- Update file paths in `Form2.cs` and `Form4.cs` if needed

## Key Concepts Learned

### Programming Fundamentals
- **Object-Oriented Programming**: Classes, objects, properties, and methods
- **Event-Driven Programming**: Handling user interactions through events
- **Control Structures**: Conditional statements and loops for business logic
- **String Manipulation**: Parsing and formatting data for display

### GUI Development
- **Windows Forms**: Creating and designing graphical user interfaces
- **Form Management**: Multiple form architecture and navigation patterns
- **Control Properties**: Configuring UI elements for better user experience
- **Event Handling**: Implementing click events and form load operations

### File Operations
- **File I/O**: Reading from and writing to text files
- **Stream Processing**: Using StreamReader and StreamWriter classes
- **Data Persistence**: Storing application data for later retrieval
- **Path Management**: Working with file system paths

### Software Design
- **Separation of Concerns**: Different forms for different functionalities
- **User Experience**: Menu-driven interface for intuitive navigation
- **Input Validation**: Ensuring data integrity before processing
- **Error Handling**: Providing feedback for invalid operations

## Future Improvements

### Short-term Enhancements
- [ ] Implement relative file paths for better portability
- [ ] Add comprehensive input validation for all fields
- [ ] Improve error handling with try-catch blocks
- [ ] Add data format validation for marks and enrollment numbers

### Medium-term Features
- [ ] Implement database storage (SQL Server or SQLite)
- [ ] Add password hashing for secure credential storage
- [ ] Create search functionality for multiple criteria
- [ ] Implement CRUD operations for student records

### Long-term Vision
- [ ] Add reporting and analytics features
- [ ] Implement user role management (multiple admin levels)
- [ ] Create backup and restore functionality
- [ ] Add export options (PDF, Excel, CSV)

## Course Information

**Course**: Computer Programming Lab  
**Semester**: 1  
**Institution**: Bahria University Karachi  
**Academic Year**: Fall-2023

## Author

**M. Khizar Akram**  
BSE-1(B)  
Enrollment: 02-131232-064

## License

This project was developed for academic purposes as part of the Computer Programming Lab course. It is intended for educational use and learning demonstration.

---

**Note**: This project demonstrates fundamental programming concepts and is designed to showcase practical application of course material. It represents a first-semester learning experience in software development.
