using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FristLastRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem a sztringet: ");
            string bemeno = Console.ReadLine();

            Console.WriteLine($"A csonkolt string: {Remove_1(bemeno)}");

            Console.WriteLine($"A csonkolt string: {Remove_2(bemeno)}");

            Console.ReadKey(true);
        }

        public static string Remove_1(string Bemeno)
        {
            if (Bemeno.Length <= 2)
            {
                return Bemeno;
            }
            else
            {
                return Bemeno.Remove(0, 1).Remove(Bemeno.Length - 2, 1);
            }


        }
            static string Remove_2(string Bemeno)
        {
                if (Bemeno.Length <= 2)
                {
                    return Bemeno;
                }
                else
                {
                    return Bemeno.Substring(1,Bemeno.Length -2);
                }





            }


    }
}
