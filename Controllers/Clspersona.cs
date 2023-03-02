using Laboratorio1_Fabricio_Alberto_Marquez_Mejia.Models;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;

namespace Laboratorio1_Fabricio_Alberto_Marquez_Mejia.Controllers

{
    public class Clspersona
    {
        persona persona = new persona();    
        public void CalcularIMC(persona persona)
        {
            double pro = persona.peso/Math.Pow(persona.altura, 2);

            if (pro < 24)
            {
                Console.WriteLine("Peso ideal");
            }
             else if (pro>25){
                Console.WriteLine("Tiene sobre peso");
            }
        }
        public void esMayorDeEdad(persona persona) {
            double edad = persona.edad;
        if (edad> 18)
            {
                Console.WriteLine("Es mayor de edad");
            }
        else {
                Console.WriteLine("Es menor de edad");
                    }
         }
    }
}
