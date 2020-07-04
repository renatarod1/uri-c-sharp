using System; 

class Uri1046 {

    static void Main(string[] args) { 
        string leIF = Console.ReadLine();
		string[] IF = leIF.Split(' ');
		
		int duracao;
		
		int I = int.Parse(IF[0]);
		int F = int.Parse(IF[1]);
		
		if (I < F) {
			duracao = F - I;			
		} else {
			duracao = 24 - I + F;
		}
		
		Console.WriteLine ("O JOGO DUROU "+ duracao +" HORA(S)");
    }
}