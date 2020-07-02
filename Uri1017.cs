using System;
using System.Globalization;

class Uri1017 {

    static void Main(string[] args) { 

        int tempoGasto, velocidadeMedia, distancia;
	    double totalLitros;
		
		tempoGasto = int.Parse(Console.ReadLine()); 
		velocidadeMedia = int.Parse(Console.ReadLine()); 
		
		distancia = tempoGasto * velocidadeMedia;
		totalLitros = (double) distancia / 12;
		Console.WriteLine(totalLitros.ToString("F3", CultureInfo.InvariantCulture));
    }
}