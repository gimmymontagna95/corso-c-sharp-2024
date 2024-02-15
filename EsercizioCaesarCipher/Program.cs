namespace EsercizioCaesarCipher;

internal class Program
{
    static void Main(string[] args)
    {

        string plainText = "Hello World!";
        int key = 200;

        string cipherText = Crypt(plainText, key);
        Console.WriteLine(cipherText);

        string decryptedText = Decrypt(cipherText, key);
        Console.WriteLine(decryptedText);

    }

    public static string Crypt(string plainText, int key)
    {
        char[] chars = plainText.ToCharArray();
        char[] ciphredChars = new char[chars.Length];

        for (int i = 0; i < chars.Length; i++)
        {
            char letter = chars[i];

            ciphredChars[i] = ProcessChar(letter, key);
        }

        return new string(ciphredChars);
    }

    public static string Decrypt(string cipherText, int key)
    {
        char[] chars = cipherText.ToCharArray();
        char[] plainChars = new char[chars.Length];

        for (int i = 0; i < chars.Length; i++)
        {
            char letter = chars[i];

            plainChars[i] = ProcessChar(letter, -key);
        }

        return new string(plainChars);
    }

    public static char ProcessChar(char letter, int key)
    {
        if (!char.IsLetter(letter))
        {
            return letter;
        }

        int letterValue = letter;

        int offset = GetOffset(letter);

        int positionInAlphabet = letterValue - offset;
        int valueWithKey = ModuloCheFunziona(positionInAlphabet + key, 26);
        int cipherValue = valueWithKey + offset;

        return (char)cipherValue;
    }

    public static int ModuloCheFunziona(int a, int b)
    {
        return (a % b + b) % b;
    }

    public static int GetOffset(char letter)
    {
        if (char.IsUpper(letter))
        {
            return 'A';
        }
        else
        {
            return 'a';
        }
    }
}
