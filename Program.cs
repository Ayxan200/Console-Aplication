using System;
using Console_Aplication.services;
using Mono.Cecil.Cil;

namespace Console_Aplication
{
    internal class Program
    {
        static void Main(string[] args)
        { Code_service code = new Code_service();
            Console.WriteLine("Academy Application\n");
            int selection;
            do
            {
                Console.WriteLine("1.Create Group");
                Console.WriteLine("2.Edit Group");
                Console.WriteLine("3.Get all group");
                Console.WriteLine("4.Get all student");
                Console.WriteLine("0.Exit");
                string strSelection = Console.ReadLine();
                bool result = int.TryParse(strSelection, out selection);  

                if (result)
                {
                    switch (selection)
                    {
                        case 1:
                            Code.create Group();
                            break;
                           

                           
                    }
                }
                
            } while (selection != 0);

        }
    }
}
