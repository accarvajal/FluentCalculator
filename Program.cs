/* 
  Code Challenge:
    Implement a simple calculator using C# Lambda expressions and anonymous functions that supports basic arithmetic operations. 
    The calculator should be designed in a fluent style, allowing chained method calls for consecutive operations. 
    The calculator needs to work with decimal values.
    The calculator should support the following operations:
        - Addition
        - Subtraction
        - Multiplication
        - Division
        - Power
 
    Here is the example of the main method calling the fluent calculator.

    var calculator = new FluentCalculator(10)
            .Add(5)
            .Multiply(2)
            .Subtract(3)
            .Divide(2);

    Console.WriteLine("Result: " + calculator.Result); // Output: Result: 13.5

    finally, test Power by adding at the end of the above code:
            .Subtract(3.5)
            .Power(2)

    Console.WriteLine("Result: " + calculator.Result); // Output: Result: 100
 */


using FluentCalculatorOperations;

var calculator = new FluentCalculator(10)
    .Add(5)
    .Multiply(2)
    .Subtract(3)
    .Divide(2);

Console.WriteLine("Result: " + calculator.Result); // Output: Result: 13.5

calculator
    .Subtract(3.5)
    .Power(2);

Console.WriteLine("Result: " + calculator.Result); // Output: Result: 100