using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filmes.Controllers
{
    public class HomeController : Controller
    {
        public bool ClienteLogado
        {
            get
            {
                if (TempData["ClienteLogado"] != null)
                {
                    TempData.Keep("ClienteLogado");
                    return (bool)TempData["ClienteLogado"];
                }
                else
                    return false;
            }
            set
            {
                TempData["ClienteLogado"] = value;
            }
        }
        public ActionResult Index()
        {
            if (ClienteLogado)
            {
                return RedirectToAction("Index", "Filmes");
            }
            else
            {
                return RedirectToAction("Login", "Filmes");
            }
        }
    }
}