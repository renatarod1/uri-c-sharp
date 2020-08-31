using System; 

class URI1073 {

    static void Main(string[] args) { 

       int n = int.Parse(Console.ReadLine());
		 	
		for (int i = 1; i <= n; i++){
			if (i % 2 == 0) {
			  Console.WriteLine("{0}^{1} = {2}", i, 2, (long)Math.Pow(i, 2));
			}
		}	
    }
}