using System; 
using System.Globalization;

class Uri1040 {

    static void Main(string[] args) { 

       string leNotas = Console.ReadLine();
		string[] notas = leNotas.Split(' ');
		
		
		double n1 = double.Parse(notas[0]);
		double n2 = double.Parse(notas[1]);
		double n3 = double.Parse(notas[2]);
		double n4 = double.Parse(notas[3]);
		
		double media = ((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1)) / 10;
		
		media = Math.Truncate(media * 100) / 100;
		
		Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
		
		
		if (media >= 7) {
			Console.WriteLine("Aluno aprovado.");
		} else if (media < 5) {
			Console.WriteLine("Aluno reprovado.");
		} else {
			Console.WriteLine("Aluno em exame.");
			double notaExame = float.Parse(Console.ReadLine());
			Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));
			double mediaFinal = (notaExame + media) / 2;
			if (mediaFinal >= 5) {
				Console.WriteLine("Aluno aprovado.");
			} else {
				Console.WriteLine("Aluno reprovado.");
			}
			Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
		}
    }
}