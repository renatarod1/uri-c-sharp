using System; 
using System.Globalization;

class Uri1079 {

    static void Main(string[] args) { 

        int n = Convert.ToInt32(Console.ReadLine());
		
		for (int i = 0; i < n; i++) { 
			string s = Console.ReadLine();
			string[] notas = s.Split(' ');			
			double nota1 = Convert.ToDouble(notas[0]);
		 	double nota2 = Convert.ToDouble(notas[1]);
		 	double nota3 = Convert.ToDouble(notas[2]);
		 	double media = (nota1 * 2.0 + nota2 * 3.0 + nota3 * 5.0) / 10.0;
		 	Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
		}
    }
}