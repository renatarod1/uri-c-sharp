using System; 

class Uri1044 {

    static void Main(string[] args) { 

        string leAB = Console.ReadLine();
		string[] AB = leAB.Split(' ');
		
		int A = int.Parse(AB[0]);
		int B = int.Parse(AB[1]);
		
		if (A % B == 0 || B % A == 0) {
			Console.WriteLine("Sao Multiplos");
		} else {
			Console.WriteLine("Nao sao Multiplos");
		}
    }
}