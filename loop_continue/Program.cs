using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            //while continue
            //int sum = 0;
            //int indxe = 1;
            //while (indxe <= 100)
            //{
            //    if (indxe % 7 == 0)
            //    {
            //        indxe++;
            //        continue;
            //    }
            //    sum += indxe;
            //    indxe++;

            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();

            for (int i = 1; i < 10; i++)
            {


                for (int j = 1; j < 10; j++)
                {

                    //Console.WriteLine(i + "X" + j + "=" + (i * j));
                    //\t = Tab
                    Console.Write("{0}X{1}={2}\t",i,j,i*j);

                }
                Console.WriteLine();
                //Console.WriteLine("\r\n");
            }
            Console.ReadKey();
            Console.WriteLine("=========================");
            for (int i = 1; i < 10; i++)
            {


                for (int j = 1; j <= i; j++)
                {

                    //Console.WriteLine(i + "X" + j + "=" + (i * j));
                    //\t = Tab
                    Console.Write("{0}X{1}={2}\t", i, j, i * j);

                }
                Console.WriteLine();
                //Console.WriteLine("\r\n");
            }
            Console.ReadKey();

        }
    }
}
