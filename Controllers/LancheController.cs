using Microsoft.AspNetCore.Mvc;
using RafaLanches.Repositories;
using RafaLanches.Repositories.Interfaces;
using RafaLanches.ViewModels;

namespace RafaLanches.Controllers
{
	public class LancheController : Controller
	{
		private readonly ILancheRepository _lacheRepository;

		public LancheController(ILancheRepository lacheRepository)
		{
			_lacheRepository = lacheRepository;
		}

		public IActionResult List()
		{

			//var lanches = _lacheRepository.Lanches;
			//return View(lanches);
			var lanchesListViewModel = new LancheListViewModel();
			lanchesListViewModel.Lanches = _lacheRepository.Lanches;
			lanchesListViewModel.CategoriaAtual = "Categoria Atual";
			var totalLanches = lanchesListViewModel.Lanches.Count();
			ViewData["TotalLanches"] = totalLanches;

			return View(lanchesListViewModel);

        }
	}
}
