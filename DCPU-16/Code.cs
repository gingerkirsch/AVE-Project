using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCPU_16
{
    public class Code
    {
        public ushort[] ProgramArray;
        public int Position;
        public int MaxLength;

        public Code(ushort maxLength)
        {
            ProgramArray = new ushort[maxLength];
            MaxLength = maxLength;
            Position = 0;
        }

        public bool Add(int index, ushort value)
        {
            if (index < 0 || index > MaxLength)
            {
                Console.WriteLine("1");
                return false;
            }

            if (value > Processor.MaxValue || value < Processor.MinValue)
            {
                Console.WriteLine("2");

                return false;
            }

            if (index >= Position)
            {
                Console.WriteLine("3");

                ProgramArray[index] = value;
                Position++;
                return true;
            }

            if (ProgramArray[index] == 0)
            {
                Console.WriteLine("4");

                ProgramArray[index] = value;
            }
            return false;
        }

        public bool DeleteCell(int index)
        {
            if (index < 0 || index > MaxLength)
            {
                return false;
            }

            ProgramArray[index] = 0;
            if (index == Position)
            {
                Position--;
            }
            return true;
        }
    }
}
