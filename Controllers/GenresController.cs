using Bookstoret2.Data;
using Bookstoret2.Models;
using Bookstoret2.Services;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bookstoret2.Controllers
{
	public class GenresController : Controller
	{
		private readonly GenreService _service;

		public GenresController(GenreService service)
		{
			_service = service;
		}

		public async Task<IActionResult> Index()
		{
			return View(await _service.FindAllAsync());
		}

		// GET /Genres/Create
		public IActionResult Create()
		{
			return View();
		}

		// POST /Genres/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(Genre genre)
		{
			if (!ModelState.IsValid)
			{
				return View();
			}
			await _service.InsertAsync(genre);

			return RedirectToAction(nameof(Index));
		}

		// GET Genres/Delete/x
		public async Task<IActionResult> Delete(int? id)
		{
			if (id is null) 
			{
				return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
			}
			var obj = await _service.FindByIdAsync(id.Value);
			if (obj is null)
			{
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }
			return View(obj);  
        }

	}
}
