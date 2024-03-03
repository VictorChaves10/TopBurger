using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TopBurgers.Areas.admin.Servicos;

namespace TopBurgers.Areas.admin.Controllers
{
    public class AdminRelatorioVendasController : Controller
    {
        private readonly RelatorioVendasService relatorioVendasService;

        public AdminRelatorioVendasController(RelatorioVendasService relatorioVendasService)
        {
            this.relatorioVendasService = relatorioVendasService;
        }

        [Area("admin")]
        [Authorize("Admin")]
        public IActionResult Index()
        {
            return View();
        }

        [Area("admin")]
        [Authorize("Admin")]
        public async Task<IActionResult> RelatorioVendasSimples(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }

            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");

            var resut = await relatorioVendasService.FindByDateAsync(minDate, maxDate);

            return View(resut);

        }
    }
}
