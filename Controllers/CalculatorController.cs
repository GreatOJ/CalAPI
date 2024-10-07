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

    [HttpGet("ädd")]
    public IActionResult Add(double x, double y)
    {
        var result = _calculatorService.Add(x, y);
        return Ok(result);
    }

    [HttpGet("subtract")]
    public IActionResult Subtract(double x, double y)
    {
        var result = _calculatorService.Subtract(x, y);
        return Ok(result);
    }

    [HttpGet("multiply")]
    public IActionResult Multiply(double x, double y)
    {
        var result = _calculatorService.Multiply(x, y);
        return Ok(result);
    } 

    [HttpGet("divide")]
    public IActionResult Divide(double x, double y)
    {
        var result = _calculatorService.Divide(x, y);
        return Ok(result);

    }

}