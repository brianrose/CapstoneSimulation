using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationEngine
{
    public interface IFileSystemAgent
    {
        bool CheckMesh(string directory);
        void CreateMesh(string directory);
        void RunSimulation(string directory);
        void WriteInput(string file, int line, int position, string data);
        string ReadInput(string file, int line, int position);
    }
}
