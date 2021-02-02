using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwedenRun.Models
{
  public class FakeSweRunRepository : ISweRunRepository
  {
    public IQueryable<Runner> Runners => new List<Runner>
    {
      new Runner { RunnerId = 1, Age = "27", Email = "alex@strand.com", Name = "Alexander Strand" },
      new Runner { RunnerId = 2, Age = "55", Name = "Batman"},
      new Runner { RunnerId = 3, Name = "Elon Musk"}
    }.AsQueryable<Runner>();

    public Runner GetRunnerDetails(int id)
    {
      return Runners.Where(runner => runner.RunnerId.Equals(id)).First();
    }

    public bool SaveRunner(Runner runner)
    {
      //If runner does not exists, add to database
      if(!(Runners.Any(r => r.RunnerId == runner.RunnerId)))
      {
        //Runners.Add(runner);
      }

      return true;
    }
  }
}
