using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SwedenRun.Models
{
  public class Runner
  {
    public string RunnerId { set; get; }

    [Display(Name = "Name")]
    [Required(ErrorMessage = "The Name field is required.")]
    public string Name { set; get; }

    [Display(Name = "Email", Prompt = "name@example.com")]
    [Required(ErrorMessage = "The Email field is required.")]
    public string Email { set; get; }

    [Display(Name = "Age", Prompt = "Select")]
    public string Age { set; get; }

  }
}
