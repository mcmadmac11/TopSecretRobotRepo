using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    class Program
    {
        static void Main(string[] args)
        {
            HyperDrive hd = new HyperDrive("", 100, 4, true);
            Destination newDestination = new Destination();
            newDestination.getDestination();


        }   
    }
}
