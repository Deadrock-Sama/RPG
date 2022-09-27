using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectsCreator
{
    public class Cryptograph
    {

        public string CreateMD5(string input)
        {

            var md5 = System.Security.Cryptography.MD5.Create();

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            return BitConverter.ToString(hashBytes)
                .ToLower()
                .Replace("-", "");

        }
    }
}
