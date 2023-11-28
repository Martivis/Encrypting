namespace DoubleTransposition.Tests;

public class DTEncryprorEncryptTest
{
    [Theory]
    [InlineData("шифрование_перестановкой_", "35214", "43251", "аенофоее_отпакис_ввшнрийр")]
    public void EncryptingTest(string source, string sequence1, string sequence2, string expected)
    {
        // Arrange
        var key1 = new Key(sequence1);
        var key2 = new Key(sequence2);
        
        // Act
        var actual = DTEncryptor.Encrypt(source, key1, key2);
        
        // Assert
        Assert.Equal(expected, actual);
    }
}