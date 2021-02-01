using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwedenRun.Models;

namespace SwedenRun.Controllers
{
  public class RunnerController : Controller
  {
    private ISweRunRepository repository;

    public RunnerController(ISweRunRepository repo)
    {
      repository = repo;
    }

    public ViewResult AddRunner()
    {
      return View();
    }

    public ViewResult AllRunners()
    {
      return View(repository.Runners);
    }

    public ViewResult RunnerDetail(int id)
    {
      return View(repository.GetRunnerDetails(id));
    }
  }
}
