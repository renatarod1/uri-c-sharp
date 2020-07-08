using System; 

class Uri1070 {

    static void Main(string[] args) { 

       int n = 0;
		int count = 0;
		
		n = int.Parse(Console.ReadLine());
		
		do {
			n = n + 1;
			if (n % 2 != 0){
				count = count + 1;
				Console.WriteLine(n);
			}
		}while (count < 6); 
    }
}