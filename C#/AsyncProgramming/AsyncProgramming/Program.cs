using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncProgramming
{
    class LentilSoup
    {
        public LentilSoup()
        {


        }
        public async Task<SoakedLentils> SoakLentils()
        {
            Console.WriteLine("Lentils Start");
            await Task.Delay(TimeSpan.FromSeconds(10));
            Console.WriteLine("Lentils Stop");
            return new SoakedLentils();
        }

        public ChoppedCarrots ChoppedCarrots()
        {
            Console.WriteLine("Carrots Start");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.WriteLine("Carrots End");
            return new ChoppedCarrots();
        }

        public ChopGarlic ChopGarlic()
        {
            Console.WriteLine("Garlic Start");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine("Garlic End");
            return new ChopGarlic();
        }

        public ChopCelery ChopCelery()
        {
            Console.WriteLine("Celery Start");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.WriteLine("Celery End");
            return new ChopCelery();
        }

        public SauteVegetables SauteVegetables(SoakedLentils lentils, ChoppedCarrots choppedCarrots, ChopGarlic chopGarlic, ChopCelery chopCelery)
        {
            Console.WriteLine("Vegetable Start");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.WriteLine("Vegetable End");
            return new SauteVegetables();
        }

        public BoilWater BoilWater()
        {
            Console.WriteLine("Water Start");
            Thread.Sleep(TimeSpan.FromSeconds(10));
            Console.WriteLine("Water End");
            return new BoilWater();
        }

        public CookSoup CookSoup(SauteVegetables sauteVegetables, BoilWater boilWater)
        {
            Console.WriteLine("Cook soup Start");
            Thread.Sleep(TimeSpan.FromSeconds(30));
            Console.WriteLine("Cook soup End");
            return new CookSoup();
        }

        public SlicedBread SliceBread()
        {
            Console.WriteLine("Slice bread Start");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.WriteLine("Slice bread End");
            return new SlicedBread();
        }

        public PreparedGarlicBread PreparedGarlicBread(SlicedBread slicedBread, ChopGarlic garlic)
        {
            Console.WriteLine("Prepared garlic bread Start");
            Thread.Sleep(TimeSpan.FromSeconds(10));
            Console.WriteLine("Prepared garlic bread End");
            return new PreparedGarlicBread();
        }

        public HotOven HotOven()
        {
            Console.WriteLine("Oven Start");
            Thread.Sleep(TimeSpan.FromSeconds(10));
            Console.WriteLine("Oven End");
            return new HotOven();
        }

        public ToastGarlicBreadInOven ToastGarlicBreadInOven(PreparedGarlicBread preparedGarlicBread, HotOven hotOven)
        {
            Console.WriteLine("Toasting Start");
            Thread.Sleep(TimeSpan.FromSeconds(10));
            Console.WriteLine("Toasting End");
            return new ToastGarlicBreadInOven();
        }

        public void Serve(CookSoup cookSoup, ToastGarlicBreadInOven toastGarlicBreadInOven)
        {


        }
    }

    class Program
    {
        static async Task Main(string[] args)
        {
            //Stopwatch stopwatch = Stopwatch.StartNew();
            //BaconEggs meal = new BaconEggs();

            //Task<string> task4 = meal.GetEggsFromFridge();
            //string eggs = await task4;            

            //// Send the order to start
            //// -----------------------------

            //Task task = meal.CookTheBacon();
            //Task task2 = meal.CookTheEggs();

            ////------------------------------

            ////Await the result
            ////------------------------------

            //await task;
            //await task2;

            ////------------------------------

            ////Both sending the order to start
            //// AND awaiting the result
            ////------------------------------

            //await meal.Serve();

            ////-------------------------------

            //Console.WriteLine("Elapsed duration: " + stopwatch.ElapsedMilliseconds);

            // CHALLENGE

            //Challenge: Lentil Soup
            //Create an application for preparing Lentil Soup.
            //Define methods for the following tasks where the method takes(X seconds) to complete:
            //Soak lentils(10 seconds)
            //Chop carrots(1 seconds)
            //Chop garlic(2 seconds)
            //Chop celery(1 seconds)
            //Saute vegetables(1 seconds)->depends on previous 4 methods completed.
            //Boil water(10 seconds)
            //Cook soup on stovetop(30 seconds)->depends on all previous methods completed.
            //Slice bread(1 seconds)
            //Add Garlic with Olive Oil to bread(5 seconds)->depends on Chop garlic
            //Preheat Oven(10 seconds)
            //Toast garlic bread in Oven(10 seconds)->depends on previous 4 methods completed.
            //Display to console the meal being prepared.
            //Display information for the start and end of each method.
            //The program should use System.Threading.Tasks namespace.
            //The program should not execute tasks that depend on other tasks until dependent tasks are completed.
            //MVP:
            //Prevent tasks that depend on other tasks from being executed using parameters.
            //Encapsulate this procedure using abstractions.
            //Find the optimal meal preparation and cooking time.

            // to use AWAIT Keyword:
            // => return type must be Task, async keyword, await keyword for task
            Stopwatch stopwatch = Stopwatch.StartNew();
            LentilSoup soup = new LentilSoup();
            Task<SoakedLentils> task = soup.SoakLentils();
            ChoppedCarrots carrots = soup.ChoppedCarrots();
            ChopGarlic garlic = soup.ChopGarlic();
            ChopCelery celery = soup.ChopCelery();

            SoakedLentils soakedLentils = await task;
            SauteVegetables sauteVegetables = soup.SauteVegetables(soakedLentils, carrots, garlic, celery);

            BoilWater boiledWater = soup.BoilWater();
            CookSoup cookedSoup = soup.CookSoup(sauteVegetables, boiledWater);

            SlicedBread slicedBread = soup.SliceBread();

            PreparedGarlicBread preparedGarlicBread = soup.PreparedGarlicBread(slicedBread, garlic);
            HotOven hotOven = soup.HotOven();
            ToastGarlicBreadInOven toastedGarlicBread = soup.ToastGarlicBreadInOven(preparedGarlicBread, hotOven);

            soup.Serve(cookedSoup, toastedGarlicBread);

            Console.WriteLine("Elapsed duration: " + stopwatch.ElapsedMilliseconds);

            
        }
    }
}
