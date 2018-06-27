using System;
using System.Collections.Generic;
using System.Text;

namespace InteriorDesign
{
    public abstract class HouseLayout : ILayoutBuilder
    {
        protected abstract void FloorPlan();
        protected abstract void Flooring();
        protected abstract void Lighting();
        protected abstract void Decorating();
        public void Build()
        {
            FloorPlan();
            Flooring();
            Lighting();
            Decorating();
        }
    }
}
