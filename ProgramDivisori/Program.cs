using System;
using ClassStampaDivisori;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramDivisori
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = ClasseCalcolaDivisori.LeggiNum();
            ClasseCalcolaDivisori.StampaDivisori(n);
            Console.ReadLine();
        }
    }
}
