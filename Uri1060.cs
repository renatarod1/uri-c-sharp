using System; 

class URI1060 {

    static void Main(string[] args) { 
        double[] numeros = new double[6];
		int count = 0;
		
		for (int i = 0; i <= 5; i++){
			numeros[i] = Convert.ToDouble(Console.ReadLine());
		}
		
		for (int i = 0; i <= 5; i++){
			if (numeros[i] > 0){
				count = count + 1;
			}
		}		
		Console.WriteLine(count + " valores positivos");
    }
}