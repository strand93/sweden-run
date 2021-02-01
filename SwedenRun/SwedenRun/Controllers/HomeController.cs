using Microsoft.AspNetCore.Mvc;
using SwedenRun.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwedenRun.Controllers
{
  public class HomeController : Controller
  {
    public ViewResult Index()
    {
      return View();
    }
  }
}
