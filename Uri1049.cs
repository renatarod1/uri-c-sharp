using System; 

class Uri1049 {

    static void Main(string[] args) { 

      string p1, p2, p3;
		
		p1 = Console.ReadLine();
		p2 = Console.ReadLine();
		p3 = Console.ReadLine();
		
		if (p1.Equals("vertebrado")) {
			if (p2.Equals("ave")) {
				if (p3.Equals("carnivoro")) {
					Console.WriteLine("aguia");
				} else {
					Console.WriteLine("pomba");
				}
			} else {
				if (p3.Equals("onivoro")) {
					Console.WriteLine("homem");
				} else {
					Console.WriteLine("vaca");
				}				
			}			
		} else {
			if (p2.Equals("inseto")) {
				if (p3.Equals("hematofago")) {
					Console.WriteLine("pulga");
				} else {
					Console.WriteLine("lagarta");
				}
			} else {
				if (p3.Equals("hematofago")) {
					Console.WriteLine("sanguessuga");
				} else {
					Console.WriteLine("minhoca");
				}
			}
		}
    }
}