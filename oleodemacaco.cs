using System;
using static System.IO.File;
using System.Threading;
using System.Media;

namespace oleodemacaco
{
    class Program
    {
        public static void Imprimir() // Pega um arquivo de texto e depois imprime ele.
        {
			string macacoAscii = System.IO.File.ReadAllText(@"macacoascii.txt");
			Console.WriteLine(macacoAscii);
		}
        public static void Main(string[] args)
        {
			Console.Clear();
			Thread macacoSom = new Thread(ThreadSom); // Usa o Método abaixo e coloca ele numa Thread nova, para assim imprimir
													  // o texto e tocar um som ao mesmo tempo.
			macacoSom.Start();
			Imprimir();
			Console.WriteLine("Meia noite");
			
			Thread.Sleep(1600);
			
			Console.Clear();
			Imprimir();
			Console.WriteLine("Horário oficial");
			
			Thread.Sleep(1300);
			
			Console.Clear();
			Imprimir();
			Console.WriteLine("Do Óleo de Macaco");
			
			Thread.Sleep(2000);
			
			Console.Clear();
			Imprimir();
			
        }
        public static void ThreadSom() // Faz um tocador de som e executa o arquivo WAV, que no caso seria "macaco.wav"
        {
			SoundPlayer som = new SoundPlayer();
            som.SoundLocation = Environment.CurrentDirectory + "/macaco.wav";
			som.Play();
		}
    }
}
