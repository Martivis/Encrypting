using Vigenere;

Console.Write("Enter the message >> ");
var message = Console.ReadLine();
Console.Write("Enter the key >> ");
var key = Console.ReadLine();

var encrypted = VigenereEncryptor.Encrypt(message, key);
Console.WriteLine($"Encrypted: {encrypted}");

var decrypted = VigenereDecryptor.Decrypt(encrypted, key);
Console.WriteLine($"Decrypted: {decrypted}");

