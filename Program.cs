using System;

namespace Aula20
{
    class Program
    {
        static void Main(string[] args)

        {
            System.Console.WriteLine("=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Cliente Gabriel = new Cliente("Gabriel", "São Paulo");
            System.Console.WriteLine("Cliente:");
            System.Console.WriteLine(Gabriel.Nome);
            System.Console.WriteLine("Ele mora em:");
            System.Console.WriteLine(Gabriel.EnderecoAtual);
            System.Console.WriteLine("=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Restaurante Bom = new Restaurante("Bom" , "Penha");
            System.Console.WriteLine("O nome do Restaurante é:");
            System.Console.WriteLine(Bom.NomeFantasia);
            System.Console.WriteLine("E ele fica na :");
            System.Console.WriteLine(Bom.Endereco);
            System.Console.WriteLine("=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Pedido Novo = new Pedido("Cachorro Quente", "Gabriel","Bom","Dinheiro",true);
            System.Console.WriteLine("Pedido foi de: ");
            System.Console.WriteLine(Novo.Itens);
            System.Console.WriteLine("Pelo Cliente :");
            System.Console.WriteLine(Novo.Clientes);
            System.Console.WriteLine("Do restaurante: ");
            System.Console.WriteLine(Novo.Restaurante);
            System.Console.WriteLine("Vai ser Pago em: ");
            System.Console.WriteLine(Novo.FormaDePGTO);
            System.Console.WriteLine("Pedido Foi Pago: ");
            System.Console.WriteLine(Novo.PedidoPago);
            System.Console.WriteLine("=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            
        }
    }
}
