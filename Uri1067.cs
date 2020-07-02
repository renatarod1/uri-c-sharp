using System; 

class Uri1067 {

    static void Main(string[] args) { 

       	int x = Convert.ToInt32(Console.ReadLine());
		
		for (int i = 1; i <= x; i++) {
			if (i % 2 != 0) {
				Console.WriteLine(i);
			}
		}
    }
}