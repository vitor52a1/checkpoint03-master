using CP3.MVC.Application.Dtos;
using CP3.MVC.MVC.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CP3.MVC.Presentation.Controllers
{
    public class BarcoController : Controller
    {
        private readonly IBarcoApplicationService _applicationService;

        public BarcoController(IBarcoApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var Barcos = _applicationService.ObterTodosBarcos();

            return View(Barcos);
        }


        [HttpGet]
        public IActionResult Details(int? id)
        {
            var Barcos = _applicationService.ObterBarcoPorId(id ?? 0);

            return View(Barcos);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(BarcoDto model)
        {
            if (ModelState.IsValid)
            {
                _applicationService.AdicionarBarco(model);

                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var Barcos = _applicationService.ObterBarcoPorId(id ?? 0);

            return View(Barcos);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(BarcoEditDto model)
        {
            if (ModelState.IsValid)
            {
                _applicationService.EditarBarco(model.Id, model);

                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }


        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var Barcos = _applicationService.ObterBarcoPorId(id ?? 0);

            return View(Barcos);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult DeleteForm(int id)
        {
            var Barcos = _applicationService.RemoverBarco(id);

            if (Barcos is not null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

    }
}
