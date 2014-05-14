using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCPU_16
{
    public static class Decryptor
    {
        public static Dictionary<int, string> Errors { get; private set; }
        public static Dictionary<int, string> Commands { get; private set; }
        public static Dictionary<int, string> NonBasicCommands { get; private set; }
        public static Dictionary<int, int> Instructions { get; private set; }
        public static Dictionary<int, int> NonBasicInstructions { get; private set; }
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
                              {0x09, "MDI"},
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
                              {0x1a, "ADX"},   
                              {0x1b, "SBX"},
                              //{0x1c, opRESERVED},
                              //{0x1d, opRESERVED},
                              {0x1e, "STI"},
                              {0x1f, "STD"},
                              /*----------non-basic instructions------------
                              //0x00 n/a 
                              {0x020, "JSR"},
                              {0x040, "READ"},
                              {0x100, "INT"},
                              {0x120, "IAG"},
                              {0x140, "IAS"}, 
                              {0x160, "RFI"},
                              {0x180,"IAQ"}*/
                           };

            NonBasicCommands = new Dictionary<int, string>
                           {
                              {0x01, "JSR"},
                              {0x02, "READ"},
                              {0x03, "READK"},
                              {0x08, "INT"},
                              {0x09, "IAG"},
                              {0x0a, "IAS"}, 
                              {0x0b, "RFI"},
                              {0x0c,"IAQ"}
                           };

            //values are wrong
            NonBasicInstructions = new Dictionary<int, int> 
            { 
                                    {28, 0x0020}, //JSR  0x01 -> 0x02 
                                    {29, 0x0040}, //READ
                                    {30, 0x0060}, //READK
                                    {31, 0x0100}, //INT
                                    {32, 0x0120}, //IAG
                                    {33, 0x0140}, //IAS 
                                    {34, 0x0160}, //RFI
                                    {35, 0x0180} //IAQ
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
                                    {9, 0x09}, //????MDI
                                    {10, 0x0a}, //AND
                                    {11, 0x0b}, //BOR
                                    {12, 0x0c}, //XOR
                                    {13, 0x0d}, //SHR
                                    {14, 0x0e}, //ASL
                                    {15, 0x0f}, //SHL
                                    {16, 0x10}, //IFB
                                    {17, 0x11}, //IFC
                                    {18, 0x12}, //IFE
                                    {19, 0x13}, //IFN
                                    {20, 0x14}, //IFG
                                    {21, 0x15}, //IFA
                                    {22, 0x16}, //IFL
                                    {23, 0x17}, //IFU
                                    //{0x18, opRESERVED}, 
                                    //{0x19, opRESERVED},
                                    {24, 0x1a},   //ADX
                                    {25, 0x1b}, //SBX
                                    //{0x1c, opRESERVED},
                                    //{0x1d, opRESERVED},
                                    {26, 0x1e}, //STI
                                    {27,0x1f}, //STD
                                    /*----------non-basic instructions------------
                                    {28, 0x020}, //JSR  0x01 -> 0x02 
                                    {29, 0x040}, //READ
                                    {30, 0x080}, //INT
                                    {31, 0x120}, //IAG
                                    {32, 0x140}, //IAS 
                                    {33, 0x160}, //RFI
                                    {34, 0x180} //IAQ*/
                               };

            
            Registers = new Dictionary<string, int>
                                {
                                    {"A", 0x0000},
                                    {"B", 0x0001},
                                    {"C", 0x0002},
                                    {"X", 0x0003},
                                    {"Y", 0x0004},
                                    {"Z", 0x0005},
                                    {"I", 0x0006},
                                    {"J", 0x0007},
                                };
        }
    }
}
