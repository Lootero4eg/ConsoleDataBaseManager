using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using cdbm.Enums;

namespace cdbm
{
    class Program
    {
        static void Main(string[] args)
        {
            string cmd = "";
            while (cmd != "quit")
            {
                Console.Write("cdbm> ");
                cmd = Console.ReadLine();

                if (cmd == "help")
                {
                    var res = Enum.GetNames(typeof(BaseCommands));
                    string descr = "";
                    for (int i = 0; i < res.Length; i++)
                        descr += res[i] + " ";
                    Console.WriteLine(descr);
                }
            }
        }
    }
}
