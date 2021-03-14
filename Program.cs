using System; 

class minhaClasse{

    static void Main(string[] args) { 

            int a, b, x;
            string[] leitura = Console.ReadLine().Split();
            a = Convert.ToInt32(leitura[0]);
            b = Convert.ToInt32(leitura[1]);

            x = a + b; //complete o código de acordo com o cálculo esperado

            Console.WriteLine("X = {0}", x);

    }

}