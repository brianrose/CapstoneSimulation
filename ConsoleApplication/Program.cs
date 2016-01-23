using System;
using System.Linq;
using Simulation;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int wavelength; // Arg 0

                if (!args.Any())
                {
                    // TODO: Default behavior or prompt
                    wavelength = 780; // default for now
                }
                else
                {
                    if (!int.TryParse(args?[0], out wavelength))
                    {
                        throw new ArgumentException(
                            "Wavelength could not be parsed. Please enter a valid wavelength in nm.", nameof(wavelength));
                    }
                }

                var result = new Simulation.Simulation(wavelength).Simulate();

                if (result)
                {
                    Console.WriteLine("Simulation completed successfully.");
                }
                else
                {
                    Console.WriteLine("There was a problem running a simulation.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was an exception.");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("ENTER to exit.");
                Console.ReadLine();
            }
        }
    }
}
