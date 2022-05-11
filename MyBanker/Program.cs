using System;

namespace MyBanker
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[] { "2400" };
            SimpleCard s = new SimpleCard("Hævekort", 10000, arr, "123456", "Name");
            s.GeneratePrefix();

        }
    }
}
