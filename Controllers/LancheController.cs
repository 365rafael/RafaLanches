using Microsoft.AspNetCore.Mvc;
using RafaLanches.Repositories;
using RafaLanches.Repositories.Interfaces;

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
			var lanches = _lacheRepository.Lanches;
			return View(lanches);
		}
	}
}
