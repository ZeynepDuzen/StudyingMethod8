using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyingMethod8
{
    internal class Program
    {
        static void Travel(string travel = " new country")
        {
            Console.WriteLine("to see a" + " " + travel);
        }
        static void Main(string[] args)
        {
            Travel();
            Travel("beautiful sea");
            Travel("cultural places");
             
            Console.Read();

                }
    }
}
