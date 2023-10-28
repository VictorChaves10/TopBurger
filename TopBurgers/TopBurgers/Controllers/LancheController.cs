using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System;
using TopBurgers.Repositories.Interfaces;
using TopBurgers.ViewModels;

namespace TopBurgers.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
            //var lanches = _lancheRepository.Lanches;
            //return View(lanches);

            var lancheListViewModel = new LancheListViewModel();
            lancheListViewModel.Lanches = _lancheRepository.Lanches;
            lancheListViewModel.CategoriaAtual = "Categoria atual";

            return View(lancheListViewModel);
        }
    }
}
