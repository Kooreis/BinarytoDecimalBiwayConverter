# Python Documentation

# Binary to Decimal and Decimal to Binary Converter

This Python script allows the user to convert binary numbers to decimal and vice versa. The script provides a simple text-based user interface that prompts the user to choose between converting binary to decimal, decimal to binary, or exiting the program.

## How it Works

The script defines two functions: `binary_to_decimal(binary)` and `decimal_to_binary(decimal)`. 

- `binary_to_decimal(binary)` takes a binary number as input and returns its decimal equivalent. It uses the built-in `int()` function with base 2 to convert the binary number to decimal.

- `decimal_to_binary(decimal)` takes a decimal number as input and returns its binary equivalent. It uses the built-in `bin()` function to convert the decimal number to binary. The `replace("0b", "")` is used to remove the "0b" prefix that `bin()` adds to the binary output.

The script then enters a while loop that continuously prompts the user to choose an option until they choose to exit. If the user chooses to convert binary to decimal, they are prompted to enter a binary number, which is then converted to decimal and printed. If the user chooses to convert decimal to binary, they are prompted to enter a decimal number, which is then converted to binary and printed. If the user chooses to exit, the loop breaks and the script ends.

## Libraries Used

This script does not use any imported libraries. It only uses built-in Python functions.

---

# C# Documentation

# CSharp Binary-Decimal Conversion Script

This script is a simple console application written in CSharp that allows the user to convert binary numbers to decimal and vice versa.

## Script Description

The script presents a menu to the user with three options:

1. Convert Binary to Decimal
2. Convert Decimal to Binary
3. Exit

The user can select an option by entering the corresponding number. If the user selects option 1 or 2, they are prompted to enter a number in the appropriate format (binary or decimal). The script then converts the number to the other format and displays the result. If the user selects option 3, the script terminates.

## Imported Libraries

The script uses the following libraries:

- `System`: This is a fundamental library in CSharp that provides classes for input/output via streams, string manipulation, exception handling, and more. In this script, it is used for console input/output and for converting strings to integers.

## Code Explanation

The script uses a `while (true)` loop to continuously display the menu until the user chooses to exit. The user's choice is read from the console and converted to an integer.

A `switch` statement is used to execute different code blocks depending on the user's choice. If the user enters 1, they are prompted to enter a binary number, which is then converted to decimal and displayed. If the user enters 2, they are prompted to enter a decimal number, which is then converted to binary and displayed. If the user enters 3, the script terminates. If the user enters any other number, a message is displayed indicating that the choice is invalid.

The conversion between binary and decimal is done using the `Convert.ToInt32` and `Convert.ToString` methods, with the second argument specifying the base of the number system (2 for binary).

---

# Java Documentation

# Binary-Decimal Converter in Java

This Java script is a simple console-based application that allows users to convert binary numbers to decimal and vice versa.

## Description

The script presents a menu to the user with three options:

1. Convert a binary number to decimal.
2. Convert a decimal number to binary.
3. Exit the application.

The user can select an option by entering the corresponding number. If the user selects option 1 or 2, they are prompted to enter a number to convert. The converted number is then displayed. If the user selects option 3, the application exits. If the user enters an invalid choice, an error message is displayed.

## Libraries Used

The script uses the following libraries:

- `java.util.Scanner`: This library is used to read the user's input from the console. It provides methods to parse primitive types and strings using regular expressions, which can be used to break down complex user inputs into manageable data.

## Code Explanation

The `main` method of the `BinaryDecimalConverter` class is the entry point of the application. It creates a `Scanner` object to read the user's input and enters an infinite loop that presents the menu to the user and processes their choice.

The `switch` statement is used to execute different code blocks based on the user's choice. If the user chooses to convert a binary number to decimal, the `Integer.parseInt` method is used with a radix of 2 to parse the binary string as an integer. If the user chooses to convert a decimal number to binary, the `Integer.toBinaryString` method is used to convert the integer to a binary string.

If the user chooses to exit, the `System.exit` method is called with a status code of 0, indicating that the application has exited normally. If the user enters an invalid choice, an error message is displayed.

---
