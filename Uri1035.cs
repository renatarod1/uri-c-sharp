using System; 

class Uri1035 {

    static void Main(string[] args) {
        string leABCD = Console.ReadLine();
		string[] ABCD = leABCD.Split(' ');		
		
		int A = Convert.ToInt32(ABCD[0].ToString());
		int B = Convert.ToInt32(ABCD[1].ToString());
		int C = Convert.ToInt32(ABCD[2].ToString());
		int D = Convert.ToInt32(ABCD[3].ToString());
		
		if (B > C && D > A && C + D > A + B && C > 0 && D > 0 && A % 2 == 0){
			Console.WriteLine("Valores aceitos");
		} else {
			Console.WriteLine("Valores nao aceitos");
		}
    }
}