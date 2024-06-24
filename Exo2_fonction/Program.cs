using System;
namespace  Exo2_fonction
{
    internal class Exofonction
    {
        static int ValeurMini(int[] param)
        {
            int Valeur = param[0];
            int occurence = 0;
            for (int i = 0; i < param.Length; i++)
            {
                if (param[i] < Valeur)
                {
                    Valeur = param[i];
                    occurence = 1;
                }
                else if (param[i]> Valeur)//(param[i] == occurence)
                {

                    occurence++;
                }
            }

            return Valeur;   

        }

        static int ValeurMaxi(int[] param)
        {
            int Valeur = param[0];
            int occurence = 0;
            for (int i = 0; i < param.Length; i++)
            {
                if (param[i] > Valeur)
                {
                    Valeur = param[i];
                    occurence = 1;
                }
                else if (param[i] > Valeur)//(param[i] == occurence)
                {

                    occurence++;
                }
            }

            return Valeur;

        }
        
        static void Main(string[] args)
        {
            int[] tab1 = new int[10];
            tab1[0] = 10;
            tab1[1] = 9;
            tab1[2] = 16;
            tab1[3] = 12;
            tab1[4] = 22;
            tab1[5] = 45;
            tab1[6] = 105;
            tab1[7] = 89;
            tab1[8] = 75;
            tab1[9] = 19;

            for (int i = 0; i < tab1.Length; i++)
            {
                Console.WriteLine("Les valeurs du tableau sont : " + tab1[i] );
            }
            Console.WriteLine("la valeur minimum du tableau est  " + ValeurMini(tab1)+"  La valeur maximum du tableau est :" +ValeurMaxi(tab1));
        }
    }
}