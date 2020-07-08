using System; 

class Uri1131 {

    static void Main(string[] args) { 

		int novoGrenal = 1;
		int vitoriasInter = 0;
		int vitoriasGremio = 0;
		int empates = 0;

		while (novoGrenal == 1) {
			string gols = Console.ReadLine();		
			string[] golsInterGremio = gols.Split(' ');
			int golsInter = int.Parse(golsInterGremio[0]);
			int golsGremio = int.Parse(golsInterGremio[1]);
			
			if (golsInter > golsGremio) {
				vitoriasInter = vitoriasInter + 1;
			} else if (golsGremio > golsInter) {
				vitoriasGremio = vitoriasGremio + 1;
			} else {
				empates = empates + 1;
			}
			
			Console.WriteLine("Novo grenal (1-sim 2-nao)");
			novoGrenal = int.Parse(Console.ReadLine());
		}
		
		int total = vitoriasInter + vitoriasGremio + empates;
		
		Console.WriteLine(total +" grenais");
		Console.WriteLine("Inter:"+ vitoriasInter);
		Console.WriteLine("Gremio:"+ vitoriasGremio);
		Console.WriteLine("Empates:"+ empates);
		
		if (vitoriasInter > vitoriasGremio) {
			Console.WriteLine("Inter venceu mais");
		} else if (vitoriasGremio > vitoriasInter) {
			Console.WriteLine("Gremio venceu mais");
		} else {
			Console.WriteLine("Nao houve vencedor");
		}
    }
}