using System; 
using System.Globalization;

class Uri1006 {

    static void Main(string[] args) { 
double A, B, C, media;
		
		A = Convert.ToDouble(Console.ReadLine());
		B = Convert.ToDouble(Console.ReadLine());
		C = Convert.ToDouble(Console.ReadLine());
		
		media = (A * 2.0 + B * 3.0 + C * 5.0) / 10;
		Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
    }
}