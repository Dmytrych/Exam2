using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    class MaxRowPicker
    {
        public string InputPath { get; private set; }
        public MaxRowPicker(string inputPath)
        {
            InputPath = inputPath;
        }
        public void WriteMaxSumRow()
        {
            StreamReader reader = new StreamReader(InputPath);
            int currentRow = 1,
                maxRow = -1,
                maxValue = -1,
                currentValue;
            while(reader.EndOfStream == false)
            {
                currentValue = CountRow(reader.ReadLine());
                if(currentValue > maxValue)
                {
                    maxValue = currentValue;
                    maxRow = currentRow;
                }
                currentRow++;
            }
            Console.WriteLine(maxRow + ": " + maxValue);
        }
        private int CountRow(string row)
        {
            row += " ";
            string num = "";
            int sum = 0;
            bool numFormationEnded = true;
            foreach(char c in row)
            {
                if(c != ' ')
                {
                    num += c;
                    numFormationEnded = false;
                }
                else if(numFormationEnded == false)
                {
                    sum += int.Parse(num);
                    num = "";
                    numFormationEnded = true;
                }
            }
            return sum;
        }
    }
}
