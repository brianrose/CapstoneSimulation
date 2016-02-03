using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationEngine
{
    public class Converter : IConverter
    {
        public TimeSpan ParseTimeSpan(string s)
        {
            double time = 0;
            if (s.Contains("e"))
            {
                var split = s.Split('e');
                time = (double.Parse(split[0])*Math.Pow(10, double.Parse(split[1])));
            }
            return TimeSpan.FromSeconds(time);
        }
    }
}
