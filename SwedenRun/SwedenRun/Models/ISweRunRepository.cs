using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwedenRun.Models
{
  public interface ISweRunRepository
  {
    IQueryable<Runner> Runners { get; }
    Runner GetRunnerDetails(string id);
    bool SaveRunner(Runner runner);
    IQueryable<Run> Runs { get; }
    IQueryable<Run> GetRunnerRuns(string id);
  }
}
