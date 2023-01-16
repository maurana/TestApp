using System;

namespace TestApp
{
    class Program
    {
        public static string procVowel(string param)
        {
            string res = "";

            for (int i = 0; i < param.Length; i++)
            {
                if (param[i] == 'A' || param[i] == 'a' || param[i] == 'E' || param[i] == 'e' || param[i] == 'I' || param[i] == 'i' || param[i] == 'U' || param[i] == 'u' || param[i] == 'O' || param[i] == 'o')
                {

                    res = res + param[i];

                }
            }

            return res;
        }

        public static string procConsonant(string param)
        {
            string res = "";

            for (int i = 0; i < param.Length; i++)
            {
                if (param[i] == 'A' || param[i] == 'a' || param[i] == 'E' || param[i] == 'e' || param[i] == 'I' || param[i] == 'i' || param[i] == 'U' || param[i] == 'u' || param[i] == 'O' || param[i] == 'o')
                {
                    continue;
                }
                else
                {
                    if (char.IsWhiteSpace(param[i]))
                    {
                        continue;
                    }
                    else
                    {
                        res = res + param[i];
                    }

                }
            }

            return res;
        }

        public static void Character()
        {
            Console.Write("Input one line of words (S) : ");
            string input = Console.ReadLine();

            string charVowel = procVowel(input);
            string charConsonant = procConsonant(input);

            Console.WriteLine("Vowel Characters : ");
            Console.WriteLine(charVowel);
            Console.WriteLine("Consonant Characters : ");
            Console.WriteLine(charConsonant);
        }

        public static void Bus()
        {
            Console.Write("Input the number of families : ");
            int nof = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Input the number of members in the family : ");
            string nom = Console.ReadLine();

            List<int> list_nom = new List<int>();
            for (int i = 0; i < nom.Length; i++)
            {
                if (char.IsWhiteSpace(nom[i]))
                {
                    continue;
                }
                else
                {
                    list_nom.Add(nom[i]);
                }
            }

            int[] noms = list_nom.ToArray();
            if(noms.Length != nof)
            {
              Console.WriteLine("Input must be equal with count of family");
            } else
            {
                int max_pasenggers = 4;
                int number_res = 0;
                int total = 0;

                for (int j = 0; j < noms.Length; j++)
                {
                    
                    bool check = false;

                    if (noms[j].Equals(max_pasenggers))
                    {
                        number_res += 1;
                    } 
                    else if (noms[j] > max_pasenggers)
                    {
                        check = true;
                        total += noms[j];
                    }
                    else if (noms[j] < max_pasenggers)
                    {
                        check = true;
                        total += noms[j];
                    }

                    if(check == true)
                    {
                        int ax = total/max_pasenggers;
                        number_res += ax;
                    }
                }

                Console.WriteLine("OUTPUT: " + number_res);
            }
        }

        static void Main(string[] args)
        {
            // 1
            Character();

            // 2
            Bus();
        }
    }
}
