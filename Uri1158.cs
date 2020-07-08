using System; 

class Uri1158 {

    static void Main(string[] args) { 

       int n = int.Parse(Console.ReadLine());
		
		for (int i=0; i<n; i++) {
			string leXY = Console.ReadLine();
			string[] XY = leXY.Split(' ');
			
			int x = int.Parse(XY[0]);
			int y = int.Parse(XY[1]);
			
			int soma = 0;
			int cont = 0;
			for (int j=x; cont<y; j++) {
				if (j % 2 != 0) {
					soma = soma + j;
					cont = cont + 1;
				}
			}
			
			Console.WriteLine(soma);
		}
    }
}