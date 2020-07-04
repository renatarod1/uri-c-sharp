using System; 
using System.Globalization;

class Uri1038 {
    static void Main(string[] args) { 

       string lecodQtd = Console.ReadLine();
		string[] codQtd = lecodQtd.Split(' ');
		
		int cod = int.Parse(codQtd[0]);
        int qtd = int.Parse(codQtd[1]);

        double total;

            switch (cod) {
                case 1:
                    total = 4.00 * qtd;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;

                case 2:
                    total = 4.50 * qtd;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;

                case 3:
                    total = 5.00 * qtd;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;

                case 4:
                    total = 2.00 * qtd;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;

                case 5:
                    total = 1.50 * qtd;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;

                default:
                    break;
            }
    }
}