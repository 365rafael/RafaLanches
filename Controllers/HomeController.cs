using Microsoft.AspNetCore.Mvc;
using RafaLanches.Models;
using RafaLanches.Repositories.Interfaces;
using RafaLanches.ViewModels;
using System.Diagnostics;

namespace RafaLanches.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILancheRepository _repository;

        public HomeController(ILancheRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                LanchesPreferidos = _repository.LanchesPreferidos
            };
            return View(homeViewModel);
        }
        
        public IActionResult Demo()
        {
            return View();
        }

       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}