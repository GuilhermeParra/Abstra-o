using System;

namespace Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoCredito visa = new CartaoCredito();
            visa.limite = 3000f;

            Console.WriteLine("Quanto deseja acrescentar de limite?");
            float acrescimo = float.Parse(Console.ReadLine());
            visa.AumentarLimite(acrescimo);
        
            Console.WriteLine("Novo limite R$"+visa.limite);

            System.Console.WriteLine("Digite a data do pagamento");
            visa.data = DateTime.Parse(Console.ReadLine());
            System.Console.WriteLine("Data: "+visa.data);
            
            //Cartao 2
            /*
            CartaoCredito elo = new CartaoCredito();
            elo.limite = 1500f;

            Console.WriteLine("Quanto deseja acrescentar de limite?");
            float acrescimo = float.Parse(Console.ReadLine());
            visa.AumentarLimite(acrescimo);
            Console.WriteLine("Novo limite R$"+elo.limite);*/

        }
    }
}
