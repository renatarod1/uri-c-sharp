using System; 

class Uri1065 {

    static void Main(string[] args) { 

        int n = 0;
		int count = 0;
		
		for (int i = 1; i <=5; i++){
		 	n = int.Parse(Console.ReadLine());
			 
			if (n % 2 == 0){
				count = count + 1;
			}
		}
		
		Console.WriteLine(count + " valores pares");
    }
}