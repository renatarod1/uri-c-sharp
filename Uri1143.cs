using System; 

class Uri1143 {

    static void Main(string[] args) { 

       int n = Convert.ToInt32(Console.ReadLine());

		for (int i = 1; i <= n; i++) {
			Console.Write(i);
			Console.Write(" " + (int)Math.Pow(i, 2));
			Console.WriteLine(" " + (int)Math.Pow(i, 3));
		}
    }
}