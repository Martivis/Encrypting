namespace DoubleTransposition;

public static class DTEncryptor
{
    public static string Encrypt(string source, Key key1, Key key2)
    {
        var columns = key1.Length;
        var rows = key2.Length;
        if (columns * rows < source.Length)
            throw new ArgumentException("Keys length is too low for this message");
        if (key1.Length != key2.Length)
            throw new ArgumentException("Keys should have the same length");
        
        var matrix = new char[rows, columns];
        
        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < columns; j++)
            {
                var sourceIndex = i * columns + j;
                if (sourceIndex >= source.Length)
                    break;
                matrix[key2.Sequence.IndexOf(i), key1.Sequence.IndexOf(j)] = source[sourceIndex];
            }
        }

        var charResult = new char[matrix.Length];
        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < columns; j++)
            {
                charResult[i * columns + j] = matrix[j, i];
            }
        }

        return new string(charResult);
    }
}