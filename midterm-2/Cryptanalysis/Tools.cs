using System;

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

        return res;
    }
    
    public static char RotChar(char c, int n)
    {
        int nouveau = Convert.ToInt32(c);
        char chara = ' ';
        int res = 0;
        if (nouveau >= 65 && nouveau <= 90)
        {
            if (nouveau + n > 90)
            {
               res =  Modulus(nouveau + n, 26);
               nouveau = res;
               chara = Convert.ToChar(nouveau);
            }
            else
            {
                res = nouveau + n;
                chara = Convert.ToChar(res);
            }
        }

        if (nouveau >= 97 && nouveau <= 122)
        {
            if (nouveau + n > 122)
            {
                int count = 0;
                while (nouveau + count <= 122)
                {
                    count += 1;
                }
                res =  Modulus(nouveau + n, 26);
                nouveau = res;
                chara = Convert.ToChar(nouveau);
            }
            else
            {
                res = nouveau + n;
                chara = Convert.ToChar(res);
            }
        }

        return chara;
    }

    public static int[] Histogram(string str)
    {
        throw new NotImplementedException();
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
