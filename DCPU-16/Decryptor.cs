using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCPU_16
{
    public class Decryptor
    {
        public static Dictionary<int, string> Errors { get; private set; }
        public static Dictionary<int, string> Commands { get; private set; }
        public static Dictionary<int, int> Instructions { get; private set; }
        public static Dictionary<string, int> Registers { get; private set; }

        static Decryptor()
        {
            Commands = new Dictionary<int, string>
                           { 
                              {0x01, "SET"},
                              {0x02, "ADD"},
                              {0x03, "SUB"},
                              {0x04, "MUL"},
                              {0x05, "MLI"},
                              {0x06, "DIV"},
                              {0x07, "DVI"},
                              {0x08, "MOD"},
                            //  {0x09, opMDI},
                              {0x0a, "AND"},
                              {0x0b, "BOR"},
                              {0x0c, "XOR"},
                              {0x0d, "SHR"},
                              {0x0e, "ASR"},
                              {0x0f, "SHL"},
                               {0x10, "IFB"},
                              {0x11, "IFC"},
                              {0x12, "IFE"},
                              {0x13, "IFN"},
                              {0x14, "IFG"},
                              {0x15, "IFA"},
                              {0x16, "IFL"},
                              {0x17, "IFU"},
                              //{0x18, opRESERVED}, 
                              //{0x19, opRESERVED},
                              //{0x1a, opADX},
                              {0x1a, "READ"},   //our command
                              {0x1b, "SBX"},
                              //{0x1c, opRESERVED},
                              //{0x1d, opRESERVED},
                              {0x1e, "STI"},
                              {0x1f, "STD"}
                           };

            Errors = new Dictionary<int, string>
                         {
                             {0, "No errors"},
                             {1, "Unknown instruction"},
                             {2, "Dividing by zero"},
                             {3, "Overflow"},
                             {4, "Out of memory"}
                         };

            Instructions = new Dictionary<int, int>
                               {
                                   //{0, 00},
                                   {1, 0x01}, //SET
                                   {2, 0x02}, //ADD
                                   {3, 0x03}, //SUB
                                   {4, 0x04}, //MUL
                                   {5, 0x05}, //MLI
                                   {6, 0x06}, //DIV
                                   {7, 0x07}, //DVI
                                   {8, 0x08}, //MOD
                                    //to be continued
                               };

            Registers = new Dictionary<string, int>
                                {
                                    {"A", 0x000},
                                    {"B", 0x020},
                                    {"C", 0x040},
                                    {"X", 0x060},
                                    {"Y", 0x080},
                                    {"Z", 0x0a0},
                                    {"I", 0x0c0},
                                    {"J", 0x0e0},
                                };
        }
    }
}
