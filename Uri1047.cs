using System; 

class Uri1047 {

    static void Main(string[] args) { 
		string s = Console.ReadLine();
		
		string[] vectInicialFinal = s.Split(' ');
	
		int horaInicial = Convert.ToInt32(vectInicialFinal[0]);
		int minutoInicial = Convert.ToInt32(vectInicialFinal[1]);
		int horaFinal = Convert.ToInt32(vectInicialFinal[2]);
		int minutoFinal = Convert.ToInt32(vectInicialFinal[3]);

		int instanteInicial = horaInicial * 60 + minutoInicial;
		int instanteFinal = horaFinal * 60 + minutoFinal;

		int duracao;
		if (instanteInicial < instanteFinal) {
			duracao = instanteFinal - instanteInicial;
		} else {
			duracao = (24 * 60 - instanteInicial) + instanteFinal;
		}

		int duracaoHoras = duracao / 60;
		int duracaoMinutos = duracao % 60;

		Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");
    }
}