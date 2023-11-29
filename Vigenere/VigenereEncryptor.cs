namespace Vigenere;

public static class VigenereEncryptor
{
    public static string Encrypt(string source, string key)
    {
        var encryptedChars = new char[source.Length];
        for (var i = 0; i < source.Length; i++)
        {
            encryptedChars[i] = GetEncryptedChar(source[i], key[i % key.Length]);
        }
        return new string(encryptedChars);
    }

    private static char GetEncryptedChar(char source, char key)
    {
        return (char) ((source - 'a' + key - 'a') % 26 + 'a');
    }
}