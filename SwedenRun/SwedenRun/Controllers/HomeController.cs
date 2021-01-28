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

    private ISweRunRepository repository;

    public HomeController(ISweRunRepository repo)
    {
      repository = repo;
    }

    public ViewResult Index()
    {
      return View();
    }

    public ViewResult AddRunner()
    {
      return View();
    }

    public ViewResult AllRunners()
    {
      return View(repository.Runners);
    }
  }
}
