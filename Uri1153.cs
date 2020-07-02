using System; 

class Uri1153 {

    static void Main(string[] args) { 
        int n = Convert.ToInt32(Console.ReadLine());
		
		for (int i = n-1; i >= 1; i--) {
				n = n * i;
		}		
		Console.WriteLine(n);
    }
}