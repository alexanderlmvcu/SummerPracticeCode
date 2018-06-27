using System;
using System.Collections.Generic;
using System.Text;

namespace Exercising
{
    public abstract class ExerciseProcess
    {
        protected abstract void Prepare();
        protected abstract void Exercise();
        protected virtual void Finish()
        {
            Console.WriteLine("Generic FINISH");
        }
        public void Go()
        {
            Prepare();
            Exercise();
            Finish();
        }
    }
}
