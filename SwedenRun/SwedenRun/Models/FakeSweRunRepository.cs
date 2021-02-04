using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwedenRun.Models
{
  public class FakeSweRunRepository : ISweRunRepository
  {

    /**
     *  RUNNER
     */
    public IQueryable<Runner> Runners => new List<Runner>
    {
      new Runner { RunnerId = "R001", Age = "27", Email = "alex@strand.com", Name = "Alexander Strand" },
      new Runner { RunnerId = "R002", Age = "55", Name = "Batman"},
      new Runner { RunnerId = "R003", Name = "Elon Musk"}
    }.AsQueryable<Runner>();

    public Runner GetRunnerDetails(string id)
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

    /**
     *  RUN
     */
    public IQueryable<Run> Runs => new List<Run>
    {
      new Run{ RunId = 1, RunnerId = "R001", Distance = 10, Time = "55:00", Date="2021-01-01"},
      new Run{ RunId = 2, RunnerId = "R001", Distance = 5.5, Time = "25:20", Date="2021-01-03"},
      new Run{ RunId = 3, RunnerId = "R001", Distance = 10, Time = "52:00", Date="2021-01-02"},
      new Run{ RunId = 4, RunnerId = "R002", Distance = 3, Time = "30:00", Date="2021-01-10"},
      new Run{ RunId = 5, RunnerId = "R002", Distance = 5, Time = "45:00", Date="2021-01-07"},
      new Run{ RunId = 6, RunnerId = "R003", Distance = 12, Time = "55:00", Date="2021-01-01"}
    }.AsQueryable<Run>();

    public IQueryable<Run> GetRunnerRuns(string id)
    {
      var runs = from run in Runs
                 where run.RunnerId.Equals(id)
                 select run;
      return runs;
    }
  }
}
