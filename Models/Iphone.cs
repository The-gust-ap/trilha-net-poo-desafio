namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    //implementado
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        //implementado
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"{nomeApp} esta sendo instalado");
        }
    }
}