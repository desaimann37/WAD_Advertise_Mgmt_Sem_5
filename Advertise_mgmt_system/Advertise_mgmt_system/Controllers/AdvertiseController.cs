using Microsoft.AspNetCore.Mvc;

namespace Advertise_mgmt_system.Controllers
{
    public class AdvertiseController: Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();  
        }

    }
}
