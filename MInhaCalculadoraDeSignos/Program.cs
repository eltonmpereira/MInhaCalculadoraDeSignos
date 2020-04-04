using System;

namespace MinhaCalculadoraDeSignos
{
    class Program
    {
        static void Main(string[] args)
        {
            string dia;
            string mes;

            Console.WriteLine("Qual o dia do nascimento? (dd)");
            dia = Console.ReadLine();

            Console.WriteLine("Qual o mes do Nascimento? (mm)");
            mes = Console.ReadLine();

            int diaInt = 0;
            int mesInt = 0;

            try
            {
                diaInt = Convert.ToInt32(dia);
                mesInt = Convert.ToInt32(mes);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                Environment.Exit(1);

            }
            InterpretadorSigno interpretador = new InterpretadorSigno();
            Signo signo = interpretador.Interpretar(diaInt, mesInt);

            if(signo != null)
            {
                Console.WriteLine("Seu signo é: " + signo.nome + ", " + signo.caracteristicas);
                
            }
            else
            {
                Console.WriteLine("Não foi possivel determinar seu signo, tente novamente.");
                
            }
            Console.ReadLine();

        }
    }
}
