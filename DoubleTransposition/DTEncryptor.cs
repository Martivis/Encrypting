namespace DoubleTransposition;

public static class DTEncryptor
{
    public static string Encrypt(string source, Key key1, Key key2)
    {
        var columns = key1.Length;
        var rows = key2.Length;
        var matrix = new char[key1.Length, key2.Length];
        
        for (var i = 0; i < columns; i++)
        {
            for (var j = 0; j < rows; j++)
            {
                matrix[key1.Sequence.IndexOf(i) , key2.Sequence.IndexOf(j)] = source[i + j];
            }
        }

        var charResult = new char[matrix.Length];
        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < columns; j++)
            {
                charResult[i + j] = matrix[i, j];
            }
        }

        return new string(charResult);
    }
}