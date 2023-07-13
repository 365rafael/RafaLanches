using Microsoft.AspNetCore.Mvc;
using RafaLanches.Repositories;

namespace RafaLanches.Controllers
{
	public class LancheController : Controller
	{
		private readonly LancheRepository _lacheRepository;

		public LancheController(LancheRepository lacheRepository)
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
