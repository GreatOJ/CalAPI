using Microsoft.AspNetCore.Mvc;
using CalAPI.Interface;

namespace CalAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculatorController : Controller
{
    private readonly ICalculatorService _calculatorService;
    public CalculatorController(ICalculatorService calculatorService){
        _calculatorService = calculatorService;
    } 

    [Route("{x}/{y}")]
    [HttpGet]
    public decimal Add(decimal x, decimal y)
    {
        return _calculatorService.Add(x, y);
    }
    [Route("{x}/{y}")]
    [HttpGet]
    public decimal Subtract(decimal x, decimal y)
    {
        return _calculatorService.Subtract(x, y);
    }
    [Route("{x}/{y}")]
    [HttpGet]
    public decimal Multiply(decimal x, decimal y)
    {
        return _calculatorService.Multiply(x, y);
    } 
    [Route("{x}/{y}")]
    [HttpGet]
    public decimal Divide(decimal x, decimal y)
    {
        return _calculatorService.Divide(x, y);
    }

}