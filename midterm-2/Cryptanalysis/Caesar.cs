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

    public string Encrypt(string msg)
    {
        int i = 0;
        string res = "";
        while (i <= msg.Length - 1)
        {
            res += Tools.RotChar(msg[i], key);
            i += 1;
        }

        return res; 
    }

    public string Decrypt(string cypherText)
    {
        int i = 0;
        string res = "";
        while (i <= cypherText.Length - 1)
        {
            res += Tools.RotChar(cypherText[i], -key);
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