using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smartphone.Models
{
    public abstract class Smartphone
    {   
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }


        public void Ligar(int contato) {
            Console.WriteLine($"Ligando para {contato}");
        }

        public void ReceberLigacao() {
            Console.WriteLine("Recebendo ligação.");
        }

        public abstract void InstalarApp(string nomeApp);
    }
}