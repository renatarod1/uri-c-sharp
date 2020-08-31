using System; 

class Uri1072 {

    static void Main(string[] args) { 
        int n, x; 
		int dentro = 0;
		int fora = 0;

		n = int.Parse(Console.ReadLine());
		
		for (int i = 0; i < n; i++) {
			x = int.Parse(Console.ReadLine());
			if (x >= 10 && x <= 20) {
				dentro ++;
			}
			else {
				fora++;
			}
		}
		
		Console.WriteLine(dentro +" in");
		Console.WriteLine(fora +" out");
    }
}