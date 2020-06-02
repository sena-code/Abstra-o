using System;

namespace Abstração
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaodeCredito visa = new CartaodeCredito();
            CartaodeDebito nubank = new CartaodeDebito();



            System.Console.WriteLine("Digite a data do pagamento do Cartão de Crédito:");
            visa.data = DateTime.Parse (Console.ReadLine() );
            System.Console.WriteLine("Data digitada:" +visa.data);

            System.Console.WriteLine("Digite o Valor que deseja transferir:");
            nubank.valor = float.Parse (Console.ReadLine() );
            System.Console.WriteLine( " O valor de " +nubank.valor + "R$ foi tranfirido" );

            System.Console.WriteLine("Deseja pagar o titulo com o cartão de débito ?");
            nubank.titulodebito = Boolean.Parse(Console.ReadLine());
            System.Console.WriteLine( nubank.Pagardebitotitulo());


            





        }
    }
}
