using System;

namespace MorningRoutine
{
    public class EggCookProcess : CookProcess
    {
        protected override void ApplyFoodToCooker()
        {
            Console.WriteLine("Put eggs in skillet!");
        }

        protected override void TurnOffCooker()
        {
            Console.WriteLine("Turning off stove!");
        }

        protected override void TurnOnCooker()
        {
            Console.WriteLine("Turning on stove");
        }
    }
}
