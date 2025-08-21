# Inheritance in C# - Vehicle Simulation

## Overview

This project demonstrates **inheritance** in C# using a base class (`Vehicle`) and multiple derived classes (`Car`, `Bicycle`, `Boat`). 
The base class provides common functionality (e.g., `Speed` and `Go()` method), 
and each derived class adds its specific properties (e.g., number of wheels). 
The program simulates the behavior of different types of vehicles.

## Project Structure

* **Vehicle**: A base class representing a generic vehicle with basic properties like speed and a method to simulate movement (`Go()`).
* **Car**: A class representing a car, inheriting from `Vehicle` with 4 wheels.
* **Bicycle**: A class representing a bicycle, inheriting from `Vehicle` with 2 wheels.
* **Boat**: A class representing a boat, inheriting from `Vehicle` with 0 wheels (since boats don’t have wheels).

## Features

* **Vehicle Class**: Defines basic properties and methods common to all vehicles.
* **Derived Classes**:

  * `Car`: Has 4 wheels.
  * `Bicycle`: Has 2 wheels.
  * `Boat`: Has 0 wheels.
* **Method `Go()`**: Simulates vehicle movement across all vehicle types.

## How to Run

1. Clone this repository to your local machine.
2. Open the project in Visual Studio or any C#-compatible IDE.
3. Build and run the application.
4. Observe the output displaying different vehicle types, their speed, and the number of wheels.

### Example Output

```
CAR SPEED: 0
CAR WHEEL(S): 4
This vehicle is moving.

BICYCLE SPEED: 0
BICYCLE WHEEL(S): 2
This vehicle is moving.

BOAT SPEED: 0
BOAT WHEEL(S): 0
This vehicle is moving.
```

## Requirements

* .NET Core or .NET Framework (for building and running the application).
* Visual Studio or any C#-compatible IDE.

## DISCLAIMER

UNDER NO CIRCUMSTANCES SHOULD IMAGES OR EMOJIS BE INCLUDED DIRECTLY 
IN THE README FILE. ALL VISUAL MEDIA, INCLUDING SCREENSHOTS AND IMAGES 
OF THE APPLICATION, MUST BE STORED IN A DEDICATED FOLDER WITHIN THE 
PROJECT DIRECTORY. THIS FOLDER SHOULD BE CLEARLY STRUCTURED AND NAMED 
ACCORDINGLY TO INDICATE THAT IT CONTAINS ALL VISUAL CONTENT RELATED TO 
THE APPLICATION (FOR EXAMPLE, A FOLDER NAMED IMAGES, SCREENSHOTS, OR MEDIA).

I AM NOT LIABLE OR RESPONSIBLE FOR ANY MALFUNCTIONS, DEFECTS, OR ISSUES 
THAT MAY OCCUR AS A RESULT OF COPYING, MODIFYING, OR USING THIS SOFTWARE. 
IF YOU ENCOUNTER ANY PROBLEMS OR ERRORS, PLEASE DO NOT ATTEMPT TO FIX THEM 
SILENTLY OR OUTSIDE THE PROJECT. INSTEAD, KINDLY SUBMIT A PULL REQUEST 
OR OPEN AN ISSUE ON THE CORRESPONDING GITHUB REPOSITORY, SO THAT IT CAN 
BE ADDRESSED APPROPRIATELY BY THE MAINTAINERS OR CONTRIBUTORS.

---
