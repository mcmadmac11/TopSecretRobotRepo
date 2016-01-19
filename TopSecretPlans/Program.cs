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
            ReactorCore reactorCore = new ReactorCore(188, 90, 5, 90, 75, 50, 50);
            
            reactorCore.EvasionCheck(188, 90, 5, 90, 75, 50, 50);

            



        }
    }
}
