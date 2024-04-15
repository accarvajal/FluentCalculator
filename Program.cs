using FluentCalculatorOperations;

var calculator = new FluentCalculator(10)
    .Add(5)
    .Multiply(2)
    .Subtract(3)
    .Divide(2)
    .Subtract(3.5)
    .Power(2);

Console.WriteLine("Result: " + calculator.Result); // Output: Result: 13.5
