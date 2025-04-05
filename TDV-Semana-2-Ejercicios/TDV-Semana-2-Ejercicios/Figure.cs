using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDV_Semana_2_Ejercicios
{
    internal class Figure
    {
        public string name;

        public Figure(string name)
        {
            this.name = name;
        }
    

    public virtual double CalculateArea();

    public virtual string GetInfo()
        {
            return $"Figura: {name} - Área:{CalculateArea():F2}";
        }

    }
}
