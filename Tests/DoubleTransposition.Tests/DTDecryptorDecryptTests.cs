namespace DoubleTransposition.Tests;

public class DTDecryptorDecryptTests
{
    [Theory]
    [InlineData("аенофоее_отпакис_ввшнрийр", "35214", "43251", "шифрование_перестановкой_")]
    [InlineData("аенофоее\0отпакис_ввшнрийр", "35214", "43251", "шифрование_перестановкой")]
    public void EncryptingTest(string source, string sequence1, string sequence2, string expected)
    {
        // Arrange
        var key1 = new Key(sequence1);
        var key2 = new Key(sequence2);
        
        // Act
        var actual = DTDecryptor.Decrypt(source, key1, key2);
        
        // Assert
        Assert.Equal(expected, actual);
    }
}