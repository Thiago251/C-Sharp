using System;
   namespace Curso {
      class Program {
        static void Main(string[] args) {
			Console.WriteLine("Qual o hora atual?");
			int hora = int.Parse(Console.WriteLine());
			
			if (hora < 12){
				Console.WriteLine("Bom dia");
				
			}
			if (hora >= 12 && hora < 18) {
			    Console.WriteLine("Boa Tarde");
			}
			
			if (hora >= 18) {
				Console.WriteLine("Boa Noite");
			}
		}
	  }	