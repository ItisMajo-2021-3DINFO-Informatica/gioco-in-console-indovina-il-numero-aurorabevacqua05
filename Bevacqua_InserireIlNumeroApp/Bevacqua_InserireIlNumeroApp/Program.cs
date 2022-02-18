using System;

namespace Bevacqua_InserireIlNumeroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Random Num = new Random();
            int numeroCasuale = Num.Next(1, 100 );
            int tentativi = 0;
            int numeroTentativo;
            Console.WriteLine("Scrivi un numero tra 1 e 100");
            while (tentativi<=100)
            {
               
                numeroTentativo = Convert.ToInt32(Console.ReadLine());
                tentativi++;
                if (numeroTentativo > numeroCasuale)
                {
                    Console.WriteLine("SBAGLIATO! Il numero da indovinare è più basso");
                }
                else if(numeroTentativo < numeroCasuale)
                {
                    Console.WriteLine("SBAGLIATO! Il numero da indovinare è più alto");
                }
                else
                {
                    Console.WriteLine("GIUSTO! Hai indovinato il numero");
                    Console.WriteLine($"Il numero era {numeroCasuale}");
                    Console.WriteLine($"Il numero di tentativi è stato {tentativi}");
                }
            
            }
        
        
        }
    }
}
