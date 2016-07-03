using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Parser;

namespace Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            string testing = "Hello World! Are you okay? Today is Sunday.";
            Parsing parse = new Parsing();
            Text txt = parse.Parse(testing);
            Console.ReadKey();
        }
    }
}
