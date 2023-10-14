using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadora
    {
        public string RealizarOperacion(int opcion, double num1, double num2)
        {
            double resultado = double.NaN;
            switch (opcion)
            {
                case 1: // Suma
                    resultado = num1 + num2;
                    break;
                case 2: // Resta
                    resultado = num1 - num2;
                    break;
                case 3: // Multiplicación
                    resultado = num1 * num2;
                    break;
                case 4: // División
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        return "Error al intentar dividir x cero";
                    }
                    break;
                default:
                    return "Opcion No Valida";
                    break;
            }

            return $"{resultado}";
        }
    }
}
