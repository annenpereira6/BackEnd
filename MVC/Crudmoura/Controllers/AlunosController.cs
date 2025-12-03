using Crudmoura.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Crudmoura.Controllers
{

    public class AlunosController : Controller
    {
        private readonly ILogger<AlunosController> _logger;


        public static List<Aluno> listaDeAlunos = new List<Aluno>
        {
        new Aluno  { Id = 1, Nome = "Anne", Idade = 17, Materia= "Historia", Cidade = "São Paulo" },
        new Aluno  { Id = 2, Nome = "Maria", Idade = 17, Materia= "Geografia", Cidade = "São Paulo"  },
        new Aluno  { Id = 3, Nome = "Rafa", Idade = 17, Materia= "Matematica", Cidade = "São Paulo" },
        new Aluno  { Id = 4, Nome = "Bia", Idade = 16, Materia= "Portugues", Cidade = "São Paulo"  },


        };
        public AlunosController(ILogger<AlunosController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListarAlunos()
        {
            ViewBag.Alunos = listaDeAlunos;
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SalvarAluno(Aluno AlunoCadastrado)
        {
            AlunoCadastrado.Id = listaDeAlunos.Max(f => f.Id) + 1;
            listaDeAlunos.Add(AlunoCadastrado);
            return RedirectToAction(nameof(ListarAlunos));
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}