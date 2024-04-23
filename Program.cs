using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAsswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string chars = "QWERTYUIOPASDFGHJKLZXCVBNMqwertypüasdfghjklizxcvbnmö*-+";
            int length = 12;
            string password = "";
            for (int i = 0; i < length; i++) 
            {
                int randomchars = random.Next(chars.Length);
                password += chars[randomchars];

            }

            Console.WriteLine(password);
            Console.ReadLine();

        }
    }
}
