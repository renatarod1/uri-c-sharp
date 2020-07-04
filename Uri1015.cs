using System; 
using System.Globalization;

class Uri1015 {

    static void Main(string[] args) { 

        string lePonto1 = Console.ReadLine();
		string lePonto2 = Console.ReadLine();
		
		string[] ponto1 = lePonto1.Split(' ');	
		string[] ponto2 = lePonto2.Split(' ');
		
		double x1, y1, x2, y2, distancia;

		x1 = Convert.ToDouble(ponto1[0]);
		y1 = Convert.ToDouble(ponto1[1]);

		x2 = Convert.ToDouble(ponto2[0]);
		y2 = Convert.ToDouble(ponto2[1]);

		distancia = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
		Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
    }
}