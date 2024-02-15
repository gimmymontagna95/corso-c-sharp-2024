namespace EsercizioCaesarCipher2;

internal class Program
{
    static void Main(string[] args)
    {
        string plainText = "Hello World!";

        int key = 200;

        string cipherText = Crypt(plainText, key);
        Console.WriteLine("cipher text: " + cipherText);

        string decryptedText = Decrypt(cipherText, key);
        Console.WriteLine("decrypted text: " + decryptedText);
    }


    public static char ProcessChar(char letter, int key)
    {
        //Console.WriteLine("letter: " + letter);

        int letterInt = letter;

        //Console.WriteLine("letterInt: " + letterInt);

        int resultInt = letterInt + key;

        //Console.WriteLine("resultInt: " + resultInt);

        char resultChar = (char)resultInt;

        //Console.WriteLine("resultChar: " + resultChar);

        return resultChar;
    }

    public static string Crypt(string plainText, int key)
    {
        return ProcessString(plainText, key);
    }
    public static string Decrypt(string cipherText, int key)
    {
        return ProcessString(cipherText, -key);
    }

    public static string ProcessString(string input, int key)
    {
        char[] chars = input.ToArray();
        char[] outputChars = new char[chars.Length];

        // faccio il calcolo
        for (int i = 0; i < chars.Length; i++)
        {
            char letter = chars[i];

            outputChars[i] = ProcessChar(letter, -key);
        }

        return new string(outputChars);
    }

}
