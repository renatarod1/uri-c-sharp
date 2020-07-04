using System; 

class Uri1013 {

    static void Main(string[] args) {
        string leABC = Console.ReadLine();
		string[] ABC = leABC.Split(' ');		
		int A = Convert.ToInt32(ABC[0]);
		int B = Convert.ToInt32(ABC[1]);
		int C = Convert.ToInt32(ABC[2]);
		
		int D = (A + B + Math.Abs(A - B)) / 2;
		int E = (D + C + Math.Abs(D - C)) / 2;
		
		Console.WriteLine(E + " eh o maior");
    }
}