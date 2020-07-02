using System;
using System.Globalization;

class Uri1010 {

    static void Main(string[] args) { 

       int cod1, cod2, qtd1, qtd2;
		double vl1, vl2, total;
		
		string lePeca1 = Console.ReadLine();
		string lePeca2 = Console.ReadLine();
		
		string[] peca1 = lePeca1.Split(' ');
		
		cod1 = Convert.ToInt32(peca1[0]);
		qtd1 = Convert.ToInt32(peca1[1]);
		vl1 = Convert.ToDouble(peca1[2]);
		
		string[] peca2 = lePeca2.Split(' ');
		
		cod2 = Convert.ToInt32(peca2[0]);
		qtd2 = Convert.ToInt32(peca2[1]);
		vl2 = Convert.ToDouble(peca2[2]);
		
		total = vl1 * qtd1 + vl2 * qtd2;
		Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
    }
}