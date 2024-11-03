using KurumsalTanıtım.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace KurumsalTanıtım.Controllers
{
    public class HizmetlerController : Controller
    {
        private readonly IHizmetlerRepository _hizmetlerRepository;

        public HizmetlerController(IHizmetlerRepository hizmetlerRepository)
        {
            _hizmetlerRepository = hizmetlerRepository;
        }

        public IActionResult Hizmetler()
        {
            var hizmetler = _hizmetlerRepository.GetAllHizmetler();
            return View("~/Views/Home/Hizmetler.cshtml", hizmetler);
        }

        public IActionResult GetImage(int id)
        {
            var hizmet = _hizmetlerRepository.GetHizmetById(id);
            if (hizmet == null || string.IsNullOrEmpty(hizmet.ImagePath))
            {
                return NotFound();
            }
            // Dosya yoluyla resmi göstermek için FileResult döndürülür
            var mimeType = "image/png"; // veya hizmet.ImageMimeType gibi bir alan kullanabilirsiniz
            return PhysicalFile(hizmet.ImagePath, mimeType);
        }
    }
}
