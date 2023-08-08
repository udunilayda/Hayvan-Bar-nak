using Hayvan_Barınak.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hayvan_Barınak.Controllers
{
    public class basvuruController1 : Controller
    {
        public IActionResult BasvuruYap()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> BasvuruYap(basvuru k, string ReturnUrl)
        {


            return View();
        }
    }
}
