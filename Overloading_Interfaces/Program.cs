using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Overloading_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle angle1 = new Angle(3, 12, 25);
            Angle angle2 = new Angle(500, 48, 35);
            Angle result_sum = angle1 + angle2;
            Angle result_sub = angle1 - angle2;
            Console.WriteLine("{0} {1} {2}", angle1.degrees, angle1.minutes, angle1.seconds);
            Console.WriteLine("{0} {1} {2}", angle2.degrees, angle2.minutes, angle2.seconds);
            Console.WriteLine("Sum= {0} {1} {2}", result_sum.degrees, result_sum.minutes, result_sum.seconds);
            Console.WriteLine("Subtraction= {0} {1} {2}", result_sub.degrees, result_sub.minutes, result_sub.seconds);
            Angle angle3 = new Angle(18, 26, 35);
            Angle result_mult = angle3 * 3;
            Console.WriteLine("Multiplication= {0} {1} {2}", result_mult.degrees, result_mult.minutes, result_mult.seconds);
            Angle angle4 = new Angle(18, 7, 32);
            Angle result_div = angle4 / 15;
            Console.WriteLine("Division= {0} {1} {2}", result_div.degrees, result_div.minutes, result_div.seconds);
            Console.WriteLine("angle1==angle2 returns  " + (angle1 == angle2));
            Console.WriteLine("angle3!=angle4 returns  " + (angle3 != angle4));
            Console.WriteLine(angle1[1]);

            Console.WriteLine("------Sorting array of angles------");

            Angle[] myAngles = new Angle[5]
            {
                new Angle {degrees=10, minutes=34, seconds= 0 },
                new Angle {degrees=100, minutes=37, seconds= 3 },
                new Angle {degrees=23, minutes=3, seconds= 7 },
                new Angle {degrees=45, minutes=56, seconds= 9 },
                new Angle {degrees=1, minutes=1, seconds= 10 }
            };
            Console.WriteLine("Initial array  of angles:");
            foreach (Angle a in myAngles)
                Console.WriteLine(a);     
            Array.Sort(myAngles);
            Console.WriteLine("DescendingSort by sum=degrees+minutes+seconds :");
            foreach (Angle a in myAngles)
                Console.WriteLine(a);
            Console.WriteLine("DescendingSort by seconds :");
            Array.Sort(myAngles, Angle.SortBySeconds);
            foreach (Angle a in myAngles)
                Console.WriteLine(a);
            Console.WriteLine("AscendingSort by degrees :");
            Array.Sort(myAngles, Angle.SortByDegrees);
            foreach (Angle a in myAngles)
                Console.WriteLine(a);

        }
    }
}
