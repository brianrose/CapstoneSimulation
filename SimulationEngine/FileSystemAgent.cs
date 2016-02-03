using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationEngine
{
    public class FileSystemAgent : IFileSystemAgent
    {
        public bool CheckMesh(string directory)
        {
            throw new NotImplementedException();
        }

        public void CreateMesh(string directory)
        {
            throw new NotImplementedException();
        }

        public void CreateSimulationEnvironment(string directory)
        {
            throw new NotImplementedException();
        }

        public void RunSimulation(string directory)
        {
            throw new NotImplementedException();
        }

        public void WriteInput(string file, int line, int position, string data)
        {
            throw new NotImplementedException();
        }

        public string ReadInput(string file, int line, int position)
        {
            throw new NotImplementedException();
        }
    }
}
