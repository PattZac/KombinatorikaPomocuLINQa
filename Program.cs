using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KombinatorikaPomocuLINQa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var qSort = from one in Enumerable.Range(1, 9)
                        from two in Enumerable.Range(1, 9)
                        where two != one
                        from three in Enumerable.Range(1, 9)
                        where three != two && two != one
                        from four in Enumerable.Range(1, 9)
                        where four != three && four != two && two != one
                        from five in Enumerable.Range(1, 9)
                        where five != four && five != three && five != two && five != one
                        from six in Enumerable.Range(1, 9)
                        where six != five && six != four && six != three && six != two && six != one
                        from seven in Enumerable.Range(1, 9)
                        where seven != six && seven != five && seven != four && seven != three && seven != two && seven != one
                        from eight in Enumerable.Range(1, 9)
                        where eight != seven && eight != six && eight != five && eight != four && eight != three && eight != two && eight != one
                        from nine in Enumerable.Range(1, 9)
                        where nine != eight && nine != seven && nine != six && nine != five && nine != four && nine != three && nine != two && nine != one &&
                        (one * 10 + two) % 2 == 0 &&
                        (one * 100 + two * 10 + three) % 3 == 0 &&
                        (one * 1000 + two * 100 + three * 10 + four) % 4 == 0 &&
                        (one * 10000 + two * 1000 + three * 100 + four * 10 + five) % 5 == 0 &&
                        (one * 100000 + two * 10000 + three * 1000 + four * 100 + five * 10 + six) % 6 == 0 &&
                        (one * 1000000 + two * 100000 + three * 10000 + four * 1000 + five * 100 + six * 10 + seven) % 7 == 0 &&
                        (one * 10000000 + two * 1000000 + three * 100000 + four * 10000 + five * 1000 + six * 100 + seven * 10 + eight) % 8 == 0 &&
                        (one * 100000000 + two * 10000000 + three * 1000000 + four * 100000 + five * 10000 + six * 1000 + seven * 100 + eight * 10 + nine) % 9 == 0
                        select (one * 100000000 + two * 10000000 + three * 1000000 + four * 100000 + five * 10000 + six * 1000 + seven * 100 + eight * 10 + nine);

            foreach (var s in qSort)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
