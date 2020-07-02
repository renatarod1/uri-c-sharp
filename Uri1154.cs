using System; 
using System.Globalization;

class Uri1154 {

    static void Main(string[] args) { 

        int cont = 0, somaIdades = 0;
		int idade = Convert.ToInt32(Console.ReadLine());
		
		while (idade >= 0){
			somaIdades += idade;
			cont++;
			idade = Convert.ToInt32(Console.ReadLine());
		}
		
		double media = (double) somaIdades / cont;
		Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
    }
}