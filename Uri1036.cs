using System;
using System.Globalization;

class Uri1036 {

    static void Main(string[] args) { 
        string leABC = Console.ReadLine();
		string[] ABC = leABC.Split(' ');
		
		double a = Convert.ToDouble(ABC[0].ToString());
		double b = Convert.ToDouble(ABC[1].ToString());
		double c = Convert.ToDouble(ABC[2].ToString());
		
		double delta = b * b - 4.0 * a * c;
		
		if (a == 0 || delta < 0.0) {
			Console.WriteLine("Impossivel calcular");
		} else {
			double r1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
			double r2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
			Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
			Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
		}
    }
}