using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasicforJenkins
{
    public class Program
    {
        static void Main(string[] args)
        {
            //sample checkin 8 with nrok
            Console.Write("Main_Hello");
            Console.WriteLine(createMessage());
        }

        public static string createMessage()
        {
            return "Hello Message";
        }
    }
}
