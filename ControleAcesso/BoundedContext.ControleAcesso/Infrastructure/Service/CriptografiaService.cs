using System.Security.Cryptography;

namespace BoundedContext.ControleAcesso.Infrastructure.Service
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

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
        }
    }
}