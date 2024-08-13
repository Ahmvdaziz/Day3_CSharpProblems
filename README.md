# Shape Area Calculator

## Overview

This is a simple C# console application that calculates and displays the area of different shapes such as rectangles, squares, and circles. The program allows users to input the dimensions of the shapes and displays the area of each shape as well as the total area of all shapes.

## Features
- Calculate the area of various shapes:
  - Rectangle
  - Square
  - Circle
- Interactive console input for user-defined shapes.
- Displays the area of each shape and the total area of all shapes.

## Project Structure

The project is organized into several classes, each in its own file:

- `Shape.cs`: Abstract base class for shapes.
- `Rectangle.cs`: Inherits from `Shape` and calculates the area of a rectangle.
- `Square.cs`: Inherits from `Shape` and calculates the area of a square.
- `Circle.cs`: Inherits from `Shape` and calculates the area of a circle.
- `Picture.cs`: Contains an array of `Shape` objects and calculates the total area.
- `Program.cs`: The main entry point of the application.

## How to Use

1. **Clone the repository:**

   ```bash
   git clone https://github.com/yourusername/shape-area-calculator.git
