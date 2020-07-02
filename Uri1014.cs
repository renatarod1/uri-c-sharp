using System; 
using System.Globalization;

class Uri1014 {

    static void Main(string[] args) { 

       int X;
		double Y, total;

		X = int.Parse(Console.ReadLine()); 
		Y = double.Parse(Console.ReadLine()); 

		total = X / Y;
		Console.WriteLine((total.ToString("F3", CultureInfo.InvariantCulture)) + " km/l");
    }
}