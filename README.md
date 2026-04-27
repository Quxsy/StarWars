# Star Wars API Project

## Overview
This project is an extension of a previous API assignment using the Star Wars API (SWAPI). It is a Windows Forms application that allows users to search for Star Wars characters (People), Planets, and Species using ID inputs. The application retrieves data from an external API and displays it in a user-friendly interface.

---

## New Features Added
Compared to the original assignment, the following features were added:

- Favorites system allowing users to save People, Planets, and Species
- Improved object-oriented design using inheritance and polymorphism
- Additional entity class structure for better organization
- Enhanced user interaction with multiple API endpoints
- State-based system for tracking the most recently viewed result

---

## Object-Oriented Programming Concepts Used

### Encapsulation
All classes use properties with getters and setters to protect and manage data.

### Inheritance
The class `PersonEntity` inherits from the base class `StarWarsEntity`, sharing common properties such as Name.

### Polymorphism
The `GetDisplay()` method is overridden in `PersonEntity` to provide custom formatted output.

### Constructors
All major classes include constructors to initialize object data properly.

---

## API Features
The application retrieves data from the Star Wars API (SWAPI):

- People (Characters)
- Planets
- Species
- Starships (linked to People)

All API requests are handled using HttpClient and processed using JSON deserialization.

---

## Favorites System

The application includes a favorites feature that allows users to save their preferred People, Planets, or Species.

When a user views a result from the API, they can click "Add to Favorites" to save the currently displayed item. Each favorite stores the name and category (Person, Planet, or Species).

The system prevents duplicate entries from being added.

---

## Favorites Workflow

The application stores the most recently displayed API result using internal variables. When the user clicks "Add to Favorites", the currently displayed Person, Planet, or Species is saved to the favorites list along with its category.

Users can switch between different API searches (Person, Planet, or Species) by entering a new ID and clicking the corresponding button. Each new search updates the current displayed data, and the system always uses the most recently viewed result when adding to favorites.

For example, a user can search for a Person, then switch to a Planet, and then return to a different Person by entering a new ID. Each time, the displayed result is updated, and the Favorites button will always store the most recently loaded item.

The application does not permanently store data between sessions; favorites are stored only while the program is running.

---

## Input Validation & Error Handling
- Empty or invalid API responses are handled using null/empty checks
- Duplicate favorites are prevented
- Try/catch blocks are used in API requests to prevent crashes
- Enter key support is included for faster input handling

---

## How to Run the Project
1. Open the solution in Visual Studio
2. Run the application
3. Enter an ID for a Person, Planet, or Species
4. Click the corresponding button to load data
5. Optionally, click "Add to Favorites" to save the result

---

## Summary
This project demonstrates object-oriented programming principles, API integration, inheritance, polymorphism, and user interaction in a Windows Forms application. It extends a previous API assignment by adding improved structure, additional functionality, and a favorites system.
