using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwedenRun.Models
{
  public class Run
  {
    public int RunId { set; get; }

    public double Distance { set; get; }
    public string Time { set; get; }

    public string RunnerId { set; get; }
  }
}
