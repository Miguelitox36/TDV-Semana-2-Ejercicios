using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDV_Semana_2_Ejercicios
{
    internal class Rectangle : Figure
    {
        protected double Base;
        protected double Height;

        public Rectangle(string name, double baseR, double widthR) : base(name)
        {
            this.Base = baseR;
            this.Height = widthR;
        }

        public override double CalculateArea()
        {
            return Base * Height;
        }
    }
}
