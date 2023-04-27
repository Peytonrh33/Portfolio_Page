using System.Diagnostics;
using C_Sharp_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Filters;


namespace C_Sharp_Project.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private MyContext _context;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet("/")]
    public IActionResult Index()
    {
        return View("Index");
    }

    [HttpGet("/AboutMe")]
    public IActionResult AboutMe()
    {
        return View("AboutMe");
    }

    [HttpGet("/Contact")]
    public IActionResult Contact()
    {
        return View("Contact");
    }

    [HttpGet("/Reviews/New")]
    public IActionResult Reviews()
    {
        ViewBag.AllReviews = _context.Reviews.ToList();
        return View("Review");
    }

    [HttpPost("/Reviews/Create")]
    public IActionResult CreateReview(Review newReview)
    {
        if(ModelState.IsValid)
        {
            _context.Add(newReview);
            _context.SaveChanges();
            return RedirectToAction("Reviews");
        }
        else
        {
            return View("Review");
        }
    }

    [HttpGet("/Projects")]
    public IActionResult Project()
    {
        return View("Project");
    }












    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
