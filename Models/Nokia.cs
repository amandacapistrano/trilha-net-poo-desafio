namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
            public Nokia(string numero, string modelo, string imei, int memoria) : base( numero,  modelo,  imei, memoria){
            
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string app){
            Console.WriteLine($"Instalando {app} no Nokia.");
        }
    }
}