using System;
using System.IO;
using System.Threading.Tasks;
using Ketchup.Pizza.DB;
using Ketchup.Pizza.Models;

namespace Ketchup.Pizza.Services
{
  public interface ICoaliter
  {
    CoaliteResource Get();
    CoaliteResource Action(CoaliteActionRequest coaliteActionRequest);
    CountResource Count();
  }
}