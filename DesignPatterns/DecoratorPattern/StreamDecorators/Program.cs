using System.Security.Cryptography;
using System.Text;

using (Aes encryption = Aes.Create())
{
    using (var stream = new FileStream("data.out", FileMode.OpenOrCreate))
    {
        // Create an encryptor to perform the stream transform.
        ICryptoTransform encryptor = encryption.CreateEncryptor(encryption.Key, encryption.IV);

        // Decorate the FileStream (Component) with CryptoStream (Decorator)
        using (var cryptoStream = new CryptoStream(stream, encryptor, CryptoStreamMode.Write))
        {
            byte[] data = ASCIIEncoding.ASCII.GetBytes("Endava One Love");

            // Write Some data through decorator
            stream.Write(data);
        }
    }
}