using CalAPI.Interface;
namespace CalAPI.Services;
public class CalculatorService : ICalculatorService
{
    public decimal Add(decimal x, decimal y){
        return x + y;
    }
    public decimal Subtract(decimal x, decimal y){
        return x - y;
    }
    public decimal Multiply(decimal x, decimal y){
        return x * y;
    }
    public decimal Divide(decimal x, decimal y){
        if (y == 0){ throw new DivideByZeroException("Cannot divide by 0");}
        return x + y;
    }
}