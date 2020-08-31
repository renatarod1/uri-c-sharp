using System;
using System.Globalization;

class URI1064 {

    static void Main(string[] args) { 
        double[] vetValoresEntrada = new double[6];
		
		for (int i = 0; i <= 5; i++){
			vetValoresEntrada[i] = double.Parse(Console.ReadLine());
		}		
		 	
		int count = 0;
		double soma = 0.0;
		
		for (int i = 0; i <= 5; i++){
			if (vetValoresEntrada[i] > 0){
				count = count + 1;		
				soma = soma + vetValoresEntrada[i];
			}			
			
		}		
		double media = soma / count;
		Console.WriteLine(count +" valores positivos");
		Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
    }
}