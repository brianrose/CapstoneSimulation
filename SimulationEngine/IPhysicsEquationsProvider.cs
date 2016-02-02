using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationEngine
{
    public interface IPhysicsEquationsProvider
    {
        int WavelengthToTimeStep(int wavelength);
        int PowerToPhotonsPerSecond(int power);
    }
}
