using System; 

class URI1144 {

    static void Main(string[] args) { 

        int n =  int.Parse(Console.ReadLine());
		
		for (int i = 1; i <= n; i++) {
			int segundo = i * i;
			int terceiro = i * i * i;
			Console.WriteLine("{0} {1} {2}", i, segundo, terceiro);
			Console.WriteLine("{0} {1} {2}", i, segundo + 1, terceiro + 1);
        }
    }
}