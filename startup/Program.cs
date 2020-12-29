using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//Написать программу, которая при старте дописывает текущее время в файл
//«startup.txt».

namespace startup
{
    class Program
    {
        static void Main(string[] args)
        {  
            StreamWriter userData2 = new StreamWriter("startup.txt", true);
            userData2.WriteLine(DateTime.Now.ToShortTimeString());
            userData2.Close();
        }
    }
}
