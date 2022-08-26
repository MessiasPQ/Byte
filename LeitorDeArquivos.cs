using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank
{
    public class LeitorDeArquivos : IDisposable
    {
        public string Arquivo { get; }

        public LeitorDeArquivos(string arquivo){
            Arquivo = arquivo;
            //throw new FileNotFoundException();
            System.Console.WriteLine("Abrindo arquivo: " + arquivo);
        }

        public string LerProximaLinha(){
            System.Console.WriteLine("Lendo linha . . .");
            //throw new IOException();
            return "Linha do arquivo";
        }

        public void Dispose()
        {
            Console.WriteLine("Fechando arquivo.");
        }
    }
}