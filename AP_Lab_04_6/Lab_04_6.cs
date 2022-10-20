// Lab_04_6.cs
// Якубовський Владислав
// Лабораторна робота № 4.6
// Вкладені цикли.
// Варіант 24
using System;

namespace AP_Lab_04_6
{
    internal class Lab_04_6
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            int n = 1, ii, jj;

            double firstProduct, secondProduct, sum = 0;

            // Спосіб 1: while(…) {… while(…) {…} …}
            while (n <= 10)
            {
                firstProduct = 1; secondProduct = 1;

                ii = 1;
                jj = n;

                while (ii <= n)
                {
                    firstProduct *= Math.Pow(ii, 2);

                    ii++;
                }

                while (jj <= 10)
                {
                    secondProduct *= Math.Pow(jj, 2);

                    jj++;
                }

                sum += (firstProduct + secondProduct) / n;

                n++;
            }

            Console.WriteLine($"Отримана першим способом сума:  \t{sum}");

            sum = 0;

            // Спосіб 2: do{… do{…} while(…) …} while(…)
            n = 1;

            do
            {
                firstProduct = 1; secondProduct = 1;

                ii = 1;
                jj = n;

                do
                {
                    firstProduct *= Math.Pow(ii, 2);

                    ii++;
                }
                while (ii <= n);

                do
                {
                    secondProduct *= Math.Pow(jj, 2);

                    jj++;
                }
                while (jj <= 10);

                sum += (firstProduct + secondProduct) / n;

                n++;
            }
            while (n <= 10);

            Console.WriteLine($"Отримана другим способом сума:  \t{sum}");

            sum = 0;

            // Спосіб 3: for(…; …; n++) {… for(…; …; k++) {…} …}
            for (n = 1; n <= 10; n++)
            {
                firstProduct = 1; secondProduct = 1;

                for (ii = 1; ii <= n; ii++)
                    firstProduct *= Math.Pow(ii, 2);

                for (jj = n; jj <= 10; jj++)
                    secondProduct *= Math.Pow(jj, 2);

                sum += (firstProduct + secondProduct) / n;
            }
            
            Console.WriteLine($"Отримана третім способом сума:  \t{sum}");

            sum = 0;

            // Спосіб 4: for(…; …; n--) {… for(…; …; k--) {…} …}
            for (n = 10; n >= 1; n--)
            {
                firstProduct = 1; secondProduct = 1;

                for (ii = n; ii >= 1; ii--)
                {
                    firstProduct *= Math.Pow(ii, 2);
                }                

                for (jj = 10; jj >= n; jj--)
                    secondProduct *= Math.Pow(jj, 2);

                sum += (firstProduct + secondProduct) / n;
            }

            Console.WriteLine($"Отримана четвертим способом сума:  \t{sum}");

            Console.ReadLine();
        }
    }
}