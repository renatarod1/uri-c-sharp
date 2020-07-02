using System; 
using System.Globalization;

class Uri1002 {

    static void Main(string[] args) { 

     double raio, area, n= 3.14159;
				
	raio = double.Parse(Console.ReadLine());
	area = n * (Math.Pow(raio, 2));
	Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

    }
}