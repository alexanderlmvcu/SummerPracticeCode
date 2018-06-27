using System;

namespace MorningRoutine
{
    class Program
    {
        static void Main(string[] args)
        {
            var oatmealProcess = new OatmealCookProcess();
            var eggProcess = new EggCookProcess();

            oatmealProcess.Cook();
            eggProcess.Cook();

            Console.ReadKey();
        }
    }
}
