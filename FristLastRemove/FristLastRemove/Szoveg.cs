using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FristLastRemove
{
    class Szoveg
    {

        public string Bemeno
        {
            get;
            set;
        }

        public Szoveg(string bemeno)
        {
            this.Bemeno = bemeno;

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

            string Remove_2(Bemeno)
        {
                if (Bemeno.Length <= 2)
                {
                    return Bemeno;
                }
                else
                {
                    return Bemeno.Substring(1, Bemeno.Length - 2);
                }





            }


        }
    }
}

