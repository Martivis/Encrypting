namespace DoubleTransposition;

public static class DTDecryptor
{
    public static string Decrypt(string source, Key key1, Key key2)
    {
        var columns = key2.Length;
        var rows = key1.Length;
        if (columns * rows < source.Length)
            throw new ArgumentException("Keys length is too low for this message");
        
        var matrix = new char[rows, columns];
        
        for (var i = 0; i < columns; i++)
        {
            for (var j = 0; j < rows; j++)
            {
                var sourceIndex = i * rows + j;
                if (sourceIndex > source.Length)
                    break;
                matrix[i, j] = source[sourceIndex];
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

        return new string(charResult).TrimEnd('\0');
    }
}