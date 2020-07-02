using System; 
using System.Globalization;

class Uri1005 {

    static void Main(string[] args) { 

       double A, B;
		
		A = Convert.ToDouble(Console.ReadLine());
		B = Convert.ToDouble(Console.ReadLine());
		
		double media = (A * 3.5 + B * 7.5) / 11.0;
		Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));
    }
}