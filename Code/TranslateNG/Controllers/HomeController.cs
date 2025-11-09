using System.Diagnostics;
using Data.Entities;
using Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using TranslateNG.Models;

namespace TranslateNG.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly ILanguagesRepository languagesRepository;

    public HomeController(ILogger<HomeController> logger, ILanguagesRepository languagesRepository)
    {
        _logger = logger;
        this.languagesRepository = languagesRepository;
    }

    public IActionResult Index()
    {
        // var newLanguage = new Languages();
        // newLanguage.Name = "this is a test language2";
        // languagesRepository.Insert(newLanguage);
        return View();
    }

    [HttpGet]
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
