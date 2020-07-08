using System; 
using System.Globalization;

class Uri1116 {

    static void Main(string[] args) { 
		int n = int.Parse(Console.ReadLine());

		for (int i = 0; i < n; i++) {
			string par = Console.ReadLine();
			string[] parXY = par.Split(' ');
			
			int x = int.Parse(parXY[0]);
			int y = int.Parse(parXY[1]);

			if (y == 0) {
				Console.WriteLine("divisao impossivel");
			} else {
				double res = (double) x / y;
				Console.WriteLine(res.ToString("F1", CultureInfo.InvariantCulture));
			}
		}
    }
}