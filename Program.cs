using System;

namespace Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            bool infinie = false;


            float resultat=0;

            while (infinie != true)
            {

                Console.WriteLine("First operand : ");
                float foperand = float.Parse((Console.ReadLine()));
                Console.WriteLine("First operand : ");
                float foperand2 = float.Parse((Console.ReadLine()));
                Console.WriteLine("Which operation you choose : ");
                string typeOperation = Console.ReadLine().ToLower();


                if(typeOperation=="add")
                {
                    resultat=addition(foperand, foperand2);
                    Console.WriteLine(foperand+" + "+foperand2+" = "+ resultat);
                }

                else if(typeOperation=="subtract")
                {
                    resultat = soustraction(foperand, foperand2);
                    Console.WriteLine(foperand + " - " + foperand2 + " = " + resultat);

                }
                else if (typeOperation == "multiply")
                {
                    resultat = multiplication(foperand, foperand2);
                    Console.WriteLine(foperand + " x " + foperand2 + " = " + resultat);
                }
                else if (typeOperation == "dividee")
                {
                    resultat = division(foperand, foperand2);
                    Console.WriteLine(foperand + " / " + foperand2 + " = " + resultat);
                }
                else if (typeOperation == "modulo")
                {
                    resultat = modulo(foperand, foperand2);
                    Console.WriteLine(foperand + " % " + foperand2 + " = " + resultat);
                }




            }

            static float addition(float a,float b)
            {
                return a + b;
            }

            static float soustraction(float a, float b)
            {
                return a - b;
            }

            static float multiplication(float a, float b)
            {
                return a * b;
            }

            static float division(float a, float b)
            {
                return a / b;
            }

            static float modulo(float a, float b)
            {
                return a % b;
            }


        }
    }
}
