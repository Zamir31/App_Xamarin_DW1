using System;
using System.Collections.Generic;
using System.Text;

namespace App_Prueba.Models
{
    public class Expresion
    {
        public int num1  { get; set; }

        public int num2 { get; set; }

        public int resultado { get; set; }


        public string sumar()
        {
            resultado = num1 + num2;
            return resultado.ToString();
        }

        public string restar()
        {
            resultado = num1 - num2;
            return resultado.ToString();
        }

        public string multiplicar()
        {
            resultado = num1 * num2;
            return resultado.ToString();
        }

        public string dividir()
        {
            resultado = num1 / num2;
            return resultado.ToString();
        }
    }
}
