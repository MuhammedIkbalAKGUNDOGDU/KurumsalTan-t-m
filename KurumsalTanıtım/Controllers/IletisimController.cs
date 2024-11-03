using KurumsalTanıtım.Models.Entities;
using KurumsalTanıtım.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KurumsalTanıtım.Controllers
{
    public class IletisimController : Controller
    {
        private readonly IIletisimRepository _ıletisimRepository;
        private readonly ILogger<IletisimController> _logger;

        public IletisimController(IIletisimRepository ıletisimRepository, ILogger<IletisimController> logger)
        {
            _ıletisimRepository = ıletisimRepository;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View("~/Views/Home/Iletisim.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> Index(Iletisim ıletisimModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Veritabanına kaydetme işlemi
                    await _ıletisimRepository.AddIletisim(ıletisimModel);

                    // Başarılı bir şekilde kaydedildiğinde, TempData kullanarak mesaj gösterme
                    TempData["SuccessMessage"] = "İletişim formu başarıyla gönderildi.";
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "İletişim formu kaydetme hatası.");
                    ModelState.AddModelError("", "İletişim formu kaydedilirken bir hata oluştu. Lütfen daha sonra tekrar deneyin.");
                    return View(ıletisimModel);
                }
            }

            // Geçersiz model durumunda aynı sayfayı tekrar gösterme
            return View(ıletisimModel);
        }

        public async Task<IActionResult> GetIletisim()
        {
            _logger.LogInformation("Index action called.");

            IEnumerable<Iletisim> ıletisims;

            try
            {
                ıletisims = await _ıletisimRepository.GetAll();
                _logger.LogInformation("Iletisims successfully retrieved.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error occurred while retrieving employees: {ex.Message}");
                return View("Error"); // Hata sayfasına yönlendirme
            }

            return View("~/Views/Home/Iletisim.cshtml", ıletisims);
        }
    }
}
