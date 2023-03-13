internal class Program
{
    internal class Domino
    {
        private int arriba;
        private int abajo;
        private int valor;

        public Domino(int arriba, int abajo)
        {
            this.arriba = arriba;
            this.abajo = abajo;
        }

         public static Domino operator +(Domino a, Domino b)
        {
            int arriba = a.arriba + b.arriba;
            int abajo = a.abajo + b.abajo;
            Domino resultado = new Domino(arriba, abajo);
            return resultado;
        }

        public int GetArriba()
        {
            return arriba;
        }

        public int GetAbajo()
        {
            return abajo;
        }
    }

    private static void Main(string[] args)
    {
        Domino a = new Domino(2, 3);
        Domino b = new Domino(1, 4);

        Domino resultado = a + b;

        int sumaCombinada = resultado.GetArriba() + resultado.GetAbajo();

        Console.WriteLine("Suma combinada: {0}", sumaCombinada);

        Console.ReadKey(); 

        //cambio 3
        } 
    }