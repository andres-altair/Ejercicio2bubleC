using Ejercicio2bubleC;
using Ejercicio2bubleC.Servicios;

namespace Ejercicio2bubleC
{
    class program
    {
        /// <summary>
        /// metodo por donde entra la aplicacion
        /// </summary>
        /// <param name="args"></param>
        static  void Main(string[] args)
        {
            pedirI pI = new pedirC();
            double pri = pI.pedir();
            int seg = int.(pI.pedir());

        }
    }
}