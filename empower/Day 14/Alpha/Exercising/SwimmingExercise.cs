using System;
using System.Collections.Generic;
using System.Text;

namespace Exercising
{
    public class SwimmingExercise : ExerciseProcess
    {
        protected override void Exercise()
        {
            Console.WriteLine("Swimming laps!")
        }

        protected override void Finish()
        {
            Console.WriteLine("Dry off.")
        }

        protected override void Prepare()
        {
            Console.WriteLine("Put on swimming suit");
            Console.WriteLine("Stretch.");
        }
    }
}
