using System; 
using System.Globalization;

class Uri1012 {

    static void Main(string[] args) { 
        string leABC = Console.ReadLine();
		string[] ABC = leABC.Split(' ');
		double A = Convert.ToDouble(ABC[0]);
		double B = Convert.ToDouble(ABC[1]);
		double C = Convert.ToDouble(ABC[2]);

		double triangulo =  (A * C) / 2;
		Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
		
		double circulo = 3.14159 * Math.Pow(C, 2);
		Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
		
		double trapezio = ((A + B) * C) / 2;
		Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
		
		double quadrado = B * B;
		Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
		
		double retangulo = A * B;
		Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));		
    }
}