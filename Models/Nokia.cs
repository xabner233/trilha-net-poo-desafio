using System.Diagnostics;
using System.Globalization;
using System.Xml.Linq;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {

        public Nokia(string numero, string modelo, int iMEI, int memoria) : base(numero, modelo, iMEI, memoria) 
        {
        
        }
        
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando aplicativo "
                 + nomeApp
                 + " no Nokia");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}