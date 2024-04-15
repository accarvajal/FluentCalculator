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
