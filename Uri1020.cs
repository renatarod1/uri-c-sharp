using System; 

class Uri1020 {

    static void Main(string[] args) { 

       int N = int.Parse(Console.ReadLine());
		Console.WriteLine(N / 365 + " ano(s)");
		
		N = N % 365;
		Console.WriteLine(N / 30 + " mes(es)");
		
		N = N % 30;
		Console.WriteLine(N + " dia(s)");
    }
}