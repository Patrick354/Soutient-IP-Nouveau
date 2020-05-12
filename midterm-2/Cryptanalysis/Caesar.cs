using System;

namespace Cryptanalysis
{
public class Caesar
{
    protected int key;

    public int Key
    {
        get => key;
        set => key = value;
    }

    public Caesar(int key)
    {
        key = this.key;
    }

    public static string Encrypt(string msg)
    {
        int i = 0;
        string res = "";
        while (i <= msg.Length - 1)
        {
            res += Tools.RotChar(msg[i], 3);
            i += 1;
        }

        return res; 
    }

    public static string Decrypt(string cypherText)
    {
        int i = 0;
        string res = "";
        while (i <= cypherText.Length - 1)
        {
            res += Tools.RotChar(cypherText[i], -3);
            i += 1;
        }

        return res; 
    }
    
    public static int GuessKey(string cypherText)
    {
        throw new NotImplementedException();
    }
}
}