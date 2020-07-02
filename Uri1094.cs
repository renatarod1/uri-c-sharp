using System; 
using System.Globalization;

class Uri1094 {

    static void Main(string[] args) { 

       	int n =  Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);

		int totC = 0;
		int totR = 0;
		int totS = 0;
		int totCobaias = 0;

		for (int i = 1; i <= n; i++) {
			
			string s = Console.ReadLine();		
			string[] vectQtdcobaiasTipo = s.Split(' ');
			
			
			int qtdCobaias = Convert.ToInt32(vectQtdcobaiasTipo[0]);
			char tipo = Convert.ToChar(vectQtdcobaiasTipo[1]);

			if (tipo == 'C') {
				totC += qtdCobaias;
			} else if (tipo == 'R') {
				totR += qtdCobaias;
			} else {
				totS += qtdCobaias;
			}

			totCobaias += qtdCobaias;
		}

		Console.WriteLine("Total: " + totCobaias + " cobaias");
		Console.WriteLine("Total de coelhos: " + totC);
		Console.WriteLine("Total de ratos: " + totR);
		Console.WriteLine("Total de sapos: " + totS);		
		Console.WriteLine(("Percentual de coelhos: " + ((double)totC / totCobaias * 100.0).ToString("F2", CultureInfo.InvariantCulture)) + " %");		
		Console.WriteLine(("Percentual de ratos: " + ((double)totR / totCobaias * 100.0).ToString("F2", CultureInfo.InvariantCulture)) + " %");		
		Console.WriteLine(("Percentual de sapos: " + ((double)totS / totCobaias * 100.0).ToString("F2", CultureInfo.InvariantCulture)) + " %");
    }

}