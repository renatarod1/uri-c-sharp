using System;
using System.Globalization;

class Uri1048 {

    static void Main(string[] args) { 
    double reajuste, percentual, novoSalario;
		
	double salario = double.Parse(Console.ReadLine());
		
	if (salario <= 400.00) {			
		percentual = 15.0;
	} else if (salario <= 800.00) {
		percentual = 12.0; 
	} else if (salario <= 1200.00) {
		percentual = 10.0;
	} else if (salario <= 2000.00) {
		percentual = 7.0;
	} else {
		percentual = 4.0;
	}
		
	reajuste = salario * percentual /100.0;
	novoSalario = salario + reajuste;
	
	Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
	Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
	Console.WriteLine("Em percentual: " + percentual.ToString("F0", CultureInfo.InvariantCulture) + " %");
    }
}