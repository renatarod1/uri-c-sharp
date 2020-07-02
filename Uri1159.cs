using System; 

class Uri1159 {

    static void Main(string[] args) { 

		
		int x = Convert.ToInt32(Console.ReadLine());
		
		while (x != 0) {
						
			if (x % 2 != 0) {
				x = x + 1;
			}
			
			int soma = x + x + 2 + x + 4 + x + 6 + x + 8; 
			Console.WriteLine(soma);
			
			x = Convert.ToInt32(Console.ReadLine());
        }
    }
}