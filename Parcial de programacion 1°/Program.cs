namespace Parcial_de_programacion_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double Radio = crearmetodo("Ingrese el valor del Radio");
                double Altura = crearmetodo("Ingrese el valor de la Altura");
                double Base = Math.PI * Math.Pow(Radio, 2);
                int contador = 1;
                double Volumen = CrearVolumen(Base, Altura);
                double Area = CrearArea(Radio, Altura);

                if (Radio > 0 && Altura > 0)
                {
                    Console.WriteLine($"El Area del Cilindro es {Area} ");
                    Console.WriteLine($"El Volumen del Cilindro es {Volumen}");
                    contador = contador + 1;
                    Console.WriteLine($"La cantidad de Cilindros es { contador }");
                    
                }
                else
                {
                    Console.WriteLine("los numeros de Radio o Altura no pueden ser 0");
                }

            } while (true);
        }

        private static double CrearArea(double radio, double altura) => 2 * Math.PI * radio * (radio * altura);
        

        private static double CrearVolumen(double Base, double altura) =>Base * altura;
        
        private static double CrearBase(double Radio) => Math.PI * Math.Pow(Radio, 2);
        

        private static double crearmetodo(string Mensaje)
        {
            double nro = 0;
            do
            {
                Console.Write(Mensaje);
                string strconsole = Console.ReadLine();
                if (!double.TryParse(strconsole, out nro))
                {
                    Console.WriteLine("Número mal ingresado");
                }
                else
                {
                    break;
                }

            } while (true);
            return nro;
        }
    }
}