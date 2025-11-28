using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Crudmoura.Models;

namespace Crudmoura.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

      //ação padrão inicial
    public IActionResult Index()
    {
        return View();
    }
     
     public IActionResult MinhaAcao()
    {
        return View(); //retorne a pagina MinhaAcao.cshtml
    }
     //Cria um array de nomes ja preenchido
    public IActionResult ListaNomes()
    {
        string[] nomes = {"Anne", "Maria", "Julio", "Fidalgo", "Torolho"};
        ViewBag.Teste = "Olá, eu vim através da ViewBag";
        ViewBag.nomes = nomes;//guarda os nomes na viewbag

        return View(); //chama a view passando os dados
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
