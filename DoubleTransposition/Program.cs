using DoubleTransposition;

Console.Write("Enter the message >> ");
var message = Console.ReadLine();

try
{
    Console.Write("Enter key 1 >> ");
    var sequence1 = Console.ReadLine();
    var key1 = new Key(sequence1);
    
    Console.Write("Enter key 2 >> ");
    var sequence2 = Console.ReadLine();
    var key2 = new Key(sequence2);
    
    var encrypted = DTEncryptor.Encrypt(message, key1, key2);

    Console.WriteLine($"Encrypted: {encrypted}");

    var decrypted = DTDecryptor.Decrypt(encrypted, key1, key2);

    Console.WriteLine($"Decrypted: {decrypted}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
