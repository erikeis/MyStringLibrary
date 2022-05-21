using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMetody
{
    public class Metody
    {
        public static string VymazDiakritiku(string vstup) //vymaže malé diakritické znaky ve vstupní řetězci
        {
            char[] diakritickeZnaky = { 'ů', 'ú', 'ě', 'š', 'č', 'ř', 'ž', 'ý', 'á', 'í', 'é' };
            char[] nediakritickeZnaky = { 'u', 'u', 'e', 's', 'c', 'r', 'z', 'y', 'a', 'i', 'e' };
            char[] oddelovac = { ' ' };
            string[] slova = vstup.Split(oddelovac, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < vstup.Length; i++)
            {
                for (int l = 0; l < diakritickeZnaky.Length; l++)
                {
                    if (vstup[i] == diakritickeZnaky[l]) vstup = vstup.Replace(diakritickeZnaky[l], nediakritickeZnaky[l]);
                }
            }
            return vstup;
        }

        /*
        public static string VymazDiakritiku2(string vstup)
        {
            byte[] bytes = Encoding.GetEncoding("Cyrillic").GetBytes(vstup);
            return Encoding.ASCII.GetString(bytes);
        }
        */

        public static string PasswordGen()
        {
            Random random = new Random();
            string password = string.Empty;
            int number = 0;
            for (int i = 0; i < 6; i++) //sestimistne heslo
            {
                number = random.Next(1, 4);
                switch (number)
                {
                    case 1: //velka pismena
                        {
                            password += (char)random.Next((int)'A', (int)'Z'+1);
                            break;
                        }
                    case 2: //mala pismena
                        {
                            password += (char)random.Next((int)'a', (int)'z'+1);
                            break;
                        }
                    case 3: //cisla
                        {
                            password += random.Next(0, 10).ToString();
                            break;
                        }
                    default: //nikdy neprobehne
                        break;
                }
                
            }
            return password;
        }

    }
}
