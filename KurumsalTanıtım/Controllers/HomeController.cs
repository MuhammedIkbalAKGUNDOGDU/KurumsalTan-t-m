using KurumsalTanıtım.Models;
using KurumsalTanıtım.Models.Entities;
using KurumsalTanıtım.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;

namespace KurumsalTanıtım.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHizmetAlRepository _hizmetAlRepository;

        public HomeController(ILogger<HomeController> logger, IHizmetAlRepository hizmetAlRepository)
        {
            _logger = logger;
            _hizmetAlRepository = hizmetAlRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HizmetAl()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> HizmetAl(HizmetAl hizmetAl)
        {
            if (ModelState.IsValid)
            {
                await _hizmetAlRepository.AddHizmetAl(hizmetAl);
                ViewBag.SuccessMessage = "Talep başarı ile alındı!";
                return View();
            }
            return View(hizmetAl);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
