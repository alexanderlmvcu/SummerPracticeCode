using System;
using System.Collections.Generic;
using System.Text;

namespace Exercising
{
    class WalkingExercise : ExerciseProcess
    {
        protected override void Exercise()
        {
            Console.WriteLine("Walk to store and back.");
        }

        protected override void Finish()
        {
            Console.WriteLine("Shower.");
        }

        protected override void Prepare()
        {
        }
    }
}
