namespace DoubleTransposition;

public static class DTDecryptor
{
    public static string Decrypt(string source, Key key1, Key key2)
    {
        var columns = key1.Length;
        var rows = key2.Length;
        if (columns * rows < source.Length)
            throw new ArgumentException("Keys length is too low for this message");
        
        var matrix = new char[key1.Length, key2.Length];
        
        for (var i = 0; i < columns; i++)
        {
            for (var j = 0; j < rows; j++)
            {
                if (i + j > source.Length)
                    break;
                matrix[i, j] = source[i * rows + j];
            }
        }

        var charResult = new char[matrix.Length];
        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < columns; j++)
            {
                charResult[i * rows + j] = matrix[key1.Sequence.IndexOf(j), key2.Sequence.IndexOf(i)];
            }
        }

        return new string(charResult);
    }
}