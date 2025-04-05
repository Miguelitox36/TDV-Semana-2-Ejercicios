using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDV_Semana_2_Ejercicios
{
    internal class Triangle : Figure
    {
        private double Base;
        private double Height;

        public Triangle(string name, double baseT, double heightT) : base(name) 
        {
            this.Base = baseT;
            this.Height = heightT;
        }
        public override double CalculateArea()
        {
            return (Base*Height / 2);
        }
    }
}
