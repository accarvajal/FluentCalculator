using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentCalculatorOperations; 

public class FluentCalculator(double initValue)
{
    public double Result { get; set; } = initValue;

    public FluentCalculator Add(double value) => ApplyOperation((resultValue) => resultValue += value);

    public FluentCalculator Subtract(double value) => ApplyOperation((resultValue) => resultValue -= value);

    public FluentCalculator Multiply(double value) => ApplyOperation((resultValue) => resultValue *= value);

    public FluentCalculator Divide(double value) => ApplyOperation((resultValue) => resultValue /= value);

    public FluentCalculator Power(double value) => ApplyOperation((resultValue) => Math.Pow(resultValue, value));

    private FluentCalculator ApplyOperation(Func<double, double> operation)
    {
        Result = operation(Result);
        return this;
    }
}


// Otra forma:

public class FluentCalculator2
{
    private decimal _result;

    public FluentCalculator2(decimal initialValue)
    {
        _result = initialValue;
    }

    private FluentCalculator2 Calculate(Func<decimal, decimal, decimal> operation, decimal value)
    {
        _result = operation(_result, value);
        return this;
    }

    public Func<decimal, FluentCalculator2> Add => value => Calculate((a, b) => a + b, value);
    public Func<decimal, FluentCalculator2> Subtract => value => Calculate((a, b) => a - b, value);
    public Func<decimal, FluentCalculator2> Multiply => value => Calculate((a, b) => a * b, value);
    public Func<decimal, FluentCalculator2> Divide => value => Calculate((a, b) => a / b, value);
    public Func<int, FluentCalculator2> Power => exponent => { _result = (decimal)Math.Pow((double)_result, exponent); return this; };

    public decimal Result
    {
        get { return _result; }
    }
}
