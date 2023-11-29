namespace Vigenere;

public static class VigenereDecryptor
{
    public static string Decrypt(string source, string key)
    {
        var encryptedChars = new char[source.Length];
        for (var i = 0; i < source.Length; i++)
        {
            encryptedChars[i] = GetDecryptedChar(source[i], key[i % key.Length]);
        }
        return new string(encryptedChars);
    }

    private static char GetDecryptedChar(char source, char key)
    {
        var number = source - 'a' - (key - 'a');
        while (number < 0)
            number += 26;
        return (char) (number + 'a');
    }
}