using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    public interface IQuittable
    {
        // This method must be implemented by any class that inherits this interface
        void Quit();
    }
}
