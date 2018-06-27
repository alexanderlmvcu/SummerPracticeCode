using System;
using System.Collections.Generic;
using System.Text;

namespace Exercising
{
    public abstract class RunningExercise : ExerciseProcess
    {
        protected override void Exercise()
        {
            throw new NotImplementedException();
        }

        protected override void Prepare(int age)
        {
            if (age < 0) throw new ArgumentException();
            throw new NotImplementedException();
        }
    }
}
