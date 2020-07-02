using System;
using System.Globalization;

class Uri1008 {

    static void Main(string[] args) { 
        int numFunc, horasTrab;
		double valorHoraTrab, salary;
		
		numFunc = Convert.ToInt32(Console.ReadLine());
		horasTrab = Convert.ToInt32(Console.ReadLine());
		valorHoraTrab = Convert.ToDouble(Console.ReadLine());
		salary = horasTrab * valorHoraTrab;
		
		Console.WriteLine("NUMBER = "+ numFunc);
		Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));
    }
}