using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace T16CodBackEnd.Classes
{
    public static class Utils
    {

        public static void BarraCarregamento(string textoBarra)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write($"{textoBarra}");
            for (var contador = 0; contador < 3; contador++)
            {
                Thread.Sleep(500);
                Console.Write($".");
            }
            Console.ResetColor();
            Thread.Sleep(500);
            Console.Clear();
        }

        public static void VerificarPastaArquivo(string Caminho)
        {
            string pasta = Caminho.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            } 

            if (File.Exists(Caminho))
            {
                using (File.Create(Caminho)){}
            }

        }
    }
}