using System; 

class Uri1101 {

    static void Main(string[] args) { 

       string s = Console.ReadLine();		
		string[] vectMN = s.Split(' ');
		
	    int M = Convert.ToInt32(vectMN[0]);
		int N = Convert.ToInt32(vectMN[1]);
		
		while(M > 0 && N > 0) {
			int maior = 0;
			int menor = 0;
			
			if (M > N) {
				maior = M;
				menor = N;
			} else {
				maior = N;
				menor = M;
			}
			
			int soma = 0;
			for (int i = menor; i <= maior; i++) {
				Console.Write(i + " ");
				soma += i;
			}
			Console.WriteLine("Sum="+soma);
			
			s = Console.ReadLine();		
			vectMN = s.Split(' ');
		
	    	M = Convert.ToInt32(vectMN[0]);
			N = Convert.ToInt32(vectMN[1]);
		}
    }
}