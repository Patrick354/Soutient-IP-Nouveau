using System;
using System.Linq;

namespace Cryptanalysis
{
public static class Tools
{
    public static int Modulus(int a, int b)
    {
        if (b < 0)
            b = -b;
        
        var mod = a % b;
        return mod < 0 ? b + mod : mod;
    }

    public static int LetterIndex(char c)
    {
        int res = 0;
        
        if (c == 'A')
        {
            res = 0;
        }
        if (c == 'B')
        {
            res = 1;
        }
        if (c == 'C')
        {
            res = 2;
        }
        if (c == 'D')
        {
            res = 3;
        }
        if (c == 'E')
        {
            res = 4;
        }
        if (c == 'F')
        {
            res = 5;
        }
        if (c == 'G')
        {
            res = 6;
        }
        if (c == 'H')
        {
            res = 7;
        }
        if (c == 'I')
        {
            res = 8;
        }
        if (c == 'J')
        {
            res = 9;
        }
        if (c == 'K')
        {
            res = 10;
        }
        if (c == 'L')
        {
            res = 11;
        }
        if (c == 'M')
        {
            res = 12;
        }
        if (c == 'N')
        {
            res = 13;
        }
        if (c == 'O')
        {
            res = 14;
        }
        if (c == 'P')
        {
            res = 15;
        }
        if (c == 'Q')
        {
            res = 16;
        }
        if (c == 'R')
        {
            res = 17;
        }
        if (c == 'S')
        {
            res = 18;
        }
        if (c == 'T')
        {
            res = 19;
        }
        if (c == 'W')
        {
            res = 20;
        }
        if (c == 'V')
        {
            res = 21;
        }
        if (c == 'U')
        {
            res = 22;
        }
        if (c == 'X')
        {
            res = 23;
        }
        if (c == 'Y')
        {
            res = 24;
        }
        if (c == 'Z')
        {
            res = 25;
        }
        if (c == 'a')
        {
            res = 26;
        }
        if (c == 'b')
        {
            res = 27;
        }
        if (c == 'c')
        {
            res = 28;
        }
        if (c == 'd')
        {
            res = 29;
        }
        if (c == 'e')
        {
            res = 30;
        }
        if (c == 'f')
        {
            res = 31;
        }
        if (c == 'g')
        {
            res = 32;
        }
        if (c == 'h')
        {
            res = 33;
        }
        if (c == 'i')
        {
            res = 34;
        }
        if (c == 'j')
        {
            res = 35;
        }
        if (c == 'k')
        {
            res = 36;
        }
        if (c == 'l')
        {
            res = 37;
        }
        if (c == 'm')
        {
            res = 38;
        }
        if (c == 'n')
        {
            res = 39;
        }
        if (c == 'o')
        {
            res = 40;
        }
        if (c == 'p')
        {
            res = 41;
        }
        if (c == 'q')
        {
            res = 42;
        }
        if (c == 'r')
        {
            res = 43;
        }
        if (c == 's')
        {
            res = 44;
        }
        if (c == 't')
        {
            res = 45;
        }
        if (c == 'w')
        {
            res = 46;
        }
        if (c == 'v')
        {
            res = 47;
        }
        if (c == 'u')
        {
            res = 48;
        }
        if (c == 'x')
        {
            res = 49;
        }
        if (c == 'y')
        {
            res = 50;
        }
        if (c == 'z')
        {
            res = 51;
        }

        return res;
    }
    
    public static char RotChar(char c, int n)
    {
        int nouveau = Convert.ToInt32(c);
        char chara = ' ';
        int res = 0;

        if (nouveau < 65 || nouveau > 122)
        {
            return c;
        }
        if (nouveau >= 65 && nouveau <= 90)
        {
            if (n <= 0)
            {
                if (nouveau - n < 65)
                {
                    int count = 0;
                    while (nouveau - count >= 97)
                    {
                        count += 1;
                    }

                    int nuovo = 26 - (n + count);
                    res =  Modulus(nuovo, 26);
                    nuovo = 122 - res;
                    chara = Convert.ToChar(nuovo);
                }
                else
                {
                    res = nouveau + n;
                    chara = Convert.ToChar(res);
                    return chara;
                }
            }
            if (nouveau + n > 90)
            {
                int count = 0;
                while (nouveau + count <= 122)
                {
                    count += 1;
                }

                int nuovo = 26 + (n - count);
                res =  Modulus(nuovo, 26);
                nuovo = 97 + res;
                chara = Convert.ToChar(nuovo);
            }
            else
            {
                res = nouveau + n;
                chara = Convert.ToChar(res);
            }
        }

        if (nouveau >= 97 && nouveau <= 122)
        {
            if (n <= 0)
            {
                if (nouveau + n < 97)
                {
                    int count = 0;
                    while (nouveau - count >= 97)
                    {
                        count += 1;
                    }

                    int nuovo = 26 - (n + count);
                    res =  Modulus(nuovo, 26);
                    nuovo = 122 - res;
                    chara = Convert.ToChar(nuovo);
                }
                else
                {
                    res = nouveau + n;
                    chara = Convert.ToChar(res);
                    return chara;
                }
            }
            else
            {
                if (nouveau + n > 122)
                {
                    int count = 0;
                    while (nouveau + count <= 122)
                    {
                        count += 1;
                    }

                    int nuovo = 26 + (n - count);
                    res =  Modulus(nuovo, 26);
                    nuovo = 97 + res;
                    chara = Convert.ToChar(nuovo);
                }
                else
                {
                    res = nouveau + n;
                    chara = Convert.ToChar(res);
                }
            }
        }

        return chara;
    }

    public static int[] Histogram(string str)
    {
        int[] tableau = new int[51];
        int z = 0;
        int x = 65;
        int i = 0;
        int count = 0;
        while (x <= 90)
        {
            while (i <= str.Length -1)
            {
                if (Convert.ToInt32(str[i]) == x)
                {
                    count += 1;
                    i += 1;
                }
                else
                {
                    i += 1;
                }
            }

            i = 0;
            tableau[z] = count;
            z += 1;
            count = 0;
            x += 1;
        }

        x = 97;
        z = 25;
        while (x <= 122)
        {
            while (i <= str.Length - 1)
            {
                if (Convert.ToInt32(str[i]) == x)
                {
                    count += 1;
                    i += 1;
                }
                else
                {
                    i += 1;
                }
            }

            i = 0;
            tableau[z] = count;
            z += 1;
            count = 0;
            x += 1;
        }

        return tableau;
    }
    
    public static string FilterLetters(string str)
    {
        throw new NotImplementedException();
    }

    public static string Extract(string str, int start, int step)
    {
        throw new NotImplementedException();
    }
}
}
