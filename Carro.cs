using System.Threading;

namespace ExemploEvento1
{
    public class Carro
    {
        int qtdTanque = 0;

        public Carro(int qtdGasolina)
        {
            this.qtdTanque = qtdGasolina;
        }

        public void Ligar(){
            while(true){
                Thread.Sleep(1000);
                this.qtdTanque--;
                System.Console.WriteLine(this.qtdTanque.ToString());
                if(this.qtdTanque.Equals(0)){
                    this.TanqueVazio();
                    break;
                }
            }
        }

        public delegate void EventoCarro();
        
        public event EventoCarro TanqueVazio;
    }
}