# Lab2-Assignment

## Student Information
- Names: Umukamisha Celine
- ID: 27400

---

## Project Overview
This project contains two Windows Forms applications developed in C# using Visual Studio and .NET 8:

1. Mushroom Type Identifier
2. Bicycle Business – Rental Cost Calculator

The purpose of this assignment is to apply basic programming concepts such as conditional logic, loops, validation, user input handling, and Windows Forms interface design.

---

## 1. Mushroom Type Identifier
This application asks the user a series of yes/no questions to identify a mushroom type based on its characteristics.

### Features
- Step-by-step question flow
- Yes/No answer handling
- Result display
- Reset button to start again
- Question log for tracking answers

### Screenshots
![Mushroom identifier before run](Mushroom-type/Mushuroom-type/mushroom%20identifier%20before%20run%20nn.png)

![Answering based on yes or no](Mushroom-type/Mushuroom-type/answerring%20based%20on%20yes%20or%20no.png)

![Pied bleu result](Mushroom-type/Mushuroom-type/pie%20de%20bleu.png)

---

## 2. Bicycle Business – Rental Cost Calculator
This application calculates the total rental cost for a bicycle based on the starting and ending hours entered by the user.

### Features
- Time input validation
- Cost calculation per hour
- Total rental cost display
- Error messages for invalid values
- Structured output for hourly breakdown

### Screenshots
![Design before running](biscyle_business/biscyle_business/look%20of%20the%20design%20before%20running%20bicycle.png)

![Calculating hours and validation working](biscyle_business/biscyle_business/calculating%20hrs%20and%20validation%20is%20working%20.png)

---

## How to Run
1. Open the solution file in Visual Studio.
2. Restore NuGet packages if prompted.
3. Set the bicycle project as the startup project.
4. Run the app.
5. Log in with the default credentials: username = admin, password = 1234.
6. After login, choose either Bicycle Business or Mushroom Type.

---

## Login Form and App Selection
The application starts with a login form before any project can be opened. This ensures the user must authenticate before accessing the business or mushroom tools.

### Login Screen
- Username field
- Password field
- Login button
- Validation for incorrect credentials

### Default Login Credentials
- Username: admin
- Password: 1234

If the credentials are correct, the user is redirected to the application selection screen. From there, they can choose between:
- Bicycle Business
- Mushroom Type

This flow makes the app more secure and matches the required design: login first, then choose the application.

---

## Requirements
- Visual Studio installer
- .NET 8.0
- Windows operating system

---

(Lab2 assignment)
