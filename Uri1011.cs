using System; 
using System.Globalization;

class Uri1011 {

    static void Main(string[] args) { 

        double raio = double.Parse(Console.ReadLine());
		double volume = (4.0/3) * 3.14159 * Math.Pow(raio, 3);
		Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
    }
}