using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDV_Semana_2_Ejercicios
{
    internal class Circle : Figure
    {
        private double Radio;

        public Circle(string name, double radio) : base(name)
        {
            this.Radio = radio;
        }

        public override double CalculateArea()
        {
            return Radio * Radio * 3.14f;
        }
    }
}
