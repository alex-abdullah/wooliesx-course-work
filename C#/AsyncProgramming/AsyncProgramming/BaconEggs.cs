using System;
using System.Threading;
using System.Threading.Tasks;
namespace AsyncProgramming
{
    public class BaconEggs
    {
        public BaconEggs()
        {


        }
        public async Task<string> GetEggsFromFridge()
        {
            Console.WriteLine("HeatOilPan Started");
            await Task.Delay(1000);
            Console.WriteLine("HeatOilPan Completed");

            return "Eggs";
        }
        public async Task CrackEggs()
        {
            Console.WriteLine("CrackEggs Started");
            await Task.Delay(500);
            Console.WriteLine("CrackEggs Completed");
        }
        public async Task CookTheBacon()
        {
            Console.WriteLine("CookTheBacon Started");
            await Task.Delay(10000);
            Console.WriteLine("CookTheBacon Completed");
        }
        public async Task CookTheEggs()
        {
            Console.WriteLine("CookTheEggs Started");
            await Task.Delay(5000);
            Console.WriteLine("CookTheEggs Completed");
        }

        public async Task Serve()
        {
            Console.WriteLine("Serve Started");
            await Task.Delay(1000);
            Console.WriteLine("Serve Completed");
        }

    }
}
