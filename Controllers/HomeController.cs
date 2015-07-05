using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelService.Models;

namespace HotelService.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
// получаем данные из сервера
        [HttpGet]
        public ActionResult Registration()
        {
            ViewBag.Rooms = RoomRepository.GetRooms();
            return View();
        }
// отправляем данные на сервер
        [HttpPost]
        public ActionResult Registration(RegistrationForm model)
        {
            return View("Success", model);
        }

    }
}
