namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        //implementado as propriedades que faltavam no diagrama
        public string Numero { get; set; }
        protected string Modelo{ get; }
        protected string Imei{ get; }
        protected int Memoria{ get; }
        //implementado o resto das propriedades no construtor
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}