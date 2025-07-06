using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c4learning
{
  public interface ILeasson
    {
        string Name { get; }
        string Description { get; }
        void RunAll();

    }
}
