using System;
using System.Text;

namespace Курсач
{
    public class Atk
    {
        public string FindPrimes(string X)
        {
            if (!int.TryParse(X, out int limit) || limit < 2)
            {
                // Возвращаем пустую строку, если ввод некорректен
                return "";
            }

            // Явная проверка для чисел 2 и 3
            StringBuilder result = new StringBuilder();
            if (limit >= 2)
                result.Append("2, ");
            if (limit >= 3)
                result.Append("3, ");

            bool[] isPrime = new bool[limit + 1];

            int squareRoot = (int)Math.Sqrt(limit);

            for (int x = 1; x <= squareRoot; x++)
            {
                for (int y = 1; y <= squareRoot; y++)
                {
                    int n = (4 * x * x) + (y * y);
                    if (n <= limit && (n % 12 == 1 || n % 12 == 5))
                        isPrime[n] = !isPrime[n];

                    n = (3 * x * x) + (y * y);
                    if (n <= limit && n % 12 == 7)
                        isPrime[n] = !isPrime[n];

                    n = (3 * x * x) - (y * y);
                    if (x > y && n <= limit && n % 12 == 11)
                        isPrime[n] = !isPrime[n];
                }
            }

            for (int n = 5; n <= squareRoot; n++)
            {
                if (isPrime[n])
                {
                    for (int k = n * n; k <= limit; k += n * n)
                    {
                        isPrime[k] = false;
                    }
                }
            }

            // Начнем счетчик с 4, учитывая числа 2 и 3
            int count = 4;
            for (int i = 4; i <= limit; i++)
            {
                if (isPrime[i])
                {
                    result.Append(i).Append(", ");
                    count++;
                }
            }

            if (count > 2)
            {
                result.Length -= 2; // Убираем последнюю ", "
            }

            X = result.ToString();
            return X;
        }
    }
}
