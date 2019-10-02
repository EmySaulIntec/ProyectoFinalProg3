using System;

namespace CashBox.Utils
{
    class CoinChange
    {

        public static int F(int[] monedas, int monto)
        {
            return F(monedas, monto, 0);
        }

        static int[,] p;
        private static int F(int[] monedas, int monto, int n)
        {
            if (monto == 0)
                return 0;

            if (monto < 0)
                return int.MaxValue;

            if (n >= monedas.Length)
                return int.MaxValue;

            int res = int.MaxValue;
            for (int cantMonedas = 0; cantMonedas * monedas[n] <= monto;
                cantMonedas++)
            {
                int t = F(monedas, monto - cantMonedas * monedas[n], n + 1);
                if (t >= int.MaxValue) continue;
                //res = Math.Min(res, t + cantMonedas);
                if (res > t + cantMonedas)
                {
                    res = t + cantMonedas;
                    p[monto, n] = cantMonedas;
                }
            }

            return res;
        }

        static void Main(string[] args)
        {
            int[] monedas = { 1, 5, 10, 20, 25, 50 };
            int monto = 42;
            int res = F(monedas, monto);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
