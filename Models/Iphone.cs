namespace DesafioPOO.Models
{
    
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modeloCelular, string imeiCelular, int memoriaCelular) : base(numero, modeloCelular, imeiCelular, memoriaCelular)
        {
            
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"Aplicativo {nomeApp} instalado instalado em seu dispositivo IPHONE com sucesso");
        }
    }
}