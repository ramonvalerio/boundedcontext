using System.Security.Cryptography;
using System.Text;

namespace BoundedContext.ControleAcesso.Infrastructure.Services
{
    public class CriptografiaService
    {
        public string GetMD5Hash(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new System.Exception("Argumento nulo ou vazio.");

            MD5 md5 = MD5.Create();

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            var sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
        }
    }
}