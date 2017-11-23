using System;

namespace ExemploEvento1
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro(10);
            carro.TanqueVazio += new Carro.EventoCarro(tanque_vazio);
            carro.TanqueVazio += new Carro.EventoCarro(va_abastecer);
            
            carro.Ligar();
        }

        private static void tanque_vazio()
        {
            System.Console.WriteLine("Tanque Vazio!");
        }2

        public static void va_abastecer(){
            System.Console.WriteLine("Posto Ipiranga!");
        }
    }
}
