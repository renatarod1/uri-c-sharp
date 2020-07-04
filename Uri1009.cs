using System; 
using System.Globalization;

class Uri1009 {

    static void Main(string[] args) { 

        string nome = Console.ReadLine();
		double salario = double.Parse(Console.ReadLine()); 
		double totalVendas = double.Parse(Console.ReadLine()); 
		
		double total = salario + totalVendas * 0.15;
		Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
    }
}