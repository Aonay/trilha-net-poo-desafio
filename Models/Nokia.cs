namespace DesafioPOO.Models
{
    
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modeloCelular, string imeiCelular, int memoriaCelular) : base(numero, modeloCelular, imeiCelular, memoriaCelular)
        {
        }

        
        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"Aplicativo {nomeApp} instalado em seu dispositivo NOKIA com sucesso");
        }
    }
}