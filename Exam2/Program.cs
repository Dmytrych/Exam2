using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter("input.txt");
            writer.WriteLine("123   2333 3 5  23");
            writer.WriteLine("123   23 3 5  23");
            writer.Close();
            MaxRowPicker picker = new MaxRowPicker("input.txt");
            picker.WriteMaxSumRow();
            Console.ReadKey();
        }
    }
}
