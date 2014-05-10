using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DCPU_16.Forms;

namespace DCPU_16
{
    public class Executor
    {
        public Processor P;
        public static StringBuilder Output { get; private set; }
        private static StringBuilder Dump { get; set; }

        public void Execute()
        {
            if (!Prepearing())
            {
                return;
            }

            //call the p.step with amount of instructions
            P.Step(20);
            //CheckErrors();
        }

        public bool Prepearing()
        {
            Output = new StringBuilder("Execution has started...\n");

            if (P == null)
            {
                Output.Append("Can't find a processor\n");
                return false;
            }

            //empty memory check?
            return true;
        }

       /*  public void CheckErrors()
           {
               if(P.Error == 0)
               {
                   Output.Append("Programm has completed successfully\n");
               }
               else
               {
                   string error;
                   Decryptor.Errors.TryGetValue(P.Error, out error);
                   Output.AppendFormat("Error: {0}\n", error);
               }
           }*/

        public static int Read()
        {
            var form = new InputForm();
            form.ShowDialog();
            Output.AppendFormat("Input value: {0}\n", form.Value);
            return form.Value;
        }

        public static void Write(int value)
        {
            Output.AppendFormat("Result: {0}\n", value);
        }

        public string GetDump(short startAddr, short endAddr)
        {
            ushort currBlock = 0;
            ushort firstAddr = (ushort)(startAddr & (ushort)0xfff8u);
            ushort lastAddr = (ushort)(endAddr | (ushort)0x0003u);
            StringBuilder output = new StringBuilder();
            while (firstAddr + (currBlock * 8) < lastAddr)
            {
                output.Append(((firstAddr + (currBlock * 8)).ToString("X4")) + ":");
                for (ushort i = 0; i < 8; i++)
                {
                    output.Append(" " + Processor._RAM[firstAddr + i + (currBlock * 8)].ToString("X4"));
                }
                output.Append("\n");
                currBlock++;
            }



            Dump = new StringBuilder();
            Dump.AppendFormat("Program Counter = {0}\n", P.PC);
            Dump.AppendFormat("Memory Size = {0}\n\n", Processor.RAMSize);

            for (var i = 0; i < Processor.RAMSize; i++)
            {
                Dump.AppendFormat("{0:00}:{1:0000}{2}", i, Processor._RAM[i], (i + 1) % 10 == 0 ? '\n' : '\t');
            }
            return Dump.ToString();
        }

    }
}
