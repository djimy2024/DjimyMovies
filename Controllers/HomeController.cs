using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DjimyMovies.Models;

namespace DjimyMovies.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var movies = new List<Movie>();
    return View(movies); 
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Create()
    {
    return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}


